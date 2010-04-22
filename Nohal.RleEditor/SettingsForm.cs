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

using System.Text;
using System.Windows.Forms;

namespace Nohal.RleEditor
{
    public partial class SettingsForm : DialogForm
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        public EditorConfiguration Config { get; set; }

        private void btnBrowseS57Folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbS57Folder.Text = dlg.SelectedPath;
            }
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                Config.S57Folder = tbS57Folder.Text;
                Config.OpenLastUsedOnStartup = cbOpenLastUsed.Checked;
                Config.AutoSortLupts = cbAutoSortLupts.Checked;
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            tbS57Folder.Text = Config.S57Folder;
            cbOpenLastUsed.Checked = Config.OpenLastUsedOnStartup;
            cbAutoSortLupts.Checked = Config.AutoSortLupts;
        }
    }
}
