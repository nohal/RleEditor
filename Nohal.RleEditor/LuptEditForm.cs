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
using Nohal.RleEditor.RleParser;

namespace Nohal.RleEditor
{
    public partial class LuptEditorForm : DialogForm
    {
        public List<S57ObjectClass> ObjectClasses { get; set; }

        public LookupTable Lupt { get; set; }

        public LuptEditorForm()
        {
            InitializeComponent();
        }

        private void LuptEditorForm_Load(object sender, EventArgs e)
        {
            foreach (S57ObjectClass ocls in ObjectClasses)
            {
                this.comboBoxClasses.Items.Add(ocls.Acronym);
            }
            comboBoxClasses.Text = Lupt.Code;
            comboBoxRadar.Text = Lupt.Radar;
            comboBoxDisplayCategory.Text = Lupt.ImoDisplayCategory;
            tbAttributeCombination.Text = Lupt.AttributeCombination;
            tbSymbolizationInstruction.Text = Lupt.SymbolizationInstructions;
            tbViewingGroup.Text = Lupt.ViewingGroup;
            numericUpDownDisplayPriority.Value = Convert.ToDecimal(Lupt.DisplayPriority);
            tbSymbolization.Text = Lupt.Symbolization;
            tbSymbolizationLetter.Text = Lupt.SymbolizationLetter;
        }

        private void LuptEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                Lupt.Code = comboBoxClasses.Text;
                Lupt.Radar = comboBoxRadar.Text;
                Lupt.ImoDisplayCategory = comboBoxDisplayCategory.Text;
                Lupt.AttributeCombination = tbAttributeCombination.Text;
                Lupt.SymbolizationInstructions = tbSymbolizationInstruction.Text;
                Lupt.ViewingGroup = tbViewingGroup.Text;
                Lupt.DisplayPriority = numericUpDownDisplayPriority.Value.ToString();
                Lupt.Symbolization = tbSymbolization.Text;
                if (!Lupt.IsValid())
                {
                    MessageBox.Show("Object is not valid, can't continue...", "Warning", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }
    }
}

