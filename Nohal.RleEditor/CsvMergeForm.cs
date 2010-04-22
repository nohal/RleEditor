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
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Nohal.RleEditor.RleParser;

namespace Nohal.RleEditor
{
    public partial class CsvMergeForm : DialogForm
    {
        public CsvMergeForm()
        {
            InitializeComponent();
        }

        private void FillOtherMasterFilesFromClasses()
        {
            string directory = Path.GetDirectoryName(tbMasterClasses.Text);
            if (File.Exists(Path.Combine(directory, "s57attributes.csv")))
            {
                if (tbMasterAttributes.Text == String.Empty)
                {
                    tbMasterAttributes.Text = Path.Combine(directory, "s57attributes.csv");
                }
            }
            if (File.Exists(Path.Combine(directory, "s57expectedinput.csv")))
            {
                if (tbMasterExpectedInput.Text == String.Empty)
                {
                    tbMasterExpectedInput.Text = Path.Combine(directory, "s57expectedinput.csv");
                }
            }
            if (File.Exists(Path.Combine(directory, "attdecode.csv")))
            {
                if (tbMasterDecoding.Text == String.Empty)
                {
                    tbMasterDecoding.Text = Path.Combine(directory, "attdecode.csv");
                }
            }
            if (tbOutputPath.Text == String.Empty)
            {
                tbOutputPath.Text = directory;
            }
        }

        private void FillOtherMergeFilesFromClasses()
        {
            string directory = Path.GetDirectoryName(tbMergeClasses.Text);
            if (File.Exists(Path.Combine(directory, "s57attributes.csv")))
            {
                if (tbMergeAttributes.Text == String.Empty)
                {
                    tbMergeAttributes.Text = Path.Combine(directory, "s57attributes.csv");
                }
            }
            if (File.Exists(Path.Combine(directory, "s57expectedinput.csv")))
            {
                if (tbMergeExpectedInput.Text == String.Empty)
                {
                    tbMergeExpectedInput.Text = Path.Combine(directory, "s57expectedinput.csv");
                }
            }
            if (File.Exists(Path.Combine(directory, "attdecode.csv")))
            {
                if (tbMergeDecoding.Text == String.Empty)
                {
                    tbMergeDecoding.Text = Path.Combine(directory, "attdecode.csv");
                }
            }
        }

        private void btnOpenMasterClasses_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "CSV Files|*.CSV|All Files|*.*";
            dlg.InitialDirectory = ((RleEditorForm) Owner).config.S57Folder;
            dlg.FileName = "s57objectclasses.csv";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbMasterClasses.Text = dlg.FileName;
                FillOtherMasterFilesFromClasses();
            }
        }

        private void btnOpenMergeClasses_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "CSV Files|*.CSV|All Files|*.*";
            //dlg.InitialDirectory = ((RleEditorForm)Owner).config.S57Folder;
            dlg.FileName = "s57objectclasses.csv";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbMergeClasses.Text = dlg.FileName;
                FillOtherMergeFilesFromClasses();
            }
        }

        private void btnOpenMasterAttributes_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "CSV Files|*.CSV|All Files|*.*";
            dlg.FileName = "s57attributes.csv";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbMasterAttributes.Text = dlg.FileName;
            }
        }

        private void btnOpenMasterDecoding_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "CSV Files|*.CSV|All Files|*.*";
            dlg.FileName = "attdecode.csv";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbMasterDecoding.Text = dlg.FileName;
            }
        }

        private void btnOpenMasterExpectedInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "CSV Files|*.CSV|All Files|*.*";
            dlg.FileName = "s57expectedinput.csv";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbMasterExpectedInput.Text = dlg.FileName;
            }
        }

        private void btnOpenMergeAttributes_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "CSV Files|*.CSV|All Files|*.*";
            dlg.FileName = "s57attributes.csv";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbMergeAttributes.Text = dlg.FileName;
            }
        }

        private void btnOpenMergeDecoding_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "CSV Files|*.CSV|All Files|*.*";
            dlg.FileName = "attdecode.csv";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbMergeDecoding.Text = dlg.FileName;
            }
        }

        private void btnOpenMergeExpectedInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "CSV Files|*.CSV|All Files|*.*";
            dlg.FileName = "s57expectedinput.csv";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbMergeExpectedInput.Text = dlg.FileName;
            }
        }

        private void CsvMergeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(Path.Combine(tbOutputPath.Text, "s57objectclasses.csv")) || File.Exists(Path.Combine(tbOutputPath.Text, "s57attributes.csv")) || File.Exists(Path.Combine(tbOutputPath.Text, "attdecode.csv")) || File.Exists(Path.Combine(tbOutputPath.Text, "s57expectedinput.csv")))
                {
                    DialogResult res = MessageBox.Show(
                        "One or more output files already exists. Do you want to overwrite?", "Warning",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (res == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                        return;
                    }
                    if (res == DialogResult.No)
                    {
                        return;
                    }
                }
                if (File.Exists(tbMasterClasses.Text) && File.Exists(tbMasterAttributes.Text) && File.Exists(tbMasterDecoding.Text) && File.Exists(tbMasterExpectedInput.Text) &&
                    File.Exists(tbMergeClasses.Text) && File.Exists(tbMergeAttributes.Text) && File.Exists(tbMergeDecoding.Text) && File.Exists(tbMergeExpectedInput.Text))
                {
                    S57Data masterData = new S57Data(tbMasterClasses.Text, tbMasterAttributes.Text,
                                                     tbMasterDecoding.Text, tbMasterExpectedInput.Text);
                    S57Data mergeData = new S57Data(tbMergeClasses.Text, tbMergeAttributes.Text, tbMergeDecoding.Text,
                                                    tbMergeExpectedInput.Text);
                    masterData.Merge(mergeData);
                    masterData.Save(Path.Combine(tbOutputPath.Text, "s57objectclasses.csv"),
                                    Path.Combine(tbOutputPath.Text, "s57attributes.csv"),
                                    Path.Combine(tbOutputPath.Text, "attdecode.csv"),
                                    Path.Combine(tbOutputPath.Text, "s57expectedinput.csv"));
                }
                else
                {
                    MessageBox.Show("Not all files exist, can't merge.", "Warning", MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                    e.Cancel = true;
                }
            }
        }

        private void btnOutputPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbOutputPath.Text = dlg.SelectedPath;
            }
        }
    }
}
