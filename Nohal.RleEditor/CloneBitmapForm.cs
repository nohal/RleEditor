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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Nohal.RleEditor.RleParser;

namespace Nohal.RleEditor
{
    public partial class CloneBitmapForm : DialogForm
    {
        private ListViewItem _lvItem;

        public Symbol Symbol { get; set; } 

        public CloneBitmapForm()
        {
            InitializeComponent();
        }

        private void CloneBitmapForm_Load(object sender, EventArgs e)
        {
            tbSymbolName.Text = this.Symbol.Code;
            tbSymbolDescription.Text = this.Symbol.Description;

            // Add a few items to the combo box list.
            foreach (string cr in Symbol.ColorTable.Colors.Keys)
            {
                this.cbPaletteColors.Items.Add(cr);
            }

            // Set view of ListView to Details.
            this.listViewPalette.View = View.Details;

            // Turn on full row select.
            this.listViewPalette.FullRowSelect = true;

            // Add data to the ListView.
            ColumnHeader columnheader;
            ListViewItem listviewitem;

            foreach (KeyValuePair<char, ColorRecord> color in Symbol.Colors)
            {
                listviewitem = new ListViewItem(color.Value.Code);
                listviewitem.SubItems.Add(color.Key.ToString());
                this.listViewPalette.Items.Add(listviewitem);
            }

            // Create column headers for the data.
            columnheader = new ColumnHeader();
            columnheader.Text = "Color code";
            this.listViewPalette.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Char";
            this.listViewPalette.Columns.Add(columnheader);

            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in this.listViewPalette.Columns)
            {
                ch.Width = -2;
            }

        }

        private void CloneBitmapForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                if (((RleEditorForm)Owner).parser.SymbolBitmaps.Keys.Contains(tbSymbolName.Text) || ((RleEditorForm)Owner).parser.PatternBitmaps.Keys.Contains(tbSymbolName.Text))
                {
                    MessageBox.Show("Symbol with this code already exists, can't create the new one!", "Problem",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Cancel = true;
                    return;
                }
                this.Symbol.Code = tbSymbolName.Text;
                this.Symbol.Description = tbSymbolDescription.Text;
                this.Symbol.Colors.Clear();
                foreach (ListViewItem item in listViewPalette.Items)
                {
                    this.Symbol.Colors.Add(Convert.ToChar(item.SubItems[1].Text), Symbol.ColorTable.Colors[item.Text]);
                }
            }
        }

        private void cbPaletteColors_SelectedValueChanged(object sender, EventArgs e)
        {
            // Set text of ListView item to match the ComboBox.
            _lvItem.Text = this.cbPaletteColors.Text;

            // Hide the ComboBox.
            this.cbPaletteColors.Visible = false;

        }

        private void cbPaletteColors_Leave(object sender, EventArgs e)
        {
            // Set text of ListView item to match the ComboBox.
            _lvItem.Text = this.cbPaletteColors.Text;

            // Hide the ComboBox.
            this.cbPaletteColors.Visible = false;

        }

        private void cbPaletteColors_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the user presses ESC.
            switch (e.KeyChar)
            {
                case (char)(int)Keys.Escape:
                    {
                        // Reset the original text value, and then hide the ComboBox.
                        this.cbPaletteColors.Text = _lvItem.Text;
                        this.cbPaletteColors.Visible = false;
                        break;
                    }

                case (char)(int)Keys.Enter:
                    {
                        // Hide the ComboBox.
                        this.cbPaletteColors.Visible = false;
                        break;
                    }
            }

        }

        private void listViewPalette_MouseUp(object sender, MouseEventArgs e)
        {
            // Get the item on the row that is clicked.
            _lvItem = this.listViewPalette.GetItemAt(e.X, e.Y);

            // Make sure that an item is clicked.
            if (_lvItem != null)
            {
                // Get the bounds of the item that is clicked.
                Rectangle ClickedItem = _lvItem.Bounds;

                // Verify that the column is completely scrolled off to the left.
                if ((ClickedItem.Left + this.listViewPalette.Columns[0].Width) < 0)
                {
                    // If the cell is out of view to the left, do nothing.
                    return;
                }

                // Verify that the column is partially scrolled off to the left.
                else if (ClickedItem.Left < 0)
                {
                    // Determine if column extends beyond right side of ListView.
                    if ((ClickedItem.Left + this.listViewPalette.Columns[0].Width) > this.listViewPalette.Width)
                    {
                        // Set width of column to match width of ListView.
                        ClickedItem.Width = this.listViewPalette.Width;
                        ClickedItem.X = 0;
                    }
                    else
                    {
                        // Right side of cell is in view.
                        ClickedItem.Width = this.listViewPalette.Columns[0].Width + ClickedItem.Left;
                        ClickedItem.X = 2;
                    }
                }
                else if (this.listViewPalette.Columns[0].Width > this.listViewPalette.Width)
                {
                    ClickedItem.Width = this.listViewPalette.Width;
                }
                else
                {
                    ClickedItem.Width = this.listViewPalette.Columns[0].Width;
                    ClickedItem.X = 2;
                }

                // Adjust the top to account for the location of the ListView.
                ClickedItem.Y += this.listViewPalette.Top;
                ClickedItem.X += this.listViewPalette.Left;

                // Assign calculated bounds to the ComboBox.
                this.cbPaletteColors.Bounds = ClickedItem;

                // Set default text for ComboBox to match the item that is clicked.
                this.cbPaletteColors.Text = _lvItem.Text;

                // Display the ComboBox, and make sure that it is on top with focus.
                this.cbPaletteColors.Visible = true;
                this.cbPaletteColors.BringToFront();
                this.cbPaletteColors.Focus();
            }

        }

        private void cbPaletteColors_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            string s = Symbol.ColorTable.Colors.Values.ToArray()[e.Index].Code;
            Color c = Symbol.ColorTable.Colors.Values.ToArray()[e.Index].Color;
            e.Graphics.FillRectangle(new SolidBrush(c), e.Bounds);
            e.Graphics.DrawString(s, e.Font, new SolidBrush(Color.Black), e.Bounds);
            e.DrawFocusRectangle();
        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            for (char c = 'A'; c < 'Z'; c++)
            {
                if (!Symbol.Colors.Keys.Contains(c))
                {
                    ColorRecord cr = Symbol.ColorTable.Colors.Values.First();
                    Symbol.Colors.Add(c, cr);
                    ListViewItem listviewitem = new ListViewItem(cr.Code);
                    listviewitem.SubItems.Add(c.ToString());
                    this.listViewPalette.Items.Add(listviewitem);
                    return;
                }
            }
        }
    }
}
