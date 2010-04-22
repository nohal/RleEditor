namespace Nohal.RleEditor
{
    partial class CloneBitmapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbSymbolName = new System.Windows.Forms.TextBox();
            this.lblSymbolDescription = new System.Windows.Forms.Label();
            this.tbSymbolDescription = new System.Windows.Forms.TextBox();
            this.listViewPalette = new Nohal.RleEditor.PaletteListView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPaletteColors = new System.Windows.Forms.ComboBox();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Symbol name";
            // 
            // tbSymbolName
            // 
            this.tbSymbolName.Location = new System.Drawing.Point(15, 29);
            this.tbSymbolName.Name = "tbSymbolName";
            this.tbSymbolName.Size = new System.Drawing.Size(100, 22);
            this.tbSymbolName.TabIndex = 3;
            // 
            // lblSymbolDescription
            // 
            this.lblSymbolDescription.AutoSize = true;
            this.lblSymbolDescription.Location = new System.Drawing.Point(12, 54);
            this.lblSymbolDescription.Name = "lblSymbolDescription";
            this.lblSymbolDescription.Size = new System.Drawing.Size(127, 17);
            this.lblSymbolDescription.TabIndex = 4;
            this.lblSymbolDescription.Text = "Symbol description";
            // 
            // tbSymbolDescription
            // 
            this.tbSymbolDescription.Location = new System.Drawing.Point(15, 74);
            this.tbSymbolDescription.Name = "tbSymbolDescription";
            this.tbSymbolDescription.Size = new System.Drawing.Size(797, 22);
            this.tbSymbolDescription.TabIndex = 5;
            // 
            // listViewPalette
            // 
            this.listViewPalette.Location = new System.Drawing.Point(15, 119);
            this.listViewPalette.Name = "listViewPalette";
            this.listViewPalette.Size = new System.Drawing.Size(229, 271);
            this.listViewPalette.TabIndex = 6;
            this.listViewPalette.UseCompatibleStateImageBehavior = false;
            this.listViewPalette.View = System.Windows.Forms.View.Details;
            this.listViewPalette.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listViewPalette_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Palette";
            // 
            // cbPaletteColors
            // 
            this.cbPaletteColors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPaletteColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaletteColors.FormattingEnabled = true;
            this.cbPaletteColors.Location = new System.Drawing.Point(18, 396);
            this.cbPaletteColors.Name = "cbPaletteColors";
            this.cbPaletteColors.Size = new System.Drawing.Size(121, 23);
            this.cbPaletteColors.TabIndex = 8;
            this.cbPaletteColors.Visible = false;
            this.cbPaletteColors.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbPaletteColors_DrawItem);
            this.cbPaletteColors.Leave += new System.EventHandler(this.cbPaletteColors_Leave);
            this.cbPaletteColors.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbPaletteColors_KeyPress);
            this.cbPaletteColors.SelectedValueChanged += new System.EventHandler(this.cbPaletteColors_SelectedValueChanged);
            // 
            // btnAddColor
            // 
            this.btnAddColor.Location = new System.Drawing.Point(250, 119);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(75, 23);
            this.btnAddColor.TabIndex = 9;
            this.btnAddColor.Text = "+";
            this.btnAddColor.UseVisualStyleBackColor = true;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // CloneBitmapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 439);
            this.Controls.Add(this.btnAddColor);
            this.Controls.Add(this.cbPaletteColors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewPalette);
            this.Controls.Add(this.lblSymbolDescription);
            this.Controls.Add(this.tbSymbolDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSymbolName);
            this.Name = "CloneBitmapForm";
            this.Text = "Clone Bitmap";
            this.Load += new System.EventHandler(this.CloneBitmapForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloneBitmapForm_FormClosing);
            this.Controls.SetChildIndex(this.tbSymbolName, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbSymbolDescription, 0);
            this.Controls.SetChildIndex(this.lblSymbolDescription, 0);
            this.Controls.SetChildIndex(this.listViewPalette, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cbPaletteColors, 0);
            this.Controls.SetChildIndex(this.btnAddColor, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSymbolName;
        private System.Windows.Forms.Label lblSymbolDescription;
        private System.Windows.Forms.TextBox tbSymbolDescription;
        private PaletteListView listViewPalette;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPaletteColors;
        private System.Windows.Forms.Button btnAddColor;
    }
}