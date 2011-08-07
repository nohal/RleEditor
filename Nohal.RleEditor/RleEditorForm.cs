#region License Details
// --------------------------------------------------------------------------------------------
// This file is part of RleEditor.
// 
//     RleEditor is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     RleEditor is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with RleEditor.  If not, see <http://www.gnu.org/licenses/>.
// --------------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using LumenWorks.Framework.IO.Csv;
using Nohal.RleEditor.RleParser;
using Nohal.RleEditor.RleParser.Utils;
using Bitmap=Nohal.RleEditor.RleParser.Symbol;

namespace Nohal.RleEditor
{
    using System.Drawing.Imaging;

    public partial class RleEditorForm : Form
    {
        public RleEditorForm()
        {
            InitializeComponent();
            Debug.Print("Application starting at {0}", DateTime.Now);
            config.Load();
        }

        internal RleParser.RleParser parser;
        private string openfilename;
        internal EditorConfiguration config = new EditorConfiguration();
        private bool changesSaved = true;
        private List<S57ObjectClass> objectClasses = new List<S57ObjectClass>();

        private void FillForm()
        {
            foreach (var table in parser.ColorTables)
            {
                comboBoxBitmapColorTables.Items.Add(table.Value.Name);
                comboBoxVectorColorTables.Items.Add(table.Value.Name);
                comboBoxColorTablesList.Items.Add(table.Value.Name);
            }
            comboBoxBitmapColorTables.SelectedIndex = 0;
            comboBoxVectorColorTables.SelectedIndex = 0;
            comboBoxColorTablesList.SelectedIndex = 0;
            foreach (var bitmap in parser.SymbolBitmaps)
            {
                listBoxBitmaps.Items.Add(bitmap.Value.Code);
            }
            foreach (var bitmap in parser.PatternBitmaps)
            {
                listBoxBitmaps.Items.Add(bitmap.Value.Code);
            }
            foreach (var vector in parser.SymbolVectors)
            {
                listBoxVectors.Items.Add(vector.Value.Code);
            }
            foreach (var vector in parser.LineVectors)
            {
                listBoxVectors.Items.Add(vector.Value.Code);
            }
            foreach (var vector in parser.PatternVectors)
            {
                listBoxVectors.Items.Add(vector.Value.Code);
            }
            FillColorTableView(comboBoxColorTablesList.SelectedItem.ToString());
        }

        private void LoadRleFile(string filename)
        {
            CleanForm();
            openfilename = filename;
            parser = new RleParser.RleParser(filename);
            changesSaved = true;
            FillForm();
        }

        private void OpenRleFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Rule Files|*.RLE|All Files|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBoxFilename.Text = dlg.FileName;
                if (File.Exists(dlg.FileName))
                {
                    LoadRleFile(dlg.FileName);
                }
                else
                {
                    parser = null;
                }
                tabControl.Enabled = true;
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenRleFile();
        }

        private void FillColorTableView(string tablename)
        {
            listViewColorTable.Items.Clear();
            ListViewItem li;
            RleParser.Utils.RGB rgb;
            foreach (var color in parser.ColorTables[tablename].Colors)
            {
                rgb = RleParser.Utils.ColorSpaceHelper.XYZtoRGB(RleParser.Utils.ColorSpaceHelper.YxytoXYZ(color.Value.Yxy));
                li = new ListViewItem(new string[] { color.Value.Code, color.Value.Name, color.Value.Yxy.Y.ToString(), color.Value.Yxy.x.ToString(), color.Value.Yxy.y.ToString() }, 0, Color.FromArgb(255, 255, 255), Color.FromArgb(rgb.Red, rgb.Green, rgb.Blue), null);
                listViewColorTable.Items.Add(li);
            }
            listViewColorTable.AutoResizeColumns(ColumnHeaderAutoResizeStyle.None);
        }

        private void listBoxBitmaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySelectedBitmap();
        }

        private void DisplaySelectedBitmap()
        {
            if (listBoxBitmaps.SelectedItem != null)
            {
                string selected = listBoxBitmaps.SelectedItem.ToString();

                if (parser.SymbolBitmaps.Keys.Contains(selected))
                {
                    SetImage(parser.SymbolBitmaps[selected]);
                    textBoxBitmapVal1.Text = parser.SymbolBitmaps[selected].SymbolType.ToString();
                    textBoxBitmapVal2.Text = string.Empty;
                    numericUpDownBitmapValue3.Value = 0;
                    numericUpDownBitmapValue4.Value = 0;
                    numericUpDownBitmapSymbolId.Value = parser.SymbolBitmaps[selected].ObjectId;
                    textBoxBitmapDescription.Text = parser.SymbolBitmaps[selected].Description;
                    tbSymbolCode.Text = parser.SymbolBitmaps[selected].Code;
                    textBoxBitmapText.Text = parser.SymbolBitmaps[selected].ToString();
                    numericUpDownBitmapHeight.Value = parser.SymbolBitmaps[selected].Height;
                    numericUpDownBitmapWidth.Value = parser.SymbolBitmaps[selected].Width;
                    numericUpDownBitmapOffsetX.Value = parser.SymbolBitmaps[selected].OffsetX;
                    numericUpDownBitmapOffsetY.Value = parser.SymbolBitmaps[selected].OffsetY;
                    numericUpDownBitmapHotspotX.Value = parser.SymbolBitmaps[selected].HotspotX;
                    numericUpDownBitmapHotspotY.Value = parser.SymbolBitmaps[selected].HotspotY;
                }
                else
                {
                    SetImage(parser.PatternBitmaps[selected]);
                    textBoxBitmapVal1.Text = parser.PatternBitmaps[selected].SymbolType.ToString();
                    textBoxBitmapVal2.Text = parser.PatternBitmaps[selected].Value2;
                    numericUpDownBitmapValue3.Value = parser.PatternBitmaps[selected].Value3;
                    numericUpDownBitmapValue4.Value = parser.PatternBitmaps[selected].Value4;
                    numericUpDownBitmapSymbolId.Value = parser.PatternBitmaps[selected].ObjectId;
                    textBoxBitmapDescription.Text = parser.PatternBitmaps[selected].Description;
                    tbSymbolCode.Text = parser.PatternBitmaps[selected].Code;
                    textBoxBitmapText.Text = parser.PatternBitmaps[selected].ToString();
                    numericUpDownBitmapHeight.Value = parser.PatternBitmaps[selected].Height;
                    numericUpDownBitmapWidth.Value = parser.PatternBitmaps[selected].Width;
                    numericUpDownBitmapOffsetX.Value = parser.PatternBitmaps[selected].OffsetX;
                    numericUpDownBitmapOffsetY.Value = parser.PatternBitmaps[selected].OffsetY;
                    numericUpDownBitmapHotspotX.Value = parser.PatternBitmaps[selected].HotspotX;
                    numericUpDownBitmapHotspotY.Value = parser.PatternBitmaps[selected].HotspotY;
                }
            }
        }

        private void comboBoxColorTablesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxColorTablesList.SelectedItem != null)
                FillColorTableView(comboBoxColorTablesList.SelectedItem.ToString());
        }

        private void CleanForm()
        {
            textBoxVectors.Text = string.Empty;
            listViewLookupTable.Items.Clear();
            comboBoxLookupTables.SelectedIndex = -1;
            comboBoxBitmapColorTables.SelectedIndex = -1;
            comboBoxColorTablesList.SelectedIndex = -1;
            listViewColorTable.Items.Clear();
            listBoxBitmaps.Items.Clear();
            listBoxVectors.Items.Clear();
            CleanPictureEditor();
        }

        private void CleanPictureEditor()
        {
            pictureBoxBitmapEditor.Image = null;
            pictureBoxBitmapView.Image = null;
        }

        private void SetImage(Bitmap btmp)
        {
            btmp.ChangeColorTable(parser.ColorTables[comboBoxBitmapColorTables.SelectedItem.ToString()]);
            FillPictureEditor(btmp, parser.ColorTables[comboBoxBitmapColorTables.SelectedItem.ToString()]);
            pictureBoxBitmapView.Image = btmp.Image;
        }

        private List<ColorRecord> clrs = new List<ColorRecord>();

        private void FillPictureEditor(Bitmap btmp, ColorTable workingPalette)
        {
            if (comboBoxZoom.SelectedItem == null)
                comboBoxZoom.SelectedIndex = 0;
            btmp.ChangeColorTable(workingPalette);
            clrs.Clear();
            foreach (var color in btmp.Colors.Values)
            {
                clrs.Add(color);
            }
            clrs.Add(new ColorRecord("TRANS", "Transparent", new CIEYxy(1, 1, 1)));
            colorComboBox1.Items.Clear();
            colorComboBox1.Items.AddRange(clrs.ToArray());
            colorComboBox1.SelectedIndex = 1;
            colorComboBox1.Refresh();
            string zoom = comboBoxZoom.SelectedItem.ToString();
            pictureBoxBitmapEditor.Image = btmp.GetZoomedImage(Convert.ToInt32(zoom.Substring(0, zoom.Length - 1)) / 100, true);
            pictureBoxBitmapEditor.Width = pictureBoxBitmapEditor.Image.Width + 1;
            pictureBoxBitmapEditor.Height = pictureBoxBitmapEditor.Image.Height + 1;
        }

        private void comboBoxLookupTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefillLookupTableView();
        }

        private void RefillLookupTableView()
        {
            listViewLookupTable.Columns[0].Width = listViewLookupTable.Width;
            listViewLookupTable.Items.Clear();
            switch (comboBoxLookupTables.SelectedIndex)
            {
                case 0:
                    foreach (LookupTable lt in parser.LookupTables[RleParser.RleParser.PAPER_CHART].Values)
                    {
                        listViewLookupTable.Items.Add(lt.ToLuptString(), lt.ObjectId.ToString());
                    }
                    break;
                case 1:
                    foreach (LookupTable lt in parser.LookupTables[RleParser.RleParser.SIMPLIFIED].Values)
                    {
                        listViewLookupTable.Items.Add(lt.ToLuptString(), lt.ObjectId.ToString());
                    }
                    break;
                case 2:
                    foreach (LookupTable lt in parser.LookupTables[RleParser.RleParser.LINES].Values)
                    {
                        listViewLookupTable.Items.Add(lt.ToLuptString(), lt.ObjectId.ToString());
                    }
                    break;
                case 3:
                    foreach (LookupTable lt in parser.LookupTables[RleParser.RleParser.PLAIN_BOUNDARIES].Values)
                    {
                        listViewLookupTable.Items.Add(lt.ToLuptString(), lt.ObjectId.ToString());
                    }
                    break;
                case 4:
                    foreach (LookupTable lt in parser.LookupTables[RleParser.RleParser.SYMBOLIZED_BOUNDARIES].Values)
                    {
                        listViewLookupTable.Items.Add(lt.ToLuptString(), lt.ObjectId.ToString());
                    }
                    break;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenRleFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveChanges(openfilename);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.AllowFullOpen = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    CIEYxy Yxy = ColorSpaceHelper.XYZtoYxy(ColorSpaceHelper.RGBtoXYZ(dlg.Color));
                    numericUpDownEditColorY.Value = (decimal)Math.Round(Yxy.Y, 2);
                    numericUpDownEditColorx.Value = (decimal)Math.Round(Yxy.x, 2);
                    numericUpDownEditColory1.Value = (decimal)Math.Round(Yxy.y, 2);
                }
                catch (Exception)
                {
                    MessageBox.Show("Selected color is not possible to interpret in Yxy color space...", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SetSampleColor();
                }
            }
        }

        private void SetSampleColor()
        {
            if (listViewColorTable.FocusedItem != null)
            {
                textBoxColorCode.Text =
                    parser.ColorTables[comboBoxColorTablesList.SelectedItem.ToString()].Colors[
                        listViewColorTable.FocusedItem.Text].Code;
                textBoxColorName.Text =
                    parser.ColorTables[comboBoxColorTablesList.SelectedItem.ToString()].Colors[
                        listViewColorTable.FocusedItem.Text].Name;
                numericUpDownEditColorY.Value =
                    (decimal)
                    parser.ColorTables[comboBoxColorTablesList.SelectedItem.ToString()].Colors[
                        listViewColorTable.FocusedItem.Text].Yxy.Y;
                numericUpDownEditColorx.Value =
                    (decimal)
                    parser.ColorTables[comboBoxColorTablesList.SelectedItem.ToString()].Colors[
                        listViewColorTable.FocusedItem.Text].Yxy.x;
                numericUpDownEditColory1.Value =
                    (decimal)
                    parser.ColorTables[comboBoxColorTablesList.SelectedItem.ToString()].Colors[
                        listViewColorTable.FocusedItem.Text].Yxy.y;
                ShowColorChanges();
            }
        }

        private void listViewColorTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSampleColor();
        }

        private void RenderSquare(int x, int y, int size, Color color, bool border)
        {
            if (pictureBoxBitmapEditor.Image != null)
            {
                System.Drawing.Bitmap btmp = new System.Drawing.Bitmap(pictureBoxBitmapEditor.Image);
                if (x < btmp.Width && y < btmp.Height)
                {
                    Bitmap.RenderSquare(ref btmp, x / size * size, y / size * size, size, clrs[colorComboBox1.SelectedIndex].Color, true);
                    pictureBoxBitmapEditor.Image = btmp;
                }
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            string zoomstr = comboBoxZoom.SelectedItem.ToString();
            int zoom = Convert.ToInt32(zoomstr.Substring(0, zoomstr.Length - 1)) / 100;
            string selected = listBoxBitmaps.SelectedItem.ToString();
            if (parser.SymbolBitmaps.Keys.Contains(selected))
            {
                parser.SymbolBitmaps[selected].ChangePixel(e.X / zoom, e.Y / zoom, clrs[colorComboBox1.SelectedIndex].Code);
            }
            if (parser.PatternBitmaps.Keys.Contains(selected))
            {
                parser.SymbolBitmaps[selected].ChangePixel(e.X / zoom, e.Y / zoom, clrs[colorComboBox1.SelectedIndex].Code);

            }
            RenderSquare(e.X, e.Y, zoom,
                         clrs[colorComboBox1.SelectedIndex].Color, true);
            changesSaved = false;
        }

        private void comboBoxZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySelectedBitmap();
        }

        private void ColorY_ValueChanged(object sender, EventArgs e)
        {
            ShowColorChanges();
        }

        private void numericUpDownEditColory1_ValueChanged(object sender, EventArgs e)
        {
            ShowColorChanges();
        }

        private void numericUpDownEditColorx_ValueChanged(object sender, EventArgs e)
        {
            ShowColorChanges();
        }

        private void ShowColorChanges()
        {
            CIEYxy yxy = new CIEYxy((double)numericUpDownEditColorY.Value, (double)numericUpDownEditColorx.Value,
                                    (double)numericUpDownEditColory1.Value);
            if (yxy.x > 0 && yxy.y > 0)
            {
                pictureBoxColorSample.BackColor = Color.FromArgb(255,
                                                                 ColorSpaceHelper.XYZtoRGB(ColorSpaceHelper.YxytoXYZ(yxy))
                                                                     .Red,
                                                                 ColorSpaceHelper.XYZtoRGB(ColorSpaceHelper.YxytoXYZ(yxy))
                                                                     .Green,
                                                                 ColorSpaceHelper.XYZtoRGB(ColorSpaceHelper.YxytoXYZ(yxy))
                                                                     .Blue);
            }
        }

        private void buttonCommitColorChange_Click(object sender, EventArgs e)
        {
            CIEYxy yxy = new CIEYxy((double)numericUpDownEditColorY.Value, (double)numericUpDownEditColorx.Value,
                                    (double)numericUpDownEditColory1.Value);
            if (yxy.x > 0 && yxy.y > 0)
            {
                parser.ColorTables[comboBoxColorTablesList.SelectedItem.ToString()].Colors[
                    listViewColorTable.FocusedItem.Text].Yxy = yxy;
                FillColorTableView(comboBoxColorTablesList.SelectedItem.ToString());
            }
            changesSaved = false;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Rasterization Rules Files|*.RLE|All Files|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                SaveChanges(dlg.FileName);
                LoadRleFile(dlg.FileName);
                openfilename = dlg.FileName;
                textBoxFilename.Text = dlg.FileName;
            }
        }

        private void listBoxVectors_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySelectedVector();
        }

        private void DisplaySelectedVector()
        {
            if (listBoxVectors.SelectedItem != null)
            {
                string selected = listBoxVectors.SelectedItem.ToString();

                if (parser.SymbolVectors.Keys.Contains(selected))
                {
                    textBoxVectors.Text = parser.SymbolVectors[selected].ToString();
                    textBoxBitmapVal1.Text = parser.SymbolVectors[selected].SymbolType.ToString();
                    textBoxBitmapVal2.Text = string.Empty;
                    numericUpDownVectorVal3.Value = 0;
                    numericUpDownVectorVal4.Value = 0;
                    numericUpDownVectorSymbolId.Value = parser.SymbolVectors[selected].ObjectId;
                    textBoxVectorDescription.Text = parser.SymbolVectors[selected].Description;
                    tbVectorCode.Text = parser.SymbolVectors[selected].Code;
                    numericUpDownVectorHeight.Value = parser.SymbolVectors[selected].Height;
                    numericUpDownVectorWidth.Value = parser.SymbolVectors[selected].Width;
                    numericUpDownVectorOffsetX.Value = parser.SymbolVectors[selected].OffsetX;
                    numericUpDownVectorOffsetY.Value = parser.SymbolVectors[selected].OffsetY;
                    numericUpDownVectorHotspotX.Value = parser.SymbolVectors[selected].HotspotX;
                    numericUpDownVectorHotspotY.Value = parser.SymbolVectors[selected].HotspotY;
                    pictureBoxVectorRendering.Image = parser.SymbolVectors[selected].GetVectorRendering(parser.ColorTables[comboBoxVectorColorTables.SelectedItem.ToString()]);
                    pictureBoxVectorRendering.Width = pictureBoxVectorRendering.Image.Width + 1;
                    pictureBoxVectorRendering.Height = pictureBoxVectorRendering.Image.Height + 1;
                }
                else if (parser.PatternVectors.Keys.Contains(selected))
                {
                    textBoxVectors.Text = parser.PatternVectors[selected].ToString();
                    textBoxBitmapVal1.Text = parser.PatternVectors[selected].SymbolType.ToString();
                    textBoxBitmapVal2.Text = parser.PatternVectors[selected].Value2;
                    numericUpDownVectorVal3.Value = parser.PatternVectors[selected].Value3;
                    numericUpDownVectorVal4.Value = parser.PatternVectors[selected].Value4;
                    numericUpDownVectorSymbolId.Value = parser.PatternVectors[selected].ObjectId;
                    textBoxVectorDescription.Text = parser.PatternVectors[selected].Description;
                    tbVectorCode.Text = parser.PatternVectors[selected].Code;
                    numericUpDownVectorHeight.Value = parser.PatternVectors[selected].Height;
                    numericUpDownVectorWidth.Value = parser.PatternVectors[selected].Width;
                    numericUpDownVectorOffsetX.Value = parser.PatternVectors[selected].OffsetX;
                    numericUpDownVectorOffsetY.Value = parser.PatternVectors[selected].OffsetY;
                    numericUpDownVectorHotspotX.Value = parser.PatternVectors[selected].HotspotX;
                    numericUpDownVectorHotspotY.Value = parser.PatternVectors[selected].HotspotY;
                    pictureBoxVectorRendering.Image = parser.PatternVectors[selected].GetVectorRendering(parser.ColorTables[comboBoxVectorColorTables.SelectedItem.ToString()]);
                    pictureBoxVectorRendering.Width = pictureBoxVectorRendering.Image.Width + 1;
                    pictureBoxVectorRendering.Height = pictureBoxVectorRendering.Image.Height + 1;
                }
                else
                {
                    textBoxVectors.Text = parser.LineVectors[selected].ToString();
                    textBoxBitmapVal1.Text = parser.LineVectors[selected].SymbolType.ToString();
                    textBoxBitmapVal2.Text = String.Empty;
                    numericUpDownVectorVal3.Value = 0;
                    numericUpDownVectorVal4.Value = 0;
                    numericUpDownVectorSymbolId.Value = parser.LineVectors[selected].ObjectId;
                    textBoxVectorDescription.Text = parser.LineVectors[selected].Description;
                    tbVectorCode.Text = parser.LineVectors[selected].Code;
                    numericUpDownVectorHeight.Value = parser.LineVectors[selected].Height;
                    numericUpDownVectorWidth.Value = parser.LineVectors[selected].Width;
                    numericUpDownVectorOffsetX.Value = parser.LineVectors[selected].OffsetX;
                    numericUpDownVectorOffsetY.Value = parser.LineVectors[selected].OffsetY;
                    numericUpDownVectorHotspotX.Value = parser.LineVectors[selected].HotspotX;
                    numericUpDownVectorHotspotY.Value = parser.LineVectors[selected].HotspotY;
                    pictureBoxVectorRendering.Image = parser.LineVectors[selected].GetVectorRendering(parser.ColorTables[comboBoxVectorColorTables.SelectedItem.ToString()]);
                    pictureBoxVectorRendering.Width = pictureBoxVectorRendering.Image.Width + 1;
                    pictureBoxVectorRendering.Height = pictureBoxVectorRendering.Image.Height + 1;
                }
            }
        }

        private void btnDeleteBitmap_Click(object sender, EventArgs e)
        {
            string selected = listBoxBitmaps.SelectedItem.ToString();

            if (parser.SymbolBitmaps.Keys.Contains(selected))
            {
                parser.SymbolBitmaps.Remove(selected);
            }
            else
            {
                parser.PatternBitmaps.Remove(selected);
            }
            listBoxBitmaps.Items.Remove(listBoxBitmaps.SelectedItem);
            if (listBoxBitmaps.Items.Count > 0)
            {
                listBoxBitmaps.SelectedIndex = 0;
            }
        }

        private void btnDelVector_Click(object sender, EventArgs e)
        {
            string selected = listBoxVectors.SelectedItem.ToString();

            if (parser.SymbolVectors.Keys.Contains(selected))
            {
                parser.SymbolVectors.Remove(selected);
            }
            else if (parser.PatternVectors.Keys.Contains(selected))
            {
                parser.PatternVectors.Remove(selected);
            }
            else
            {
                parser.LineVectors.Remove(selected);
            }
            listBoxVectors.Items.Remove(listBoxVectors.SelectedItem);
            if (listBoxVectors.Items.Count > 0)
            {
                listBoxVectors.SelectedIndex = 0;
            }
        }

        private void btnExportBitmaps_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Symbol Bitmap Files Hi-Res|*.rah|Symbol Bitmap Files Med-Res|*.ram|Symbol Bitmap Files Lo-Res|*.ral|All Files|*.*";
            dlg.FileName = "allbitmaps";
            dlg.AddExtension = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                parser.SaveBitmapsToFile(dlg.FileName);
            }
        }

        private void btnExportVectors_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Symbol Vector Files|*.sym|All Files|*.*";
            dlg.FileName = "allvectors";
            dlg.AddExtension = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                parser.SaveVectorsToFile(dlg.FileName);
            }
        }

        private void btnExportLookupTable_Click(object sender, EventArgs e)
        {
            if (SelectedLupt() == String.Empty)
            {
                MessageBox.Show("First select a lookup table...", "Info", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return;
            }
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Lookup Table Files|*.dic|All Files|*.*";
            dlg.FileName = SelectedLupt();
            dlg.AddExtension = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                switch (comboBoxLookupTables.SelectedIndex)
                {
                    case 0:
                        parser.SaveTextToFile(dlg.FileName, parser.GetPointsPaperChartText());
                        break;
                    case 1:
                        parser.SaveTextToFile(dlg.FileName, parser.GetPointsSimplifiedText());
                        break;
                    case 2:
                        parser.SaveTextToFile(dlg.FileName, parser.GetLinesText());
                        break;
                    case 3:
                        parser.SaveTextToFile(dlg.FileName, parser.GetAreaPlainBoundariesText());
                        break;
                    case 4:
                        parser.SaveTextToFile(dlg.FileName, parser.GetAreaSymbolizedBoundariesText());
                        break;
                }
            }
        }

        /// <summary>
        /// Merge from file, if record with same objectClass and attr combination already exists, replace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReplaceTableFromFile_Click(object sender, EventArgs e)
        {
            if (SelectedLupt() == String.Empty)
            {
                MessageBox.Show("First select a lookup table...", "Info", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return;
            }
            ReplaceLupt(SelectedLupt());
        }

        private void ReplaceLupt(string luptName)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Lookup Table Files|*.dic|All Files|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dlg.FileName))
                {
                    StreamReader sr = new StreamReader(dlg.FileName);
                    string line;
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        if (!line.StartsWith(";") && !line.StartsWith("*")) //Not header or remark
                        {
                            LookupTable lt = new LookupTable(line, 0, luptName);
                            bool found = false;
                            foreach (LookupTable lupt in parser.LookupTables[luptName].Values)
                            {
                                if (lupt.CompareTo(lt) == 0)
                                {
                                    lt.ObjectId = lupt.ObjectId;
                                    found = true;
                                }
                            }
                            if (!found)
                            {
                                lt.ObjectId = parser.NextId;
                                parser.NextId++;
                                parser.LookupTables[luptName].Add(lt.ObjectId, lt);
                            }
                            else
                            {
                                parser.LookupTables[luptName][lt.ObjectId] = lt;
                            }
                        }
                    }
                    sr.Close();
                    changesSaved = false;
                    RefillLookupTableView();
                }
            }
        }

        private void MergeLupt(string luptName)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Lookup Table Files|*.dic|All Files|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dlg.FileName))
                {
                    StreamReader sr = new StreamReader(dlg.FileName);
                    string line;
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        if (!line.StartsWith(";") && !line.StartsWith("*") && line != String.Empty) //Do not try to import header or remark
                        {
                            LookupTable lt = new LookupTable(line, 0, luptName);
                            bool found = false;
                            foreach (LookupTable lupt in parser.LookupTables[luptName].Values)
                            {
                                if (lupt.CompareTo(lt) == 0)
                                {
                                    found = true;
                                }
                            }
                            if (!found)
                            {
                                lt.ObjectId = parser.NextId;
                                parser.NextId++;
                                parser.LookupTables[luptName].Add(lt.ObjectId, lt);
                            }
                        }
                    }
                    sr.Close();
                    changesSaved = false;
                    RefillLookupTableView();
                }
            }
        }

        /// <summary>
        /// Merge from file, if record with same objectid and attr combination already exists, skip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMergeLookupTable_Click(object sender, EventArgs e)
        {
            if (SelectedLupt() == String.Empty)
            {
                MessageBox.Show("First select a lookup table...", "Info", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return;
            }
            MergeLupt(SelectedLupt());
        }

        private void btnMergeVectors_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Symbol Vector Files|*.sym|All Files|*.*";
            dlg.Multiselect = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in dlg.FileNames)
                {
                    if (File.Exists(fileName))
                    {
                        StreamReader sr = new StreamReader(fileName);
                        parser.MergeVectors(sr.ReadToEnd());
                        sr.Close();
                    }
                }
                changesSaved = false;
                CleanForm();
                FillForm();
            }
        }

        private void btnMergeBitmaps_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Symbol Bitmap Files|*.rah;*.ram;*.ral|All Files|*.*";
            dlg.Multiselect = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in dlg.FileNames)
                {
                    if (File.Exists(fileName))
                    {
                        StreamReader sr = new StreamReader(fileName);
                        parser.MergeBitmaps(sr.ReadToEnd());
                        sr.Close();
                    }
                }
                changesSaved = false;
                CleanForm();
                FillForm();
            }
        }

        private void btnExportVector_Click(object sender, EventArgs e)
        {
            if (listBoxVectors.SelectedItem != null)
            {
                string selected = listBoxVectors.SelectedItem.ToString();
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "Symbol Vector Files|*.sym|PNG Bitmap|*.png|JPEG Bitmap|*.jpg|All Files|*.*";
                dlg.FileName = selected;
                dlg.AddExtension = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    switch (Path.GetExtension(dlg.FileName).ToLower())
                    {
                        case ".jpg":
                            if (parser.SymbolVectors.Keys.Contains(selected))
                            {
                                parser.ExportSymbolToBitmap(dlg.FileName, parser.SymbolVectors[selected], ImageFormat.Jpeg);
                            }
                            if (parser.PatternVectors.Keys.Contains(selected))
                            {
                                parser.ExportSymbolToBitmap(dlg.FileName, parser.PatternVectors[selected], ImageFormat.Jpeg);
                            }
                            if (parser.LineVectors.Keys.Contains(selected))
                            {
                                parser.ExportSymbolToBitmap(dlg.FileName, parser.LineVectors[selected], ImageFormat.Jpeg);
                            }
                            break;
                        case ".png":
                            if (parser.SymbolVectors.Keys.Contains(selected))
                            {
                                parser.ExportSymbolToBitmap(dlg.FileName, parser.SymbolVectors[selected], ImageFormat.Png);
                            }
                            if (parser.PatternVectors.Keys.Contains(selected))
                            {
                                parser.ExportSymbolToBitmap(dlg.FileName, parser.PatternVectors[selected], ImageFormat.Png);
                            }
                            if (parser.LineVectors.Keys.Contains(selected))
                            {
                                parser.ExportSymbolToBitmap(dlg.FileName, parser.LineVectors[selected], ImageFormat.Png);
                            }
                            break;
                        default:
                            if (parser.SymbolVectors.Keys.Contains(selected))
                            {
                                parser.SaveSymbolToFile(dlg.FileName, parser.SymbolVectors[selected]);
                            }
                            if (parser.PatternVectors.Keys.Contains(selected))
                            {
                                parser.SaveSymbolToFile(dlg.FileName, parser.PatternVectors[selected]);
                            }
                            if (parser.LineVectors.Keys.Contains(selected))
                            {
                                parser.SaveSymbolToFile(dlg.FileName, parser.LineVectors[selected]);
                            }
                            break;
                    }
                }
            }
        }

        private void btnExportBitmap_Click(object sender, EventArgs e)
        {
            if (listBoxBitmaps.SelectedItem != null)
            {
                string selected = listBoxBitmaps.SelectedItem.ToString();
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "Symbol Bitmap Files Hi-Res|*.rah|Symbol Bitmap Files Med-Res|*.ram|Symbol Bitmap Files Lo-Res|*.ral|PNG Bitmap|*.png|JPEG Bitmap|*.jpg|All Files|*.*";
                dlg.FileName = selected;
                dlg.AddExtension = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    switch (Path.GetExtension(dlg.FileName).ToLower())
                    {
                        case ".jpg":
                            if (parser.SymbolBitmaps.Keys.Contains(selected))
                            {
                                parser.ExportSymbolToBitmap(dlg.FileName, parser.SymbolBitmaps[selected], ImageFormat.Jpeg);
                            }
                            if (parser.PatternBitmaps.Keys.Contains(selected))
                            {
                                parser.ExportSymbolToBitmap(dlg.FileName, parser.PatternBitmaps[selected], ImageFormat.Jpeg);
                            }
                            break;
                        case ".png":
                            if (parser.SymbolBitmaps.Keys.Contains(selected))
                            {
                                parser.ExportSymbolToBitmap(dlg.FileName, parser.SymbolBitmaps[selected], ImageFormat.Png);
                            }
                            if (parser.PatternBitmaps.Keys.Contains(selected))
                            {
                                parser.ExportSymbolToBitmap(dlg.FileName, parser.PatternBitmaps[selected], ImageFormat.Png);
                            }
                            break;
                        default:
                            if (parser.SymbolBitmaps.Keys.Contains(selected))
                            {
                                parser.SaveSymbolToFile(dlg.FileName, parser.SymbolBitmaps[selected]);
                            }
                            if (parser.PatternBitmaps.Keys.Contains(selected))
                            {
                                parser.SaveSymbolToFile(dlg.FileName, parser.PatternBitmaps[selected]);
                            }
                            break;
                    }
                }
            }
        }

        private void SortLupt(Dictionary<int, LookupTable> lupt)
        {
            List<LookupTable> ltl = new List<LookupTable>();
            ltl.AddRange(lupt.Values);
            ltl.Sort();
            lupt.Clear();
            foreach (LookupTable tbl in ltl)
            {
                lupt.Add(tbl.ObjectId, tbl);
            }
        }

        private void btnSortLupt_Click(object sender, EventArgs e)
        {
            if (SelectedLupt() == String.Empty)
            {
                MessageBox.Show("First select a lookup table...", "Info", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return;
            }
            SortLupt(parser.LookupTables[SelectedLupt()]);
            RefillLookupTableView();
            changesSaved = false;
        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://redmine.kalian.cz/projects/opencpn/wiki/Rasterization_Rules_Editor");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox dlg = new AboutBox();
            dlg.ShowDialog();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm dlg = new SettingsForm();
            dlg.Config = config;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                config.Save();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShutdownApplication()
        {
            if (!changesSaved)
            {
                if (MessageBox.Show("Changes not saved. Save now?", "Save changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveChanges(openfilename);
                }
            }
            config.LastUsedFile = textBoxFilename.Text;
            config.Save();
            Debug.Print("Application shutdown at {0}", DateTime.Now);
            Debug.Flush();
        }

        private void SaveChanges(string filename)
        {
            if (this.config.AutoSortLupts)
            {
                this.SortAllLookupTables();
            }
            parser.SaveRleToFile(filename, config.FileHeader);
            changesSaved = true;
        }

        private void RLEEditorFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShutdownApplication();
        }

        private void RleEditorFrm_Load(object sender, EventArgs e)
        {
            if (config.OpenLastUsedOnStartup)
            {
                if (File.Exists(config.LastUsedFile))
                {
                    textBoxFilename.Text = config.LastUsedFile;
                    LoadRleFile(config.LastUsedFile);
                    tabControl.Enabled = true;
                }
                else
                {
                    parser = null;
                }
            }

            if (config.S57Folder != null)
            {
                string objClassesFile = Path.Combine(config.S57Folder, "s57objectclasses.csv");
                if (File.Exists(objClassesFile))
                {
                    CsvReader csvu = new CsvReader(new StreamReader(objClassesFile), true, ',');
                    while (csvu.ReadNextRecord())
                    {
                        objectClasses.Add(new S57ObjectClass
                                              {
                                                  Code = Convert.ToInt32(csvu["Code"]),
                                                  ObjectClass = csvu["ObjectClass"],
                                                  Acronym = csvu["Acronym"],
                                                  AttributeA = csvu["Attribute_A"],
                                                  AttributeB = csvu["Attribute_B"],
                                                  AttributeC = csvu["Attribute_C"],
                                                  Class = csvu["Class"],
                                                  Primitives = csvu["Primitives"]
                                              });
                    }
                }
            }
        }

        private void bitmapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnMergeBitmaps_Click(sender, e);
        }

        private void vectorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnExportVectors_Click(sender, e);
        }

        private void bitmapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnExportBitmaps_Click(sender, e);
        }

        private void vectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnMergeVectors_Click(sender, e);
        }

        private void btnExportColorTable_Click(object sender, EventArgs e)
        {
            if (comboBoxColorTablesList.SelectedItem != null)
            {
                string selected = comboBoxColorTablesList.SelectedItem.ToString();
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "Color Table Files|*.cta|All Files|*.*";
                dlg.FileName = selected;
                dlg.AddExtension = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    parser.SaveColorTableToFile(dlg.FileName, parser.ColorTables[selected]);
                }
            }
        }

        private void btnExportColorTables_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Color Table Files|*.cta|All Files|*.*";
            dlg.FileName = "allcolors";
            dlg.AddExtension = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                parser.SaveColorTablesToFile(dlg.FileName);
            }
        }

        private string SelectedLupt()
        {
            switch (comboBoxLookupTables.SelectedIndex)
            {
                case 0:
                    return RleParser.RleParser.PAPER_CHART;
                case 1:
                    return RleParser.RleParser.SIMPLIFIED;
                case 2:
                    return RleParser.RleParser.LINES;
                case 3:
                    return RleParser.RleParser.PLAIN_BOUNDARIES;
                case 4:
                    return RleParser.RleParser.SYMBOLIZED_BOUNDARIES;
                default:
                    return string.Empty;
            }
        }

        private void btnCloneRule_Click(object sender, EventArgs e)
        {
            if (SelectedLupt() == String.Empty || listViewLookupTable.SelectedItems.Count == 0)
            {
                MessageBox.Show("First select a lookup table and rule...", "Info", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return;
            }
            LuptEditorForm dlg = new LuptEditorForm();
            dlg.ObjectClasses = this.objectClasses;
            dlg.Lupt =
                parser.LookupTables[SelectedLupt()][Convert.ToInt32(listViewLookupTable.SelectedItems[0].ImageKey)].Clone();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                dlg.Lupt.ObjectId = parser.NextId;
                parser.NextId++;

                parser.LookupTables[SelectedLupt()].Add(dlg.Lupt.ObjectId, dlg.Lupt);

                listViewLookupTable.Items.Add(dlg.Lupt.ToLuptString(), dlg.Lupt.ObjectId.ToString());
                changesSaved = false;
            }
            listViewLookupTable.SelectedIndices.Clear();
            listViewLookupTable.SelectedIndices.Add(listViewLookupTable.Items.Count - 1); //TODO - scroll
            listViewLookupTable.SelectedItems[0].EnsureVisible();
            listViewLookupTable.Focus();
        }

        private void btnEditLupt_Click(object sender, EventArgs e)
        {
            if (SelectedLupt() == String.Empty || listViewLookupTable.SelectedItems.Count == 0)
            {
                MessageBox.Show("First select a lookup table and rule...", "Info", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return;
            }
            LuptEditorForm dlg = new LuptEditorForm();
            dlg.ObjectClasses = this.objectClasses;
            dlg.Lupt =
                parser.LookupTables[SelectedLupt()][Convert.ToInt32(listViewLookupTable.SelectedItems[0].ImageKey)];
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                parser.LookupTables[SelectedLupt()][dlg.Lupt.ObjectId] = dlg.Lupt;

                int x = listViewLookupTable.SelectedIndices[0];
                listViewLookupTable.Items[x] = new ListViewItem(dlg.Lupt.ToLuptString(), dlg.Lupt.ObjectId.ToString());
                listViewLookupTable.SelectedIndices.Add(x);
            }
            listViewLookupTable.Focus();
        }

        private void btnNewRule_Click(object sender, EventArgs e)
        {
            if (SelectedLupt() == String.Empty)
            {
                MessageBox.Show("First select a lookup table...", "Info", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return;
            }
            LuptEditorForm dlg = new LuptEditorForm();
            dlg.ObjectClasses = this.objectClasses;
            dlg.Lupt = new LookupTable(String.Empty);
            dlg.Lupt.Symbolization = SelectedLupt();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                dlg.Lupt.ObjectId = parser.NextId;
                parser.NextId++;
                parser.LookupTables[SelectedLupt()].Add(dlg.Lupt.ObjectId, dlg.Lupt);
                RefillLookupTableView();
                listViewLookupTable.SelectedIndices.Clear();
                listViewLookupTable.SelectedIndices.Add(listViewLookupTable.Items.Count - 1);
                listViewLookupTable.SelectedItems[0].EnsureVisible();
                listViewLookupTable.Focus();
                changesSaved = false;
            }
        }

        private void sortAllLookupTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortAllLookupTables();
        }

        private void SortAllLookupTables()
        {
            SortLupt(parser.LookupTables[RleParser.RleParser.PAPER_CHART]);
            SortLupt(parser.LookupTables[RleParser.RleParser.SIMPLIFIED]);
            SortLupt(parser.LookupTables[RleParser.RleParser.LINES]);
            SortLupt(parser.LookupTables[RleParser.RleParser.PLAIN_BOUNDARIES]);
            SortLupt(parser.LookupTables[RleParser.RleParser.SYMBOLIZED_BOUNDARIES]);
            RefillLookupTableView();
            changesSaved = false;
        }

        private void resetNumberingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int luptId = 30000;
            foreach (LookupTable lt in parser.LookupTables[RleParser.RleParser.PAPER_CHART].Values)
            {
                lt.ObjectId = luptId;
                luptId++;
            }
            foreach (LookupTable lt in parser.LookupTables[RleParser.RleParser.SIMPLIFIED].Values)
            {
                lt.ObjectId = luptId;
                luptId++;
            }
            foreach (LookupTable lt in parser.LookupTables[RleParser.RleParser.LINES].Values)
            {
                lt.ObjectId = luptId;
                luptId++;
            }
            foreach (LookupTable lt in parser.LookupTables[RleParser.RleParser.PLAIN_BOUNDARIES].Values)
            {
                lt.ObjectId = luptId;
                luptId++;
            }
            foreach (LookupTable lt in parser.LookupTables[RleParser.RleParser.SYMBOLIZED_BOUNDARIES].Values)
            {
                lt.ObjectId = luptId;
                luptId++;
            }
            SortAllLookupTables();
        }

        private void btnDeleteLupt_Click(object sender, EventArgs e)
        {
            if (SelectedLupt() == String.Empty || listViewLookupTable.SelectedItems.Count == 0)
            {
                MessageBox.Show("First select a lookup table and rule...", "Info", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return;
            }
            parser.LookupTables[SelectedLupt()].Remove(Convert.ToInt32(listViewLookupTable.SelectedItems[0].ImageKey));
            int selected = listViewLookupTable.SelectedIndices[0];
            listViewLookupTable.Items.RemoveAt(selected);
            if (listViewLookupTable.Items.Count > 0)
            {
                listViewLookupTable.SelectedIndices.Add(
                    selected < listViewLookupTable.Items.Count ? selected : selected - 1);
            }
            listViewLookupTable.Focus();
            changesSaved = false;
        }

        private void colorTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnExportColorTables_Click(sender, e);
        }

        private void btnCloneBitmap_Click(object sender, EventArgs e)
        {
            if (listBoxBitmaps.SelectedItem != null)
            {
                CloneBitmapForm dlg = new CloneBitmapForm();

                string selected = listBoxBitmaps.SelectedItem.ToString();
                if (parser.SymbolBitmaps.Keys.Contains(selected))
                {
                    BitmapSymbol bs = parser.SymbolBitmaps[selected].Clone();
                    dlg.Symbol = bs;
                    if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        try
                        {
                            parser.SymbolBitmaps.Add(bs.Code, bs);
                        }
                        catch (ArgumentException)
                        {
                            MessageBox.Show("Bad luck. Symbol with the same name already exists :(", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if (parser.PatternBitmaps.Keys.Contains(selected))
                {
                    BitmapPattern bp = parser.PatternBitmaps[selected].Clone();
                    dlg.Symbol = bp;
                    if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        try
                        {
                            parser.PatternBitmaps.Add(bp.Code, bp);
                        }
                        catch (ArgumentException)
                        {
                            MessageBox.Show("Bad luck. Symbol with the same name already exists :(", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                changesSaved = false;
                CleanForm();
                FillForm();
                listBoxBitmaps.SelectedItem = dlg.Symbol.Code;
            }
        }

        private void colorComboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index > clrs.Count - 1) return;
            string s = clrs[e.Index].Code;
            Color c = clrs[e.Index].Color;
            e.Graphics.FillRectangle(new SolidBrush(c), e.Bounds);
            e.Graphics.DrawString(s, e.Font, new SolidBrush(Color.Black), e.Bounds);
            e.DrawFocusRectangle();
        }

        private void pointsPAPERCHARTToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MergeLupt(RleParser.RleParser.PAPER_CHART);
        }

        private void pointsSIMPLIFIEDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MergeLupt(RleParser.RleParser.SIMPLIFIED);
        }

        private void linesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MergeLupt(RleParser.RleParser.LINES);
        }

        private void areaPLAINBORDERSToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MergeLupt(RleParser.RleParser.PLAIN_BOUNDARIES);
        }

        private void areaSYMBOLIZEDBORDERSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MergeLupt(RleParser.RleParser.SYMBOLIZED_BOUNDARIES);
        }

        private void pointsPAPERCHARTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReplaceLupt(RleParser.RleParser.PAPER_CHART);
        }

        private void pointsSIMPLIFIEDToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReplaceLupt(RleParser.RleParser.SIMPLIFIED);
        }

        private void linesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReplaceLupt(RleParser.RleParser.LINES);
        }

        private void areaPLAINBORDERSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReplaceLupt(RleParser.RleParser.PLAIN_BOUNDARIES);
        }

        private void areaSYMBOLIZEDBORDERSToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReplaceLupt(RleParser.RleParser.SYMBOLIZED_BOUNDARIES);
        }

        private void clearAllLookupTaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parser.LookupTables[RleParser.RleParser.PAPER_CHART].Clear();
            parser.LookupTables[RleParser.RleParser.SIMPLIFIED].Clear();
            parser.LookupTables[RleParser.RleParser.LINES].Clear();
            parser.LookupTables[RleParser.RleParser.PLAIN_BOUNDARIES].Clear();
            parser.LookupTables[RleParser.RleParser.SYMBOLIZED_BOUNDARIES].Clear();
            RefillLookupTableView();
            changesSaved = false;
        }

        private void btnCloneVector_Click(object sender, EventArgs e)
        {
            if (listBoxVectors.SelectedItem != null)
            {
                CloneVectorForm dlg = new CloneVectorForm();

                string selected = listBoxVectors.SelectedItem.ToString();
                if (parser.SymbolVectors.Keys.Contains(selected))
                {
                    VectorSymbol vs = parser.SymbolVectors[selected].Clone();
                    dlg.Symbol = vs;
                    if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        try
                        {
                            parser.SymbolVectors.Add(vs.Code, vs);
                        }
                        catch (ArgumentException)
                        {
                            MessageBox.Show("Bad luck. Symbol with the same name already exists :(", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if (parser.LineVectors.Keys.Contains(selected))
                {
                    VectorLine vl = parser.LineVectors[selected].Clone();
                    dlg.Symbol = vl;
                    if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        try
                        {
                            parser.LineVectors.Add(vl.Code, vl);
                        }
                        catch (ArgumentException)
                        {
                            MessageBox.Show("Bad luck. Symbol with the same name already exists :(", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if (parser.PatternVectors.Keys.Contains(selected))
                {
                    VectorPattern vp = parser.PatternVectors[selected].Clone();
                    dlg.Symbol = vp;
                    if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        try
                        {
                            parser.PatternVectors.Add(vp.Code, vp);
                        }
                        catch (ArgumentException)
                        {
                            MessageBox.Show("Bad luck. Symbol with the same name already exists :(", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                changesSaved = false;
                CleanForm();
                FillForm();
                listBoxVectors.SelectedItem = dlg.Symbol.Code;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CsvMergeForm dlg = new CsvMergeForm();
            dlg.ShowDialog(this);
        }

        private void listViewLookupTable_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnEditLupt_Click(sender, e);
        }

        private void btnMergeColorTables_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter =
                "Color Table Files|*.cta|Rasterization Rules Files|*.RLE|All Files|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                RleParser.RleParser par = new RleParser.RleParser(dlg.FileName);
                foreach (KeyValuePair<string, ColorTable> pair in par.ColorTables)
                {
                    if (!parser.ColorTables.Keys.Contains(pair.Key))
                    {
                        parser.ColorTables.Add(pair.Key, pair.Value);
                    }

                }
            }
            changesSaved = false;
        }

        private void btnReplaceColorTables_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter =
                "Color Table Files|*.cta|Rasterization Rules Files|*.RLE|All Files|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                RleParser.RleParser par = new RleParser.RleParser(dlg.FileName);
                foreach (KeyValuePair<string, ColorTable> pair in par.ColorTables)
                {
                    if (!parser.ColorTables.Keys.Contains(pair.Key))
                    {
                        parser.ColorTables.Add(pair.Key, pair.Value);
                    }
                    else
                    {
                        parser.ColorTables[pair.Key] = pair.Value;
                    }

                }
            }
            changesSaved = false;
        }

        private void btnDeleteColorTable_Click(object sender, EventArgs e)
        {
            string selected = comboBoxColorTablesList.SelectedItem.ToString();
            if (selected == "DAY_BRIGHT")
            {
                MessageBox.Show("The DAY_BRIGHT palette can't be deleted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            parser.ColorTables.Remove(selected);
            comboBoxColorTablesList.Items.Remove(selected);
            comboBoxColorTablesList.SelectedIndex = 0;
            changesSaved = false;
        }

        private void comboBoxBitmapColorTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBitmapColorTables.SelectedIndex > -1)
            {
                DisplaySelectedBitmap();   
            }
        }

        private void comboBoxVectorColorTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxVectorColorTables.SelectedIndex > -1)
            {
                DisplaySelectedVector();   
            }
        }

        private void symbolsToPNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.ShowNewFolderButton = true;
            dlg.Description = "Select a folder where all the bitmaps will be saved.";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                string path = dlg.SelectedPath;
                foreach(BitmapSymbol s in parser.SymbolBitmaps.Values) {
                    parser.ExportSymbolToBitmap(Path.Combine(path, s.Code) + ".png", s, ImageFormat.Png);
                }
                foreach (BitmapPattern s in parser.PatternBitmaps.Values)
                {
                    parser.ExportSymbolToBitmap(Path.Combine(path, s.Code) + ".png", s, ImageFormat.Png);
                }
            }
        }
    }
}
