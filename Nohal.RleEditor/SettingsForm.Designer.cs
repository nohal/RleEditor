namespace Nohal.RleEditor
{
    partial class SettingsForm
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
            this.tbS57Folder = new System.Windows.Forms.TextBox();
            this.btnBrowseS57Folder = new System.Windows.Forms.Button();
            this.cbOpenLastUsed = new System.Windows.Forms.CheckBox();
            this.cbAutoSortLupts = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "OpenCPN S57 data path";
            // 
            // tbS57Folder
            // 
            this.tbS57Folder.Location = new System.Drawing.Point(15, 25);
            this.tbS57Folder.Name = "tbS57Folder";
            this.tbS57Folder.ReadOnly = true;
            this.tbS57Folder.Size = new System.Drawing.Size(513, 20);
            this.tbS57Folder.TabIndex = 3;
            // 
            // btnBrowseS57Folder
            // 
            this.btnBrowseS57Folder.Location = new System.Drawing.Point(534, 23);
            this.btnBrowseS57Folder.Name = "btnBrowseS57Folder";
            this.btnBrowseS57Folder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseS57Folder.TabIndex = 4;
            this.btnBrowseS57Folder.Text = "...";
            this.btnBrowseS57Folder.UseVisualStyleBackColor = true;
            this.btnBrowseS57Folder.Click += new System.EventHandler(this.btnBrowseS57Folder_Click);
            // 
            // cbOpenLastUsed
            // 
            this.cbOpenLastUsed.AutoSize = true;
            this.cbOpenLastUsed.Location = new System.Drawing.Point(15, 51);
            this.cbOpenLastUsed.Name = "cbOpenLastUsed";
            this.cbOpenLastUsed.Size = new System.Drawing.Size(163, 17);
            this.cbOpenLastUsed.TabIndex = 5;
            this.cbOpenLastUsed.Text = "Open last used file on startup";
            this.cbOpenLastUsed.UseVisualStyleBackColor = true;
            // 
            // cbAutoSortLupts
            // 
            this.cbAutoSortLupts.AutoSize = true;
            this.cbAutoSortLupts.Location = new System.Drawing.Point(15, 74);
            this.cbAutoSortLupts.Name = "cbAutoSortLupts";
            this.cbAutoSortLupts.Size = new System.Drawing.Size(175, 17);
            this.cbAutoSortLupts.TabIndex = 6;
            this.cbAutoSortLupts.Text = "Auto sort lookup tables on save";
            this.cbAutoSortLupts.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 359);
            this.ControlBox = false;
            this.Controls.Add(this.cbAutoSortLupts);
            this.Controls.Add(this.cbOpenLastUsed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbS57Folder);
            this.Controls.Add(this.btnBrowseS57Folder);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(629, 385);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(629, 385);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Controls.SetChildIndex(this.btnBrowseS57Folder, 0);
            this.Controls.SetChildIndex(this.tbS57Folder, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cbOpenLastUsed, 0);
            this.Controls.SetChildIndex(this.cbAutoSortLupts, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbS57Folder;
        private System.Windows.Forms.Button btnBrowseS57Folder;
        private System.Windows.Forms.CheckBox cbOpenLastUsed;
        private System.Windows.Forms.CheckBox cbAutoSortLupts;


    }
}