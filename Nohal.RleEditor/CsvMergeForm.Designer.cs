namespace Nohal.RleEditor
{
    partial class CsvMergeForm
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
            this.gbMaster = new System.Windows.Forms.GroupBox();
            this.btnOpenMasterExpectedInput = new System.Windows.Forms.Button();
            this.tbMasterExpectedInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOpenMasterDecoding = new System.Windows.Forms.Button();
            this.tbMasterDecoding = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenMasterAttributes = new System.Windows.Forms.Button();
            this.tbMasterAttributes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenMasterClasses = new System.Windows.Forms.Button();
            this.tbMasterClasses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenMergeExpectedInput = new System.Windows.Forms.Button();
            this.tbMergeExpectedInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOpenMergeDecoding = new System.Windows.Forms.Button();
            this.tbMergeDecoding = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOpenMergeAttributes = new System.Windows.Forms.Button();
            this.tbMergeAttributes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOpenMergeClasses = new System.Windows.Forms.Button();
            this.tbMergeClasses = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnOutputPath = new System.Windows.Forms.Button();
            this.tbOutputPath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbMaster.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMaster
            // 
            this.gbMaster.Controls.Add(this.btnOpenMasterExpectedInput);
            this.gbMaster.Controls.Add(this.tbMasterExpectedInput);
            this.gbMaster.Controls.Add(this.label4);
            this.gbMaster.Controls.Add(this.btnOpenMasterDecoding);
            this.gbMaster.Controls.Add(this.tbMasterDecoding);
            this.gbMaster.Controls.Add(this.label3);
            this.gbMaster.Controls.Add(this.btnOpenMasterAttributes);
            this.gbMaster.Controls.Add(this.tbMasterAttributes);
            this.gbMaster.Controls.Add(this.label2);
            this.gbMaster.Controls.Add(this.btnOpenMasterClasses);
            this.gbMaster.Controls.Add(this.tbMasterClasses);
            this.gbMaster.Controls.Add(this.label1);
            this.gbMaster.Location = new System.Drawing.Point(12, 12);
            this.gbMaster.Name = "gbMaster";
            this.gbMaster.Size = new System.Drawing.Size(367, 248);
            this.gbMaster.TabIndex = 2;
            this.gbMaster.TabStop = false;
            this.gbMaster.Text = "Master Data";
            // 
            // btnOpenMasterExpectedInput
            // 
            this.btnOpenMasterExpectedInput.Location = new System.Drawing.Point(286, 173);
            this.btnOpenMasterExpectedInput.Name = "btnOpenMasterExpectedInput";
            this.btnOpenMasterExpectedInput.Size = new System.Drawing.Size(75, 23);
            this.btnOpenMasterExpectedInput.TabIndex = 11;
            this.btnOpenMasterExpectedInput.Text = "...";
            this.btnOpenMasterExpectedInput.UseVisualStyleBackColor = true;
            this.btnOpenMasterExpectedInput.Click += new System.EventHandler(this.btnOpenMasterExpectedInput_Click);
            // 
            // tbMasterExpectedInput
            // 
            this.tbMasterExpectedInput.Location = new System.Drawing.Point(9, 173);
            this.tbMasterExpectedInput.Name = "tbMasterExpectedInput";
            this.tbMasterExpectedInput.ReadOnly = true;
            this.tbMasterExpectedInput.Size = new System.Drawing.Size(271, 22);
            this.tbMasterExpectedInput.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Expected Input";
            // 
            // btnOpenMasterDecoding
            // 
            this.btnOpenMasterDecoding.Location = new System.Drawing.Point(286, 128);
            this.btnOpenMasterDecoding.Name = "btnOpenMasterDecoding";
            this.btnOpenMasterDecoding.Size = new System.Drawing.Size(75, 23);
            this.btnOpenMasterDecoding.TabIndex = 8;
            this.btnOpenMasterDecoding.Text = "...";
            this.btnOpenMasterDecoding.UseVisualStyleBackColor = true;
            this.btnOpenMasterDecoding.Click += new System.EventHandler(this.btnOpenMasterDecoding_Click);
            // 
            // tbMasterDecoding
            // 
            this.tbMasterDecoding.Location = new System.Drawing.Point(9, 128);
            this.tbMasterDecoding.Name = "tbMasterDecoding";
            this.tbMasterDecoding.ReadOnly = true;
            this.tbMasterDecoding.Size = new System.Drawing.Size(271, 22);
            this.tbMasterDecoding.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Attribute Decoding";
            // 
            // btnOpenMasterAttributes
            // 
            this.btnOpenMasterAttributes.Location = new System.Drawing.Point(286, 83);
            this.btnOpenMasterAttributes.Name = "btnOpenMasterAttributes";
            this.btnOpenMasterAttributes.Size = new System.Drawing.Size(75, 23);
            this.btnOpenMasterAttributes.TabIndex = 5;
            this.btnOpenMasterAttributes.Text = "...";
            this.btnOpenMasterAttributes.UseVisualStyleBackColor = true;
            this.btnOpenMasterAttributes.Click += new System.EventHandler(this.btnOpenMasterAttributes_Click);
            // 
            // tbMasterAttributes
            // 
            this.tbMasterAttributes.Location = new System.Drawing.Point(9, 83);
            this.tbMasterAttributes.Name = "tbMasterAttributes";
            this.tbMasterAttributes.ReadOnly = true;
            this.tbMasterAttributes.Size = new System.Drawing.Size(271, 22);
            this.tbMasterAttributes.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Attributes";
            // 
            // btnOpenMasterClasses
            // 
            this.btnOpenMasterClasses.Location = new System.Drawing.Point(286, 38);
            this.btnOpenMasterClasses.Name = "btnOpenMasterClasses";
            this.btnOpenMasterClasses.Size = new System.Drawing.Size(75, 23);
            this.btnOpenMasterClasses.TabIndex = 2;
            this.btnOpenMasterClasses.Text = "...";
            this.btnOpenMasterClasses.UseVisualStyleBackColor = true;
            this.btnOpenMasterClasses.Click += new System.EventHandler(this.btnOpenMasterClasses_Click);
            // 
            // tbMasterClasses
            // 
            this.tbMasterClasses.Location = new System.Drawing.Point(9, 38);
            this.tbMasterClasses.Name = "tbMasterClasses";
            this.tbMasterClasses.ReadOnly = true;
            this.tbMasterClasses.Size = new System.Drawing.Size(271, 22);
            this.tbMasterClasses.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Object Classes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenMergeExpectedInput);
            this.groupBox1.Controls.Add(this.tbMergeExpectedInput);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnOpenMergeDecoding);
            this.groupBox1.Controls.Add(this.tbMergeDecoding);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnOpenMergeAttributes);
            this.groupBox1.Controls.Add(this.tbMergeAttributes);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnOpenMergeClasses);
            this.groupBox1.Controls.Add(this.tbMergeClasses);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(445, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 248);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data to Merge";
            // 
            // btnOpenMergeExpectedInput
            // 
            this.btnOpenMergeExpectedInput.Location = new System.Drawing.Point(286, 173);
            this.btnOpenMergeExpectedInput.Name = "btnOpenMergeExpectedInput";
            this.btnOpenMergeExpectedInput.Size = new System.Drawing.Size(75, 23);
            this.btnOpenMergeExpectedInput.TabIndex = 11;
            this.btnOpenMergeExpectedInput.Text = "...";
            this.btnOpenMergeExpectedInput.UseVisualStyleBackColor = true;
            this.btnOpenMergeExpectedInput.Click += new System.EventHandler(this.btnOpenMergeExpectedInput_Click);
            // 
            // tbMergeExpectedInput
            // 
            this.tbMergeExpectedInput.Location = new System.Drawing.Point(9, 173);
            this.tbMergeExpectedInput.Name = "tbMergeExpectedInput";
            this.tbMergeExpectedInput.ReadOnly = true;
            this.tbMergeExpectedInput.Size = new System.Drawing.Size(271, 22);
            this.tbMergeExpectedInput.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Expected Input";
            // 
            // btnOpenMergeDecoding
            // 
            this.btnOpenMergeDecoding.Location = new System.Drawing.Point(286, 128);
            this.btnOpenMergeDecoding.Name = "btnOpenMergeDecoding";
            this.btnOpenMergeDecoding.Size = new System.Drawing.Size(75, 23);
            this.btnOpenMergeDecoding.TabIndex = 8;
            this.btnOpenMergeDecoding.Text = "...";
            this.btnOpenMergeDecoding.UseVisualStyleBackColor = true;
            this.btnOpenMergeDecoding.Click += new System.EventHandler(this.btnOpenMergeDecoding_Click);
            // 
            // tbMergeDecoding
            // 
            this.tbMergeDecoding.Location = new System.Drawing.Point(9, 128);
            this.tbMergeDecoding.Name = "tbMergeDecoding";
            this.tbMergeDecoding.ReadOnly = true;
            this.tbMergeDecoding.Size = new System.Drawing.Size(271, 22);
            this.tbMergeDecoding.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Attribute Decoding";
            // 
            // btnOpenMergeAttributes
            // 
            this.btnOpenMergeAttributes.Location = new System.Drawing.Point(286, 83);
            this.btnOpenMergeAttributes.Name = "btnOpenMergeAttributes";
            this.btnOpenMergeAttributes.Size = new System.Drawing.Size(75, 23);
            this.btnOpenMergeAttributes.TabIndex = 5;
            this.btnOpenMergeAttributes.Text = "...";
            this.btnOpenMergeAttributes.UseVisualStyleBackColor = true;
            this.btnOpenMergeAttributes.Click += new System.EventHandler(this.btnOpenMergeAttributes_Click);
            // 
            // tbMergeAttributes
            // 
            this.tbMergeAttributes.Location = new System.Drawing.Point(9, 83);
            this.tbMergeAttributes.Name = "tbMergeAttributes";
            this.tbMergeAttributes.ReadOnly = true;
            this.tbMergeAttributes.Size = new System.Drawing.Size(271, 22);
            this.tbMergeAttributes.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Attributes";
            // 
            // btnOpenMergeClasses
            // 
            this.btnOpenMergeClasses.Location = new System.Drawing.Point(286, 38);
            this.btnOpenMergeClasses.Name = "btnOpenMergeClasses";
            this.btnOpenMergeClasses.Size = new System.Drawing.Size(75, 23);
            this.btnOpenMergeClasses.TabIndex = 2;
            this.btnOpenMergeClasses.Text = "...";
            this.btnOpenMergeClasses.UseVisualStyleBackColor = true;
            this.btnOpenMergeClasses.Click += new System.EventHandler(this.btnOpenMergeClasses_Click);
            // 
            // tbMergeClasses
            // 
            this.tbMergeClasses.Location = new System.Drawing.Point(9, 38);
            this.tbMergeClasses.Name = "tbMergeClasses";
            this.tbMergeClasses.ReadOnly = true;
            this.tbMergeClasses.Size = new System.Drawing.Size(271, 22);
            this.tbMergeClasses.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Object Classes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(394, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "<=";
            // 
            // btnOutputPath
            // 
            this.btnOutputPath.Location = new System.Drawing.Point(731, 280);
            this.btnOutputPath.Name = "btnOutputPath";
            this.btnOutputPath.Size = new System.Drawing.Size(75, 23);
            this.btnOutputPath.TabIndex = 16;
            this.btnOutputPath.Text = "...";
            this.btnOutputPath.UseVisualStyleBackColor = true;
            this.btnOutputPath.Click += new System.EventHandler(this.btnOutputPath_Click);
            // 
            // tbOutputPath
            // 
            this.tbOutputPath.Location = new System.Drawing.Point(21, 280);
            this.tbOutputPath.Name = "tbOutputPath";
            this.tbOutputPath.ReadOnly = true;
            this.tbOutputPath.Size = new System.Drawing.Size(704, 22);
            this.tbOutputPath.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Save merged to";
            // 
            // CsvMergeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 439);
            this.Controls.Add(this.btnOutputPath);
            this.Controls.Add(this.tbOutputPath);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbMaster);
            this.Controls.Add(this.label9);
            this.Name = "CsvMergeForm";
            this.Text = "Csv Merge";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CsvMergeForm_FormClosing);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.gbMaster, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.tbOutputPath, 0);
            this.Controls.SetChildIndex(this.btnOutputPath, 0);
            this.gbMaster.ResumeLayout(false);
            this.gbMaster.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMaster;
        private System.Windows.Forms.Button btnOpenMasterExpectedInput;
        private System.Windows.Forms.TextBox tbMasterExpectedInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOpenMasterDecoding;
        private System.Windows.Forms.TextBox tbMasterDecoding;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenMasterAttributes;
        private System.Windows.Forms.TextBox tbMasterAttributes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenMasterClasses;
        private System.Windows.Forms.TextBox tbMasterClasses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenMergeExpectedInput;
        private System.Windows.Forms.TextBox tbMergeExpectedInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOpenMergeDecoding;
        private System.Windows.Forms.TextBox tbMergeDecoding;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOpenMergeAttributes;
        private System.Windows.Forms.TextBox tbMergeAttributes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOpenMergeClasses;
        private System.Windows.Forms.TextBox tbMergeClasses;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOutputPath;
        private System.Windows.Forms.TextBox tbOutputPath;
        private System.Windows.Forms.Label label10;
    }
}