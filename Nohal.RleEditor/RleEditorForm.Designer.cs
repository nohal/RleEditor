using Nohal.RleEditor.RleParser;

namespace Nohal.RleEditor
{
    partial class RleEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RleEditorForm));
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.textBoxFilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxBitmaps = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBitmapColorTables = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxBitmapView = new System.Windows.Forms.PictureBox();
            this.numericUpDownBitmapOffsetX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownBitmapOffsetY = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownBitmapWidth = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownBitmapHeight = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownBitmapHotspotX = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownBitmapHotspotY = new System.Windows.Forms.NumericUpDown();
            this.textBoxBitmapVal1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxBitmapDescription = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxBitmapVal2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDownBitmapValue3 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDownBitmapValue4 = new System.Windows.Forms.NumericUpDown();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageColorTables = new System.Windows.Forms.TabPage();
            this.btnDeleteColorTable = new System.Windows.Forms.Button();
            this.btnReplaceColorTables = new System.Windows.Forms.Button();
            this.btnMergeColorTables = new System.Windows.Forms.Button();
            this.btnExportColorTables = new System.Windows.Forms.Button();
            this.btnExportColorTable = new System.Windows.Forms.Button();
            this.pictureBoxColorSample = new System.Windows.Forms.PictureBox();
            this.buttonCommitColorChange = new System.Windows.Forms.Button();
            this.buttonShowColorDialog = new System.Windows.Forms.Button();
            this.numericUpDownEditColory1 = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.numericUpDownEditColorx = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.numericUpDownEditColorY = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxColorName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxColorCode = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxColorTablesList = new System.Windows.Forms.ComboBox();
            this.listViewColorTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.tabPageBitmaps = new System.Windows.Forms.TabPage();
            this.tbSymbolCode = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.colorComboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCloneBitmap = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.numericUpDownBitmapSymbolId = new System.Windows.Forms.NumericUpDown();
            this.btnExportBitmap = new System.Windows.Forms.Button();
            this.btnMergeBitmaps = new System.Windows.Forms.Button();
            this.btnExportBitmaps = new System.Windows.Forms.Button();
            this.btnDeleteBitmap = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pictureBoxBitmapEditor = new System.Windows.Forms.PictureBox();
            this.textBoxBitmapText = new System.Windows.Forms.TextBox();
            this.comboBoxZoom = new System.Windows.Forms.ComboBox();
            this.tabPageVectors = new System.Windows.Forms.TabPage();
            this.tbVectorCode = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.btnCloneVector = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.numericUpDownVectorSymbolId = new System.Windows.Forms.NumericUpDown();
            this.btnExportVector = new System.Windows.Forms.Button();
            this.btnMergeVectors = new System.Windows.Forms.Button();
            this.btnExportVectors = new System.Windows.Forms.Button();
            this.btnDelVector = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBoxVectorRendering = new System.Windows.Forms.PictureBox();
            this.textBoxVectors = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.listBoxVectors = new System.Windows.Forms.ListBox();
            this.numericUpDownVectorVal4 = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBoxVectorColorTables = new System.Windows.Forms.ComboBox();
            this.numericUpDownVectorVal3 = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxVectorVal2 = new System.Windows.Forms.TextBox();
            this.numericUpDownVectorOffsetX = new System.Windows.Forms.NumericUpDown();
            this.textBoxVectorDescription = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.numericUpDownVectorOffsetY = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textBoxVectorVal1 = new System.Windows.Forms.TextBox();
            this.numericUpDownVectorWidth = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.numericUpDownVectorHotspotY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVectorHeight = new System.Windows.Forms.NumericUpDown();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.numericUpDownVectorHotspotX = new System.Windows.Forms.NumericUpDown();
            this.tabPageLUPTs = new System.Windows.Forms.TabPage();
            this.btnEditLupt = new System.Windows.Forms.Button();
            this.btnDeleteLupt = new System.Windows.Forms.Button();
            this.btnCloneRule = new System.Windows.Forms.Button();
            this.btnNewRule = new System.Windows.Forms.Button();
            this.listViewLookupTable = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.btnSortLupt = new System.Windows.Forms.Button();
            this.btnMergeLookupTable = new System.Windows.Forms.Button();
            this.btnReplaceTableFromFile = new System.Windows.Forms.Button();
            this.btnExportLookupTable = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxLookupTables = new System.Windows.Forms.ComboBox();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitmapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vectorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookupTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsPAPERCHARTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsSIMPLIFIEDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaPLAINBORDERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaSYMBOLIZEDBORDERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookupTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsPAPERCHARTToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsSIMPLIFIEDToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.linesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.areaPLAINBORDERSToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.areaSYMBOLIZEDBORDERSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookupTableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsPAPERCHARTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsSIMPLIFIEDToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.linesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.areaPLAINBORDERSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.areaSYMBOLIZEDBORDERSToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortAllLookupTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetNumberingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllLookupTaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.symbolsToPNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBitmapView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBitmapOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBitmapOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBitmapWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBitmapHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBitmapHotspotX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBitmapHotspotY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBitmapValue3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBitmapValue4)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageColorTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditColory1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditColorx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditColorY)).BeginInit();
            this.tabPageBitmaps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBitmapSymbolId)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBitmapEditor)).BeginInit();
            this.tabPageVectors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVectorSymbolId)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVectorRendering)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVectorVal4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVectorVal3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVectorOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVectorOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVectorWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVectorHotspotY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVectorHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVectorHotspotX)).BeginInit();
            this.tabPageLUPTs.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFile.Location = new System.Drawing.Point(602, 41);
            this.buttonOpenFile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(56, 19);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "...";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // textBoxFilename
            // 
            this.textBoxFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilename.Location = new System.Drawing.Point(9, 41);
            this.textBoxFilename.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFilename.Name = "textBoxFilename";
            this.textBoxFilename.ReadOnly = true;
            this.textBoxFilename.Size = new System.Drawing.Size(587, 20);
            this.textBoxFilename.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rasterization rules file";
            // 
            // listBoxBitmaps
            // 
            this.listBoxBitmaps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxBitmaps.FormattingEnabled = true;
            this.listBoxBitmaps.Location = new System.Drawing.Point(3, 95);
            this.listBoxBitmaps.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxBitmaps.Name = "listBoxBitmaps";
            this.listBoxBitmaps.Size = new System.Drawing.Size(92, 303);
            this.listBoxBitmaps.Sorted = true;
            this.listBoxBitmaps.TabIndex = 3;
            this.listBoxBitmaps.SelectedIndexChanged += new System.EventHandler(this.listBoxBitmaps_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bitmaps";
            // 
            // comboBoxBitmapColorTables
            // 
            this.comboBoxBitmapColorTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBitmapColorTables.FormattingEnabled = true;
            this.comboBoxBitmapColorTables.Location = new System.Drawing.Point(4, 19);
            this.comboBoxBitmapColorTables.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBitmapColorTables.Name = "comboBoxBitmapColorTables";
            this.comboBoxBitmapColorTables.Size = new System.Drawing.Size(92, 21);
            this.comboBoxBitmapColorTables.TabIndex = 5;
            this.comboBoxBitmapColorTables.SelectedIndexChanged += new System.EventHandler(this.comboBoxBitmapColorTables_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ColorTable";
            // 
            // pictureBoxBitmapView
            // 
            this.pictureBoxBitmapView.Location = new System.Drawing.Point(99, 95);
            this.pictureBoxBitmapView.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBitmapView.Name = "pictureBoxBitmapView";
            this.pictureBoxBitmapView.Size = new System.Drawing.Size(106, 288);
            this.pictureBoxBitmapView.TabIndex = 9;
            this.pictureBoxBitmapView.TabStop = false;
            // 
            // numericUpDownBitmapOffsetX
            // 
            this.numericUpDownBitmapOffsetX.Enabled = false;
            this.numericUpDownBitmapOffsetX.Location = new System.Drawing.Point(313, 21);
            this.numericUpDownBitmapOffsetX.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownBitmapOffsetX.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownBitmapOffsetX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownBitmapOffsetX.Name = "numericUpDownBitmapOffsetX";
            this.numericUpDownBitmapOffsetX.ReadOnly = true;
            this.numericUpDownBitmapOffsetX.Size = new System.Drawing.Size(36, 20);
            this.numericUpDownBitmapOffsetX.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "XOff";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "YOff";
            // 
            // numericUpDownBitmapOffsetY
            // 
            this.numericUpDownBitmapOffsetY.Enabled = false;
            this.numericUpDownBitmapOffsetY.Location = new System.Drawing.Point(353, 20);
            this.numericUpDownBitmapOffsetY.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownBitmapOffsetY.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownBitmapOffsetY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownBitmapOffsetY.Name = "numericUpDownBitmapOffsetY";
            this.numericUpDownBitmapOffsetY.ReadOnly = true;
            this.numericUpDownBitmapOffsetY.Size = new System.Drawing.Size(36, 20);
            this.numericUpDownBitmapOffsetY.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Width";
            // 
            // numericUpDownBitmapWidth
            // 
            this.numericUpDownBitmapWidth.Enabled = false;
            this.numericUpDownBitmapWidth.Location = new System.Drawing.Point(391, 20);
            this.numericUpDownBitmapWidth.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownBitmapWidth.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownBitmapWidth.Name = "numericUpDownBitmapWidth";
            this.numericUpDownBitmapWidth.ReadOnly = true;
            this.numericUpDownBitmapWidth.Size = new System.Drawing.Size(36, 20);
            this.numericUpDownBitmapWidth.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 2);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Height";
            // 
            // numericUpDownBitmapHeight
            // 
            this.numericUpDownBitmapHeight.Enabled = false;
            this.numericUpDownBitmapHeight.Location = new System.Drawing.Point(431, 21);
            this.numericUpDownBitmapHeight.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownBitmapHeight.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownBitmapHeight.Name = "numericUpDownBitmapHeight";
            this.numericUpDownBitmapHeight.ReadOnly = true;
            this.numericUpDownBitmapHeight.Size = new System.Drawing.Size(36, 20);
            this.numericUpDownBitmapHeight.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(468, 2);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "HotX";
            // 
            // numericUpDownBitmapHotspotX
            // 
            this.numericUpDownBitmapHotspotX.Enabled = false;
            this.numericUpDownBitmapHotspotX.Location = new System.Drawing.Point(470, 21);
            this.numericUpDownBitmapHotspotX.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownBitmapHotspotX.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownBitmapHotspotX.Name = "numericUpDownBitmapHotspotX";
            this.numericUpDownBitmapHotspotX.ReadOnly = true;
            this.numericUpDownBitmapHotspotX.Size = new System.Drawing.Size(36, 20);
            this.numericUpDownBitmapHotspotX.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(508, 2);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "HotY";
            // 
            // numericUpDownBitmapHotspotY
            // 
            this.numericUpDownBitmapHotspotY.Enabled = false;
            this.numericUpDownBitmapHotspotY.Location = new System.Drawing.Point(510, 20);
            this.numericUpDownBitmapHotspotY.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownBitmapHotspotY.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownBitmapHotspotY.Name = "numericUpDownBitmapHotspotY";
            this.numericUpDownBitmapHotspotY.ReadOnly = true;
            this.numericUpDownBitmapHotspotY.Size = new System.Drawing.Size(36, 20);
            this.numericUpDownBitmapHotspotY.TabIndex = 21;
            // 
            // textBoxBitmapVal1
            // 
            this.textBoxBitmapVal1.Location = new System.Drawing.Point(164, 20);
            this.textBoxBitmapVal1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBitmapVal1.Name = "textBoxBitmapVal1";
            this.textBoxBitmapVal1.ReadOnly = true;
            this.textBoxBitmapVal1.Size = new System.Drawing.Size(22, 20);
            this.textBoxBitmapVal1.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(162, 2);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "SY";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 41);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Description";
            // 
            // textBoxBitmapDescription
            // 
            this.textBoxBitmapDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBitmapDescription.Location = new System.Drawing.Point(74, 56);
            this.textBoxBitmapDescription.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBitmapDescription.Name = "textBoxBitmapDescription";
            this.textBoxBitmapDescription.ReadOnly = true;
            this.textBoxBitmapDescription.Size = new System.Drawing.Size(562, 20);
            this.textBoxBitmapDescription.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(187, 2);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Val2";
            // 
            // textBoxBitmapVal2
            // 
            this.textBoxBitmapVal2.Location = new System.Drawing.Point(189, 20);
            this.textBoxBitmapVal2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBitmapVal2.Name = "textBoxBitmapVal2";
            this.textBoxBitmapVal2.ReadOnly = true;
            this.textBoxBitmapVal2.Size = new System.Drawing.Size(41, 20);
            this.textBoxBitmapVal2.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(231, 2);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Val3";
            // 
            // numericUpDownBitmapValue3
            // 
            this.numericUpDownBitmapValue3.Enabled = false;
            this.numericUpDownBitmapValue3.Location = new System.Drawing.Point(234, 21);
            this.numericUpDownBitmapValue3.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownBitmapValue3.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownBitmapValue3.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownBitmapValue3.Name = "numericUpDownBitmapValue3";
            this.numericUpDownBitmapValue3.ReadOnly = true;
            this.numericUpDownBitmapValue3.Size = new System.Drawing.Size(36, 20);
            this.numericUpDownBitmapValue3.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(271, 2);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Val4";
            // 
            // numericUpDownBitmapValue4
            // 
            this.numericUpDownBitmapValue4.Enabled = false;
            this.numericUpDownBitmapValue4.Location = new System.Drawing.Point(273, 20);
            this.numericUpDownBitmapValue4.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownBitmapValue4.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownBitmapValue4.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownBitmapValue4.Name = "numericUpDownBitmapValue4";
            this.numericUpDownBitmapValue4.ReadOnly = true;
            this.numericUpDownBitmapValue4.Size = new System.Drawing.Size(36, 20);
            this.numericUpDownBitmapValue4.TabIndex = 31;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageColorTables);
            this.tabControl.Controls.Add(this.tabPageBitmaps);
            this.tabControl.Controls.Add(this.tabPageVectors);
            this.tabControl.Controls.Add(this.tabPageLUPTs);
            this.tabControl.Enabled = false;
            this.tabControl.Location = new System.Drawing.Point(9, 64);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(650, 440);
            this.tabControl.TabIndex = 33;
            // 
            // tabPageColorTables
            // 
            this.tabPageColorTables.Controls.Add(this.btnDeleteColorTable);
            this.tabPageColorTables.Controls.Add(this.btnReplaceColorTables);
            this.tabPageColorTables.Controls.Add(this.btnMergeColorTables);
            this.tabPageColorTables.Controls.Add(this.btnExportColorTables);
            this.tabPageColorTables.Controls.Add(this.btnExportColorTable);
            this.tabPageColorTables.Controls.Add(this.pictureBoxColorSample);
            this.tabPageColorTables.Controls.Add(this.buttonCommitColorChange);
            this.tabPageColorTables.Controls.Add(this.buttonShowColorDialog);
            this.tabPageColorTables.Controls.Add(this.numericUpDownEditColory1);
            this.tabPageColorTables.Controls.Add(this.label21);
            this.tabPageColorTables.Controls.Add(this.numericUpDownEditColorx);
            this.tabPageColorTables.Controls.Add(this.label20);
            this.tabPageColorTables.Controls.Add(this.numericUpDownEditColorY);
            this.tabPageColorTables.Controls.Add(this.label19);
            this.tabPageColorTables.Controls.Add(this.label18);
            this.tabPageColorTables.Controls.Add(this.textBoxColorName);
            this.tabPageColorTables.Controls.Add(this.label17);
            this.tabPageColorTables.Controls.Add(this.textBoxColorCode);
            this.tabPageColorTables.Controls.Add(this.label15);
            this.tabPageColorTables.Controls.Add(this.comboBoxColorTablesList);
            this.tabPageColorTables.Controls.Add(this.listViewColorTable);
            this.tabPageColorTables.Location = new System.Drawing.Point(4, 22);
            this.tabPageColorTables.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageColorTables.Name = "tabPageColorTables";
            this.tabPageColorTables.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageColorTables.Size = new System.Drawing.Size(642, 414);
            this.tabPageColorTables.TabIndex = 0;
            this.tabPageColorTables.Text = "Color Tables";
            this.tabPageColorTables.UseVisualStyleBackColor = true;
            // 
            // btnDeleteColorTable
            // 
            this.btnDeleteColorTable.Location = new System.Drawing.Point(584, 265);
            this.btnDeleteColorTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteColorTable.Name = "btnDeleteColorTable";
            this.btnDeleteColorTable.Size = new System.Drawing.Size(56, 19);
            this.btnDeleteColorTable.TabIndex = 43;
            this.btnDeleteColorTable.Text = "Delete";
            this.btnDeleteColorTable.UseVisualStyleBackColor = true;
            this.btnDeleteColorTable.Click += new System.EventHandler(this.btnDeleteColorTable_Click);
            // 
            // btnReplaceColorTables
            // 
            this.btnReplaceColorTables.Location = new System.Drawing.Point(584, 243);
            this.btnReplaceColorTables.Margin = new System.Windows.Forms.Padding(2);
            this.btnReplaceColorTables.Name = "btnReplaceColorTables";
            this.btnReplaceColorTables.Size = new System.Drawing.Size(56, 19);
            this.btnReplaceColorTables.TabIndex = 42;
            this.btnReplaceColorTables.Text = "Replace";
            this.btnReplaceColorTables.UseVisualStyleBackColor = true;
            this.btnReplaceColorTables.Click += new System.EventHandler(this.btnReplaceColorTables_Click);
            // 
            // btnMergeColorTables
            // 
            this.btnMergeColorTables.Location = new System.Drawing.Point(522, 243);
            this.btnMergeColorTables.Margin = new System.Windows.Forms.Padding(2);
            this.btnMergeColorTables.Name = "btnMergeColorTables";
            this.btnMergeColorTables.Size = new System.Drawing.Size(56, 19);
            this.btnMergeColorTables.TabIndex = 41;
            this.btnMergeColorTables.Text = "Merge";
            this.btnMergeColorTables.UseVisualStyleBackColor = true;
            this.btnMergeColorTables.Click += new System.EventHandler(this.btnMergeColorTables_Click);
            // 
            // btnExportColorTables
            // 
            this.btnExportColorTables.Location = new System.Drawing.Point(584, 221);
            this.btnExportColorTables.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportColorTables.Name = "btnExportColorTables";
            this.btnExportColorTables.Size = new System.Drawing.Size(56, 19);
            this.btnExportColorTables.TabIndex = 40;
            this.btnExportColorTables.Text = "Export All";
            this.btnExportColorTables.UseVisualStyleBackColor = true;
            this.btnExportColorTables.Click += new System.EventHandler(this.btnExportColorTables_Click);
            // 
            // btnExportColorTable
            // 
            this.btnExportColorTable.Location = new System.Drawing.Point(522, 221);
            this.btnExportColorTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportColorTable.Name = "btnExportColorTable";
            this.btnExportColorTable.Size = new System.Drawing.Size(56, 19);
            this.btnExportColorTable.TabIndex = 39;
            this.btnExportColorTable.Text = "Export";
            this.btnExportColorTable.UseVisualStyleBackColor = true;
            this.btnExportColorTable.Click += new System.EventHandler(this.btnExportColorTable_Click);
            // 
            // pictureBoxColorSample
            // 
            this.pictureBoxColorSample.Location = new System.Drawing.Point(434, 125);
            this.pictureBoxColorSample.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxColorSample.Name = "pictureBoxColorSample";
            this.pictureBoxColorSample.Size = new System.Drawing.Size(206, 91);
            this.pictureBoxColorSample.TabIndex = 38;
            this.pictureBoxColorSample.TabStop = false;
            // 
            // buttonCommitColorChange
            // 
            this.buttonCommitColorChange.Location = new System.Drawing.Point(434, 221);
            this.buttonCommitColorChange.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCommitColorChange.Name = "buttonCommitColorChange";
            this.buttonCommitColorChange.Size = new System.Drawing.Size(56, 19);
            this.buttonCommitColorChange.TabIndex = 37;
            this.buttonCommitColorChange.Text = "Commit";
            this.buttonCommitColorChange.UseVisualStyleBackColor = true;
            this.buttonCommitColorChange.Click += new System.EventHandler(this.buttonCommitColorChange_Click);
            // 
            // buttonShowColorDialog
            // 
            this.buttonShowColorDialog.Location = new System.Drawing.Point(373, 221);
            this.buttonShowColorDialog.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShowColorDialog.Name = "buttonShowColorDialog";
            this.buttonShowColorDialog.Size = new System.Drawing.Size(56, 19);
            this.buttonShowColorDialog.TabIndex = 36;
            this.buttonShowColorDialog.Text = "...";
            this.buttonShowColorDialog.UseVisualStyleBackColor = true;
            this.buttonShowColorDialog.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDownEditColory1
            // 
            this.numericUpDownEditColory1.DecimalPlaces = 2;
            this.numericUpDownEditColory1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownEditColory1.Location = new System.Drawing.Point(373, 198);
            this.numericUpDownEditColory1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownEditColory1.Name = "numericUpDownEditColory1";
            this.numericUpDownEditColory1.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownEditColory1.TabIndex = 35;
            this.numericUpDownEditColory1.ValueChanged += new System.EventHandler(this.numericUpDownEditColory1_ValueChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(370, 182);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(12, 13);
            this.label21.TabIndex = 34;
            this.label21.Text = "y";
            // 
            // numericUpDownEditColorx
            // 
            this.numericUpDownEditColorx.DecimalPlaces = 2;
            this.numericUpDownEditColorx.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownEditColorx.Location = new System.Drawing.Point(373, 162);
            this.numericUpDownEditColorx.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownEditColorx.Name = "numericUpDownEditColorx";
            this.numericUpDownEditColorx.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownEditColorx.TabIndex = 33;
            this.numericUpDownEditColorx.ValueChanged += new System.EventHandler(this.numericUpDownEditColorx_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(370, 145);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(12, 13);
            this.label20.TabIndex = 32;
            this.label20.Text = "x";
            // 
            // numericUpDownEditColorY
            // 
            this.numericUpDownEditColorY.DecimalPlaces = 2;
            this.numericUpDownEditColorY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownEditColorY.Location = new System.Drawing.Point(373, 125);
            this.numericUpDownEditColorY.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownEditColorY.Name = "numericUpDownEditColorY";
            this.numericUpDownEditColorY.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownEditColorY.TabIndex = 31;
            this.numericUpDownEditColorY.ValueChanged += new System.EventHandler(this.ColorY_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(370, 109);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "Y";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(370, 71);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Color";
            // 
            // textBoxColorName
            // 
            this.textBoxColorName.Location = new System.Drawing.Point(373, 89);
            this.textBoxColorName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxColorName.Name = "textBoxColorName";
            this.textBoxColorName.Size = new System.Drawing.Size(268, 20);
            this.textBoxColorName.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(370, 32);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Code";
            // 
            // textBoxColorCode
            // 
            this.textBoxColorCode.Location = new System.Drawing.Point(373, 50);
            this.textBoxColorCode.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxColorCode.Name = "textBoxColorCode";
            this.textBoxColorCode.ReadOnly = true;
            this.textBoxColorCode.Size = new System.Drawing.Size(268, 20);
            this.textBoxColorCode.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 10);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "ColorTable";
            // 
            // comboBoxColorTablesList
            // 
            this.comboBoxColorTablesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColorTablesList.FormattingEnabled = true;
            this.comboBoxColorTablesList.Location = new System.Drawing.Point(64, 7);
            this.comboBoxColorTablesList.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxColorTablesList.Name = "comboBoxColorTablesList";
            this.comboBoxColorTablesList.Size = new System.Drawing.Size(126, 21);
            this.comboBoxColorTablesList.TabIndex = 7;
            this.comboBoxColorTablesList.SelectedIndexChanged += new System.EventHandler(this.comboBoxColorTablesList_SelectedIndexChanged);
            // 
            // listViewColorTable
            // 
            this.listViewColorTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewColorTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewColorTable.FullRowSelect = true;
            this.listViewColorTable.GridLines = true;
            this.listViewColorTable.Location = new System.Drawing.Point(4, 33);
            this.listViewColorTable.Margin = new System.Windows.Forms.Padding(2);
            this.listViewColorTable.MultiSelect = false;
            this.listViewColorTable.Name = "listViewColorTable";
            this.listViewColorTable.Size = new System.Drawing.Size(362, 379);
            this.listViewColorTable.TabIndex = 0;
            this.listViewColorTable.UseCompatibleStateImageBehavior = false;
            this.listViewColorTable.View = System.Windows.Forms.View.Details;
            this.listViewColorTable.SelectedIndexChanged += new System.EventHandler(this.listViewColorTable_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Color";
            this.columnHeader2.Width = 77;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Y";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "x";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "y";
            // 
            // tabPageBitmaps
            // 
            this.tabPageBitmaps.Controls.Add(this.tbSymbolCode);
            this.tabPageBitmaps.Controls.Add(this.label37);
            this.tabPageBitmaps.Controls.Add(this.colorComboBox1);
            this.tabPageBitmaps.Controls.Add(this.btnCloneBitmap);
            this.tabPageBitmaps.Controls.Add(this.label36);
            this.tabPageBitmaps.Controls.Add(this.numericUpDownBitmapSymbolId);
            this.tabPageBitmaps.Controls.Add(this.btnExportBitmap);
            this.tabPageBitmaps.Controls.Add(this.btnMergeBitmaps);
            this.tabPageBitmaps.Controls.Add(this.btnExportBitmaps);
            this.tabPageBitmaps.Controls.Add(this.btnDeleteBitmap);
            this.tabPageBitmaps.Controls.Add(this.splitContainer2);
            this.tabPageBitmaps.Controls.Add(this.comboBoxZoom);
            this.tabPageBitmaps.Controls.Add(this.label3);
            this.tabPageBitmaps.Controls.Add(this.label14);
            this.tabPageBitmaps.Controls.Add(this.listBoxBitmaps);
            this.tabPageBitmaps.Controls.Add(this.numericUpDownBitmapValue4);
            this.tabPageBitmaps.Controls.Add(this.label2);
            this.tabPageBitmaps.Controls.Add(this.label13);
            this.tabPageBitmaps.Controls.Add(this.comboBoxBitmapColorTables);
            this.tabPageBitmaps.Controls.Add(this.numericUpDownBitmapValue3);
            this.tabPageBitmaps.Controls.Add(this.pictureBoxBitmapView);
            this.tabPageBitmaps.Controls.Add(this.label12);
            this.tabPageBitmaps.Controls.Add(this.textBoxBitmapVal2);
            this.tabPageBitmaps.Controls.Add(this.numericUpDownBitmapOffsetX);
            this.tabPageBitmaps.Controls.Add(this.textBoxBitmapDescription);
            this.tabPageBitmaps.Controls.Add(this.label4);
            this.tabPageBitmaps.Controls.Add(this.label11);
            this.tabPageBitmaps.Controls.Add(this.numericUpDownBitmapOffsetY);
            this.tabPageBitmaps.Controls.Add(this.label10);
            this.tabPageBitmaps.Controls.Add(this.label5);
            this.tabPageBitmaps.Controls.Add(this.textBoxBitmapVal1);
            this.tabPageBitmaps.Controls.Add(this.numericUpDownBitmapWidth);
            this.tabPageBitmaps.Controls.Add(this.label9);
            this.tabPageBitmaps.Controls.Add(this.label6);
            this.tabPageBitmaps.Controls.Add(this.numericUpDownBitmapHotspotY);
            this.tabPageBitmaps.Controls.Add(this.numericUpDownBitmapHeight);
            this.tabPageBitmaps.Controls.Add(this.label8);
            this.tabPageBitmaps.Controls.Add(this.label7);
            this.tabPageBitmaps.Controls.Add(this.numericUpDownBitmapHotspotX);
            this.tabPageBitmaps.Location = new System.Drawing.Point(4, 22);
            this.tabPageBitmaps.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageBitmaps.Name = "tabPageBitmaps";
            this.tabPageBitmaps.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageBitmaps.Size = new System.Drawing.Size(642, 414);
            this.tabPageBitmaps.TabIndex = 1;
            this.tabPageBitmaps.Text = "Bitmaps";
            this.tabPageBitmaps.UseVisualStyleBackColor = true;
            // 
            // tbSymbolCode
            // 
            this.tbSymbolCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSymbolCode.Location = new System.Drawing.Point(4, 56);
            this.tbSymbolCode.Margin = new System.Windows.Forms.Padding(2);
            this.tbSymbolCode.Name = "tbSymbolCode";
            this.tbSymbolCode.ReadOnly = true;
            this.tbSymbolCode.Size = new System.Drawing.Size(66, 20);
            this.tbSymbolCode.TabIndex = 75;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(1, 41);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(41, 13);
            this.label37.TabIndex = 74;
            this.label37.Text = "Symbol";
            // 
            // colorComboBox1
            // 
            this.colorComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.colorComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorComboBox1.FormattingEnabled = true;
            this.colorComboBox1.Location = new System.Drawing.Point(211, 94);
            this.colorComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.colorComboBox1.Name = "colorComboBox1";
            this.colorComboBox1.Size = new System.Drawing.Size(55, 21);
            this.colorComboBox1.TabIndex = 73;
            this.colorComboBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.colorComboBox1_DrawItem);
            // 
            // btnCloneBitmap
            // 
            this.btnCloneBitmap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloneBitmap.Location = new System.Drawing.Point(362, 94);
            this.btnCloneBitmap.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloneBitmap.Name = "btnCloneBitmap";
            this.btnCloneBitmap.Size = new System.Drawing.Size(52, 20);
            this.btnCloneBitmap.TabIndex = 72;
            this.btnCloneBitmap.Text = "Clone";
            this.btnCloneBitmap.UseVisualStyleBackColor = true;
            this.btnCloneBitmap.Click += new System.EventHandler(this.btnCloneBitmap_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(97, 5);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(50, 13);
            this.label36.TabIndex = 71;
            this.label36.Text = "SymbolId";
            // 
            // numericUpDownBitmapSymbolId
            // 
            this.numericUpDownBitmapSymbolId.Enabled = false;
            this.numericUpDownBitmapSymbolId.Location = new System.Drawing.Point(100, 20);
            this.numericUpDownBitmapSymbolId.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownBitmapSymbolId.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownBitmapSymbolId.Name = "numericUpDownBitmapSymbolId";
            this.numericUpDownBitmapSymbolId.ReadOnly = true;
            this.numericUpDownBitmapSymbolId.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownBitmapSymbolId.TabIndex = 70;
            // 
            // btnExportBitmap
            // 
            this.btnExportBitmap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportBitmap.Location = new System.Drawing.Point(474, 94);
            this.btnExportBitmap.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportBitmap.Name = "btnExportBitmap";
            this.btnExportBitmap.Size = new System.Drawing.Size(52, 20);
            this.btnExportBitmap.TabIndex = 67;
            this.btnExportBitmap.Text = "Export";
            this.btnExportBitmap.UseVisualStyleBackColor = true;
            this.btnExportBitmap.Click += new System.EventHandler(this.btnExportBitmap_Click);
            // 
            // btnMergeBitmaps
            // 
            this.btnMergeBitmaps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMergeBitmaps.Location = new System.Drawing.Point(418, 94);
            this.btnMergeBitmaps.Margin = new System.Windows.Forms.Padding(2);
            this.btnMergeBitmaps.Name = "btnMergeBitmaps";
            this.btnMergeBitmaps.Size = new System.Drawing.Size(52, 20);
            this.btnMergeBitmaps.TabIndex = 66;
            this.btnMergeBitmaps.Text = "Merge";
            this.btnMergeBitmaps.UseVisualStyleBackColor = true;
            this.btnMergeBitmaps.Click += new System.EventHandler(this.btnMergeBitmaps_Click);
            // 
            // btnExportBitmaps
            // 
            this.btnExportBitmaps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportBitmaps.Location = new System.Drawing.Point(530, 94);
            this.btnExportBitmaps.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportBitmaps.Name = "btnExportBitmaps";
            this.btnExportBitmaps.Size = new System.Drawing.Size(66, 20);
            this.btnExportBitmaps.TabIndex = 63;
            this.btnExportBitmaps.Text = "Export All";
            this.btnExportBitmaps.UseVisualStyleBackColor = true;
            this.btnExportBitmaps.Click += new System.EventHandler(this.btnExportBitmaps_Click);
            // 
            // btnDeleteBitmap
            // 
            this.btnDeleteBitmap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteBitmap.Location = new System.Drawing.Point(600, 94);
            this.btnDeleteBitmap.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteBitmap.Name = "btnDeleteBitmap";
            this.btnDeleteBitmap.Size = new System.Drawing.Size(34, 20);
            this.btnDeleteBitmap.TabIndex = 37;
            this.btnDeleteBitmap.Text = "Del";
            this.btnDeleteBitmap.UseVisualStyleBackColor = true;
            this.btnDeleteBitmap.Click += new System.EventHandler(this.btnDeleteBitmap_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Location = new System.Drawing.Point(210, 120);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.pictureBoxBitmapEditor);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.textBoxBitmapText);
            this.splitContainer2.Size = new System.Drawing.Size(426, 277);
            this.splitContainer2.SplitterDistance = 200;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 36;
            // 
            // pictureBoxBitmapEditor
            // 
            this.pictureBoxBitmapEditor.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBitmapEditor.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBitmapEditor.Name = "pictureBoxBitmapEditor";
            this.pictureBoxBitmapEditor.Size = new System.Drawing.Size(297, 155);
            this.pictureBoxBitmapEditor.TabIndex = 33;
            this.pictureBoxBitmapEditor.TabStop = false;
            this.pictureBoxBitmapEditor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            // 
            // textBoxBitmapText
            // 
            this.textBoxBitmapText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBitmapText.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBitmapText.Location = new System.Drawing.Point(0, 0);
            this.textBoxBitmapText.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBitmapText.Multiline = true;
            this.textBoxBitmapText.Name = "textBoxBitmapText";
            this.textBoxBitmapText.ReadOnly = true;
            this.textBoxBitmapText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxBitmapText.Size = new System.Drawing.Size(424, 72);
            this.textBoxBitmapText.TabIndex = 60;
            this.textBoxBitmapText.WordWrap = false;
            // 
            // comboBoxZoom
            // 
            this.comboBoxZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxZoom.FormattingEnabled = true;
            this.comboBoxZoom.Items.AddRange(new object[] {
            "100%",
            "200%",
            "300%",
            "500%",
            "1000%",
            "2000%"});
            this.comboBoxZoom.Location = new System.Drawing.Point(269, 95);
            this.comboBoxZoom.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxZoom.Name = "comboBoxZoom";
            this.comboBoxZoom.Size = new System.Drawing.Size(55, 21);
            this.comboBoxZoom.TabIndex = 35;
            this.comboBoxZoom.SelectedIndexChanged += new System.EventHandler(this.comboBoxZoom_SelectedIndexChanged);
            // 
            // tabPageVectors
            // 
            this.tabPageVectors.Controls.Add(this.tbVectorCode);
            this.tabPageVectors.Controls.Add(this.label38);
            this.tabPageVectors.Controls.Add(this.btnCloneVector);
            this.tabPageVectors.Controls.Add(this.label35);
            this.tabPageVectors.Controls.Add(this.numericUpDownVectorSymbolId);
            this.tabPageVectors.Controls.Add(this.btnExportVector);
            this.tabPageVectors.Controls.Add(this.btnMergeVectors);
            this.tabPageVectors.Controls.Add(this.btnExportVectors);
            this.tabPageVectors.Controls.Add(this.btnDelVector);
            this.tabPageVectors.Controls.Add(this.splitContainer1);
            this.tabPageVectors.Controls.Add(this.label22);
            this.tabPageVectors.Controls.Add(this.label23);
            this.tabPageVectors.Controls.Add(this.listBoxVectors);
            this.tabPageVectors.Controls.Add(this.numericUpDownVectorVal4);
            this.tabPageVectors.Controls.Add(this.label24);
            this.tabPageVectors.Controls.Add(this.label25);
            this.tabPageVectors.Controls.Add(this.comboBoxVectorColorTables);
            this.tabPageVectors.Controls.Add(this.numericUpDownVectorVal3);
            this.tabPageVectors.Controls.Add(this.label26);
            this.tabPageVectors.Controls.Add(this.textBoxVectorVal2);
            this.tabPageVectors.Controls.Add(this.numericUpDownVectorOffsetX);
            this.tabPageVectors.Controls.Add(this.textBoxVectorDescription);
            this.tabPageVectors.Controls.Add(this.label27);
            this.tabPageVectors.Controls.Add(this.label28);
            this.tabPageVectors.Controls.Add(this.numericUpDownVectorOffsetY);
            this.tabPageVectors.Controls.Add(this.label29);
            this.tabPageVectors.Controls.Add(this.label30);
            this.tabPageVectors.Controls.Add(this.textBoxVectorVal1);
            this.tabPageVectors.Controls.Add(this.numericUpDownVectorWidth);
            this.tabPageVectors.Controls.Add(this.label31);
            this.tabPageVectors.Controls.Add(this.label32);
            this.tabPageVectors.Controls.Add(this.numericUpDownVectorHotspotY);
            this.tabPageVectors.Controls.Add(this.numericUpDownVectorHeight);
            this.tabPageVectors.Controls.Add(this.label33);
            this.tabPageVectors.Controls.Add(this.label34);
            this.tabPageVectors.Controls.Add(this.numericUpDownVectorHotspotX);
            this.tabPageVectors.Location = new System.Drawing.Point(4, 22);
            this.tabPageVectors.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageVectors.Name = "tabPageVectors";
            this.tabPageVectors.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageVectors.Size = new System.Drawing.Size(642, 414);
            this.tabPageVectors.TabIndex = 2;
            this.tabPageVectors.Text = "Vectors";
            this.tabPageVectors.UseVisualStyleBackColor = true;
            // 
            // tbVectorCode
            // 
            this.tbVectorCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVectorCode.Location = new System.Drawing.Point(7, 56);
            this.tbVectorCode.Margin = new System.Windows.Forms.Padding(2);
            this.tbVectorCode.Name = "tbVectorCode";
            this.tbVectorCode.ReadOnly = true;
            this.tbVectorCode.Size = new System.Drawing.Size(66, 20);
            this.tbVectorCode.TabIndex = 77;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(4, 41);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(41, 13);
            this.label38.TabIndex = 76;
            this.label38.Text = "Symbol";
            // 
            // btnCloneVector
            // 
            this.btnCloneVector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloneVector.Location = new System.Drawing.Point(354, 94);
            this.btnCloneVector.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloneVector.Name = "btnCloneVector";
            this.btnCloneVector.Size = new System.Drawing.Size(52, 20);
            this.btnCloneVector.TabIndex = 73;
            this.btnCloneVector.Text = "Clone";
            this.btnCloneVector.UseVisualStyleBackColor = true;
            this.btnCloneVector.Click += new System.EventHandler(this.btnCloneVector_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(99, 3);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(50, 13);
            this.label35.TabIndex = 69;
            this.label35.Text = "SymbolId";
            // 
            // numericUpDownVectorSymbolId
            // 
            this.numericUpDownVectorSymbolId.Enabled = false;
            this.numericUpDownVectorSymbolId.Location = new System.Drawing.Point(102, 18);
            this.numericUpDownVectorSymbolId.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownVectorSymbolId.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownVectorSymbolId.Name = "numericUpDownVectorSymbolId";
            this.numericUpDownVectorSymbolId.ReadOnly = true;
            this.numericUpDownVectorSymbolId.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownVectorSymbolId.TabIndex = 68;
            // 
            // btnExportVector
            // 
            this.btnExportVector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportVector.Location = new System.Drawing.Point(466, 94);
            this.btnExportVector.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportVector.Name = "btnExportVector";
            this.btnExportVector.Size = new System.Drawing.Size(52, 20);
            this.btnExportVector.TabIndex = 67;
            this.btnExportVector.Text = "Export";
            this.btnExportVector.UseVisualStyleBackColor = true;
            this.btnExportVector.Click += new System.EventHandler(this.btnExportVector_Click);
            // 
            // btnMergeVectors
            // 
            this.btnMergeVectors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMergeVectors.Location = new System.Drawing.Point(410, 94);
            this.btnMergeVectors.Margin = new System.Windows.Forms.Padding(2);
            this.btnMergeVectors.Name = "btnMergeVectors";
            this.btnMergeVectors.Size = new System.Drawing.Size(52, 20);
            this.btnMergeVectors.TabIndex = 66;
            this.btnMergeVectors.Text = "Merge";
            this.btnMergeVectors.UseVisualStyleBackColor = true;
            this.btnMergeVectors.Click += new System.EventHandler(this.btnMergeVectors_Click);
            // 
            // btnExportVectors
            // 
            this.btnExportVectors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportVectors.Location = new System.Drawing.Point(522, 94);
            this.btnExportVectors.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportVectors.Name = "btnExportVectors";
            this.btnExportVectors.Size = new System.Drawing.Size(66, 20);
            this.btnExportVectors.TabIndex = 62;
            this.btnExportVectors.Text = "Export All";
            this.btnExportVectors.UseVisualStyleBackColor = true;
            this.btnExportVectors.Click += new System.EventHandler(this.btnExportVectors_Click);
            // 
            // btnDelVector
            // 
            this.btnDelVector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelVector.Location = new System.Drawing.Point(593, 94);
            this.btnDelVector.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelVector.Name = "btnDelVector";
            this.btnDelVector.Size = new System.Drawing.Size(34, 20);
            this.btnDelVector.TabIndex = 61;
            this.btnDelVector.Text = "Del";
            this.btnDelVector.UseVisualStyleBackColor = true;
            this.btnDelVector.Click += new System.EventHandler(this.btnDelVector_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(106, 119);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxVectorRendering);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxVectors);
            this.splitContainer1.Size = new System.Drawing.Size(521, 279);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 60;
            // 
            // pictureBoxVectorRendering
            // 
            this.pictureBoxVectorRendering.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxVectorRendering.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxVectorRendering.Name = "pictureBoxVectorRendering";
            this.pictureBoxVectorRendering.Size = new System.Drawing.Size(431, 185);
            this.pictureBoxVectorRendering.TabIndex = 0;
            this.pictureBoxVectorRendering.TabStop = false;
            // 
            // textBoxVectors
            // 
            this.textBoxVectors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxVectors.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVectors.Location = new System.Drawing.Point(0, 0);
            this.textBoxVectors.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVectors.Multiline = true;
            this.textBoxVectors.Name = "textBoxVectors";
            this.textBoxVectors.ReadOnly = true;
            this.textBoxVectors.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxVectors.Size = new System.Drawing.Size(519, 88);
            this.textBoxVectors.TabIndex = 59;
            this.textBoxVectors.WordWrap = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(4, 2);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 13);
            this.label22.TabIndex = 36;
            this.label22.Text = "ColorTable";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(278, 3);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(28, 13);
            this.label23.TabIndex = 58;
            this.label23.Text = "Val4";
            // 
            // listBoxVectors
            // 
            this.listBoxVectors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxVectors.FormattingEnabled = true;
            this.listBoxVectors.Location = new System.Drawing.Point(3, 95);
            this.listBoxVectors.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxVectors.Name = "listBoxVectors";
            this.listBoxVectors.Size = new System.Drawing.Size(92, 303);
            this.listBoxVectors.Sorted = true;
            this.listBoxVectors.TabIndex = 33;
            this.listBoxVectors.SelectedIndexChanged += new System.EventHandler(this.listBoxVectors_SelectedIndexChanged);
            // 
            // numericUpDownVectorVal4
            // 
            this.numericUpDownVectorVal4.Enabled = false;
            this.numericUpDownVectorVal4.Location = new System.Drawing.Point(282, 17);
            this.numericUpDownVectorVal4.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownVectorVal4.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownVectorVal4.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownVectorVal4.Name = "numericUpDownVectorVal4";
            this.numericUpDownVectorVal4.ReadOnly = true;
            this.numericUpDownVectorVal4.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownVectorVal4.TabIndex = 57;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 76);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 13);
            this.label24.TabIndex = 34;
            this.label24.Text = "Vectors";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(233, 2);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(28, 13);
            this.label25.TabIndex = 56;
            this.label25.Text = "Val3";
            // 
            // comboBoxVectorColorTables
            // 
            this.comboBoxVectorColorTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVectorColorTables.FormattingEnabled = true;
            this.comboBoxVectorColorTables.Location = new System.Drawing.Point(6, 17);
            this.comboBoxVectorColorTables.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxVectorColorTables.Name = "comboBoxVectorColorTables";
            this.comboBoxVectorColorTables.Size = new System.Drawing.Size(92, 21);
            this.comboBoxVectorColorTables.TabIndex = 35;
            this.comboBoxVectorColorTables.SelectedIndexChanged += new System.EventHandler(this.comboBoxVectorColorTables_SelectedIndexChanged);
            // 
            // numericUpDownVectorVal3
            // 
            this.numericUpDownVectorVal3.Enabled = false;
            this.numericUpDownVectorVal3.Location = new System.Drawing.Point(236, 17);
            this.numericUpDownVectorVal3.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownVectorVal3.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownVectorVal3.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownVectorVal3.Name = "numericUpDownVectorVal3";
            this.numericUpDownVectorVal3.ReadOnly = true;
            this.numericUpDownVectorVal3.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownVectorVal3.TabIndex = 55;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(188, 4);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(28, 13);
            this.label26.TabIndex = 54;
            this.label26.Text = "Val2";
            // 
            // textBoxVectorVal2
            // 
            this.textBoxVectorVal2.Location = new System.Drawing.Point(191, 18);
            this.textBoxVectorVal2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVectorVal2.Name = "textBoxVectorVal2";
            this.textBoxVectorVal2.ReadOnly = true;
            this.textBoxVectorVal2.Size = new System.Drawing.Size(41, 20);
            this.textBoxVectorVal2.TabIndex = 53;
            // 
            // numericUpDownVectorOffsetX
            // 
            this.numericUpDownVectorOffsetX.Enabled = false;
            this.numericUpDownVectorOffsetX.Location = new System.Drawing.Point(327, 17);
            this.numericUpDownVectorOffsetX.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownVectorOffsetX.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownVectorOffsetX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownVectorOffsetX.Name = "numericUpDownVectorOffsetX";
            this.numericUpDownVectorOffsetX.ReadOnly = true;
            this.numericUpDownVectorOffsetX.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownVectorOffsetX.TabIndex = 37;
            // 
            // textBoxVectorDescription
            // 
            this.textBoxVectorDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVectorDescription.Location = new System.Drawing.Point(77, 56);
            this.textBoxVectorDescription.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVectorDescription.Name = "textBoxVectorDescription";
            this.textBoxVectorDescription.ReadOnly = true;
            this.textBoxVectorDescription.Size = new System.Drawing.Size(551, 20);
            this.textBoxVectorDescription.TabIndex = 52;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(324, 2);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(28, 13);
            this.label27.TabIndex = 38;
            this.label27.Text = "XOff";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(77, 41);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(60, 13);
            this.label28.TabIndex = 51;
            this.label28.Text = "Description";
            // 
            // numericUpDownVectorOffsetY
            // 
            this.numericUpDownVectorOffsetY.Enabled = false;
            this.numericUpDownVectorOffsetY.Location = new System.Drawing.Point(373, 17);
            this.numericUpDownVectorOffsetY.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownVectorOffsetY.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownVectorOffsetY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownVectorOffsetY.Name = "numericUpDownVectorOffsetY";
            this.numericUpDownVectorOffsetY.ReadOnly = true;
            this.numericUpDownVectorOffsetY.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownVectorOffsetY.TabIndex = 39;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(163, 4);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(21, 13);
            this.label29.TabIndex = 50;
            this.label29.Text = "SY";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(370, 3);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(28, 13);
            this.label30.TabIndex = 40;
            this.label30.Text = "YOff";
            // 
            // textBoxVectorVal1
            // 
            this.textBoxVectorVal1.Location = new System.Drawing.Point(166, 18);
            this.textBoxVectorVal1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVectorVal1.Name = "textBoxVectorVal1";
            this.textBoxVectorVal1.ReadOnly = true;
            this.textBoxVectorVal1.Size = new System.Drawing.Size(22, 20);
            this.textBoxVectorVal1.TabIndex = 49;
            // 
            // numericUpDownVectorWidth
            // 
            this.numericUpDownVectorWidth.Enabled = false;
            this.numericUpDownVectorWidth.Location = new System.Drawing.Point(419, 17);
            this.numericUpDownVectorWidth.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownVectorWidth.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownVectorWidth.Name = "numericUpDownVectorWidth";
            this.numericUpDownVectorWidth.ReadOnly = true;
            this.numericUpDownVectorWidth.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownVectorWidth.TabIndex = 41;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(553, 2);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(31, 13);
            this.label31.TabIndex = 48;
            this.label31.Text = "HotY";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(415, 3);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(35, 13);
            this.label32.TabIndex = 42;
            this.label32.Text = "Width";
            // 
            // numericUpDownVectorHotspotY
            // 
            this.numericUpDownVectorHotspotY.Enabled = false;
            this.numericUpDownVectorHotspotY.Location = new System.Drawing.Point(556, 17);
            this.numericUpDownVectorHotspotY.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownVectorHotspotY.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownVectorHotspotY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownVectorHotspotY.Name = "numericUpDownVectorHotspotY";
            this.numericUpDownVectorHotspotY.ReadOnly = true;
            this.numericUpDownVectorHotspotY.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownVectorHotspotY.TabIndex = 47;
            // 
            // numericUpDownVectorHeight
            // 
            this.numericUpDownVectorHeight.Enabled = false;
            this.numericUpDownVectorHeight.Location = new System.Drawing.Point(464, 17);
            this.numericUpDownVectorHeight.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownVectorHeight.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownVectorHeight.Name = "numericUpDownVectorHeight";
            this.numericUpDownVectorHeight.ReadOnly = true;
            this.numericUpDownVectorHeight.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownVectorHeight.TabIndex = 43;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(507, 2);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(31, 13);
            this.label33.TabIndex = 46;
            this.label33.Text = "HotX";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(462, 2);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(38, 13);
            this.label34.TabIndex = 44;
            this.label34.Text = "Height";
            // 
            // numericUpDownVectorHotspotX
            // 
            this.numericUpDownVectorHotspotX.Enabled = false;
            this.numericUpDownVectorHotspotX.Location = new System.Drawing.Point(510, 17);
            this.numericUpDownVectorHotspotX.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownVectorHotspotX.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownVectorHotspotX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownVectorHotspotX.Name = "numericUpDownVectorHotspotX";
            this.numericUpDownVectorHotspotX.ReadOnly = true;
            this.numericUpDownVectorHotspotX.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownVectorHotspotX.TabIndex = 45;
            // 
            // tabPageLUPTs
            // 
            this.tabPageLUPTs.Controls.Add(this.btnEditLupt);
            this.tabPageLUPTs.Controls.Add(this.btnDeleteLupt);
            this.tabPageLUPTs.Controls.Add(this.btnCloneRule);
            this.tabPageLUPTs.Controls.Add(this.btnNewRule);
            this.tabPageLUPTs.Controls.Add(this.listViewLookupTable);
            this.tabPageLUPTs.Controls.Add(this.btnSortLupt);
            this.tabPageLUPTs.Controls.Add(this.btnMergeLookupTable);
            this.tabPageLUPTs.Controls.Add(this.btnReplaceTableFromFile);
            this.tabPageLUPTs.Controls.Add(this.btnExportLookupTable);
            this.tabPageLUPTs.Controls.Add(this.label16);
            this.tabPageLUPTs.Controls.Add(this.comboBoxLookupTables);
            this.tabPageLUPTs.Location = new System.Drawing.Point(4, 22);
            this.tabPageLUPTs.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageLUPTs.Name = "tabPageLUPTs";
            this.tabPageLUPTs.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageLUPTs.Size = new System.Drawing.Size(642, 414);
            this.tabPageLUPTs.TabIndex = 3;
            this.tabPageLUPTs.Text = "Lookup tables";
            this.tabPageLUPTs.UseVisualStyleBackColor = true;
            // 
            // btnEditLupt
            // 
            this.btnEditLupt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditLupt.Location = new System.Drawing.Point(350, 5);
            this.btnEditLupt.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditLupt.Name = "btnEditLupt";
            this.btnEditLupt.Size = new System.Drawing.Size(41, 20);
            this.btnEditLupt.TabIndex = 71;
            this.btnEditLupt.Text = "Edit";
            this.btnEditLupt.UseVisualStyleBackColor = true;
            this.btnEditLupt.Click += new System.EventHandler(this.btnEditLupt_Click);
            // 
            // btnDeleteLupt
            // 
            this.btnDeleteLupt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteLupt.Location = new System.Drawing.Point(396, 5);
            this.btnDeleteLupt.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteLupt.Name = "btnDeleteLupt";
            this.btnDeleteLupt.Size = new System.Drawing.Size(41, 20);
            this.btnDeleteLupt.TabIndex = 70;
            this.btnDeleteLupt.Text = "Del";
            this.btnDeleteLupt.UseVisualStyleBackColor = true;
            this.btnDeleteLupt.Click += new System.EventHandler(this.btnDeleteLupt_Click);
            // 
            // btnCloneRule
            // 
            this.btnCloneRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloneRule.Location = new System.Drawing.Point(304, 5);
            this.btnCloneRule.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloneRule.Name = "btnCloneRule";
            this.btnCloneRule.Size = new System.Drawing.Size(41, 20);
            this.btnCloneRule.TabIndex = 69;
            this.btnCloneRule.Text = "Clone";
            this.btnCloneRule.UseVisualStyleBackColor = true;
            this.btnCloneRule.Click += new System.EventHandler(this.btnCloneRule_Click);
            // 
            // btnNewRule
            // 
            this.btnNewRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewRule.Location = new System.Drawing.Point(259, 5);
            this.btnNewRule.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewRule.Name = "btnNewRule";
            this.btnNewRule.Size = new System.Drawing.Size(41, 20);
            this.btnNewRule.TabIndex = 68;
            this.btnNewRule.Text = "New";
            this.btnNewRule.UseVisualStyleBackColor = true;
            this.btnNewRule.Click += new System.EventHandler(this.btnNewRule_Click);
            // 
            // listViewLookupTable
            // 
            this.listViewLookupTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewLookupTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.listViewLookupTable.FullRowSelect = true;
            this.listViewLookupTable.GridLines = true;
            this.listViewLookupTable.Location = new System.Drawing.Point(2, 28);
            this.listViewLookupTable.Margin = new System.Windows.Forms.Padding(2);
            this.listViewLookupTable.MultiSelect = false;
            this.listViewLookupTable.Name = "listViewLookupTable";
            this.listViewLookupTable.Size = new System.Drawing.Size(640, 385);
            this.listViewLookupTable.TabIndex = 67;
            this.listViewLookupTable.UseCompatibleStateImageBehavior = false;
            this.listViewLookupTable.View = System.Windows.Forms.View.Details;
            this.listViewLookupTable.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewLookupTable_MouseDoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Lookup Rule";
            this.columnHeader6.Width = 100;
            // 
            // btnSortLupt
            // 
            this.btnSortLupt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortLupt.Location = new System.Drawing.Point(442, 4);
            this.btnSortLupt.Margin = new System.Windows.Forms.Padding(2);
            this.btnSortLupt.Name = "btnSortLupt";
            this.btnSortLupt.Size = new System.Drawing.Size(41, 20);
            this.btnSortLupt.TabIndex = 66;
            this.btnSortLupt.Text = "Sort";
            this.btnSortLupt.UseVisualStyleBackColor = true;
            this.btnSortLupt.Click += new System.EventHandler(this.btnSortLupt_Click);
            // 
            // btnMergeLookupTable
            // 
            this.btnMergeLookupTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMergeLookupTable.Location = new System.Drawing.Point(488, 4);
            this.btnMergeLookupTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnMergeLookupTable.Name = "btnMergeLookupTable";
            this.btnMergeLookupTable.Size = new System.Drawing.Size(45, 20);
            this.btnMergeLookupTable.TabIndex = 65;
            this.btnMergeLookupTable.Text = "Merge";
            this.btnMergeLookupTable.UseVisualStyleBackColor = true;
            this.btnMergeLookupTable.Click += new System.EventHandler(this.btnMergeLookupTable_Click);
            // 
            // btnReplaceTableFromFile
            // 
            this.btnReplaceTableFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReplaceTableFromFile.Location = new System.Drawing.Point(537, 4);
            this.btnReplaceTableFromFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnReplaceTableFromFile.Name = "btnReplaceTableFromFile";
            this.btnReplaceTableFromFile.Size = new System.Drawing.Size(56, 20);
            this.btnReplaceTableFromFile.TabIndex = 64;
            this.btnReplaceTableFromFile.Text = "Replace";
            this.btnReplaceTableFromFile.UseVisualStyleBackColor = true;
            this.btnReplaceTableFromFile.Click += new System.EventHandler(this.btnReplaceTableFromFile_Click);
            // 
            // btnExportLookupTable
            // 
            this.btnExportLookupTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportLookupTable.Location = new System.Drawing.Point(597, 4);
            this.btnExportLookupTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportLookupTable.Name = "btnExportLookupTable";
            this.btnExportLookupTable.Size = new System.Drawing.Size(45, 20);
            this.btnExportLookupTable.TabIndex = 63;
            this.btnExportLookupTable.Text = "Export";
            this.btnExportLookupTable.UseVisualStyleBackColor = true;
            this.btnExportLookupTable.Click += new System.EventHandler(this.btnExportLookupTable_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 7);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Lookup Table";
            // 
            // comboBoxLookupTables
            // 
            this.comboBoxLookupTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLookupTables.FormattingEnabled = true;
            this.comboBoxLookupTables.Items.AddRange(new object[] {
            "Points - PAPER_CHART",
            "Points - SIMPLIFIED",
            "Lines - LINES",
            "Area - PLAIN_BOUNDARIES",
            "Area - SYMBOLIZED_BOUNDARIES"});
            this.comboBoxLookupTables.Location = new System.Drawing.Point(79, 5);
            this.comboBoxLookupTables.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxLookupTables.Name = "comboBoxLookupTables";
            this.comboBoxLookupTables.Size = new System.Drawing.Size(176, 21);
            this.comboBoxLookupTables.TabIndex = 9;
            this.comboBoxLookupTables.SelectedIndexChanged += new System.EventHandler(this.comboBoxLookupTables_SelectedIndexChanged);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(667, 24);
            this.menuStripMain.TabIndex = 34;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.mergeToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorTablesToolStripMenuItem,
            this.bitmapsToolStripMenuItem,
            this.vectorsToolStripMenuItem,
            this.lookupTablesToolStripMenuItem,
            this.symbolsToPNGToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.exportToolStripMenuItem.Text = "&Export";
            // 
            // colorTablesToolStripMenuItem
            // 
            this.colorTablesToolStripMenuItem.Name = "colorTablesToolStripMenuItem";
            this.colorTablesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorTablesToolStripMenuItem.Text = "&Color tables...";
            this.colorTablesToolStripMenuItem.Click += new System.EventHandler(this.colorTablesToolStripMenuItem_Click);
            // 
            // bitmapsToolStripMenuItem
            // 
            this.bitmapsToolStripMenuItem.Name = "bitmapsToolStripMenuItem";
            this.bitmapsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bitmapsToolStripMenuItem.Text = "&Bitmaps...";
            this.bitmapsToolStripMenuItem.Click += new System.EventHandler(this.bitmapsToolStripMenuItem_Click);
            // 
            // vectorsToolStripMenuItem
            // 
            this.vectorsToolStripMenuItem.Name = "vectorsToolStripMenuItem";
            this.vectorsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vectorsToolStripMenuItem.Text = "&Vectors...";
            this.vectorsToolStripMenuItem.Click += new System.EventHandler(this.vectorsToolStripMenuItem_Click);
            // 
            // lookupTablesToolStripMenuItem
            // 
            this.lookupTablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointsPAPERCHARTToolStripMenuItem,
            this.pointsSIMPLIFIEDToolStripMenuItem,
            this.linesToolStripMenuItem,
            this.areaPLAINBORDERSToolStripMenuItem,
            this.areaSYMBOLIZEDBORDERSToolStripMenuItem});
            this.lookupTablesToolStripMenuItem.Name = "lookupTablesToolStripMenuItem";
            this.lookupTablesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lookupTablesToolStripMenuItem.Text = "&Lookup table";
            // 
            // pointsPAPERCHARTToolStripMenuItem
            // 
            this.pointsPAPERCHARTToolStripMenuItem.Name = "pointsPAPERCHARTToolStripMenuItem";
            this.pointsPAPERCHARTToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.pointsPAPERCHARTToolStripMenuItem.Text = "&Points (PAPER _CHART)...";
            // 
            // pointsSIMPLIFIEDToolStripMenuItem
            // 
            this.pointsSIMPLIFIEDToolStripMenuItem.Name = "pointsSIMPLIFIEDToolStripMenuItem";
            this.pointsSIMPLIFIEDToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.pointsSIMPLIFIEDToolStripMenuItem.Text = "P&oints (SIMPLIFIED)...";
            // 
            // linesToolStripMenuItem
            // 
            this.linesToolStripMenuItem.Name = "linesToolStripMenuItem";
            this.linesToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.linesToolStripMenuItem.Text = "&Lines...";
            // 
            // areaPLAINBORDERSToolStripMenuItem
            // 
            this.areaPLAINBORDERSToolStripMenuItem.Name = "areaPLAINBORDERSToolStripMenuItem";
            this.areaPLAINBORDERSToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.areaPLAINBORDERSToolStripMenuItem.Text = "&Area (PLAIN_BOUNDARIES)...";
            // 
            // areaSYMBOLIZEDBORDERSToolStripMenuItem
            // 
            this.areaSYMBOLIZEDBORDERSToolStripMenuItem.Name = "areaSYMBOLIZEDBORDERSToolStripMenuItem";
            this.areaSYMBOLIZEDBORDERSToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.areaSYMBOLIZEDBORDERSToolStripMenuItem.Text = "A&rea (SYMBOLIZED_BOUNDARIES)...";
            // 
            // mergeToolStripMenuItem
            // 
            this.mergeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitmapToolStripMenuItem,
            this.vectorToolStripMenuItem,
            this.lookupTableToolStripMenuItem});
            this.mergeToolStripMenuItem.Name = "mergeToolStripMenuItem";
            this.mergeToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.mergeToolStripMenuItem.Text = "&Merge";
            // 
            // bitmapToolStripMenuItem
            // 
            this.bitmapToolStripMenuItem.Name = "bitmapToolStripMenuItem";
            this.bitmapToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.bitmapToolStripMenuItem.Text = "&Bitmaps...";
            this.bitmapToolStripMenuItem.Click += new System.EventHandler(this.bitmapToolStripMenuItem_Click);
            // 
            // vectorToolStripMenuItem
            // 
            this.vectorToolStripMenuItem.Name = "vectorToolStripMenuItem";
            this.vectorToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.vectorToolStripMenuItem.Text = "&Vectors...";
            this.vectorToolStripMenuItem.Click += new System.EventHandler(this.vectorToolStripMenuItem_Click);
            // 
            // lookupTableToolStripMenuItem
            // 
            this.lookupTableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointsPAPERCHARTToolStripMenuItem2,
            this.pointsSIMPLIFIEDToolStripMenuItem1,
            this.linesToolStripMenuItem2,
            this.areaPLAINBORDERSToolStripMenuItem2,
            this.areaSYMBOLIZEDBORDERSToolStripMenuItem1});
            this.lookupTableToolStripMenuItem.Name = "lookupTableToolStripMenuItem";
            this.lookupTableToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.lookupTableToolStripMenuItem.Text = "&Lookup table";
            // 
            // pointsPAPERCHARTToolStripMenuItem2
            // 
            this.pointsPAPERCHARTToolStripMenuItem2.Name = "pointsPAPERCHARTToolStripMenuItem2";
            this.pointsPAPERCHARTToolStripMenuItem2.Size = new System.Drawing.Size(253, 22);
            this.pointsPAPERCHARTToolStripMenuItem2.Text = "&Points (PAPER _CHART)...";
            this.pointsPAPERCHARTToolStripMenuItem2.Click += new System.EventHandler(this.pointsPAPERCHARTToolStripMenuItem2_Click);
            // 
            // pointsSIMPLIFIEDToolStripMenuItem1
            // 
            this.pointsSIMPLIFIEDToolStripMenuItem1.Name = "pointsSIMPLIFIEDToolStripMenuItem1";
            this.pointsSIMPLIFIEDToolStripMenuItem1.Size = new System.Drawing.Size(253, 22);
            this.pointsSIMPLIFIEDToolStripMenuItem1.Text = "P&oints (SIMPLIFIED)...";
            this.pointsSIMPLIFIEDToolStripMenuItem1.Click += new System.EventHandler(this.pointsSIMPLIFIEDToolStripMenuItem1_Click);
            // 
            // linesToolStripMenuItem2
            // 
            this.linesToolStripMenuItem2.Name = "linesToolStripMenuItem2";
            this.linesToolStripMenuItem2.Size = new System.Drawing.Size(253, 22);
            this.linesToolStripMenuItem2.Text = "&Lines...";
            this.linesToolStripMenuItem2.Click += new System.EventHandler(this.linesToolStripMenuItem2_Click);
            // 
            // areaPLAINBORDERSToolStripMenuItem2
            // 
            this.areaPLAINBORDERSToolStripMenuItem2.Name = "areaPLAINBORDERSToolStripMenuItem2";
            this.areaPLAINBORDERSToolStripMenuItem2.Size = new System.Drawing.Size(253, 22);
            this.areaPLAINBORDERSToolStripMenuItem2.Text = "&Area (PLAIN_BOUNDARIES)...";
            this.areaPLAINBORDERSToolStripMenuItem2.Click += new System.EventHandler(this.areaPLAINBORDERSToolStripMenuItem2_Click);
            // 
            // areaSYMBOLIZEDBORDERSToolStripMenuItem1
            // 
            this.areaSYMBOLIZEDBORDERSToolStripMenuItem1.Name = "areaSYMBOLIZEDBORDERSToolStripMenuItem1";
            this.areaSYMBOLIZEDBORDERSToolStripMenuItem1.Size = new System.Drawing.Size(253, 22);
            this.areaSYMBOLIZEDBORDERSToolStripMenuItem1.Text = "A&rea (SYMBOLIZED_BOUNDARIES)...";
            this.areaSYMBOLIZEDBORDERSToolStripMenuItem1.Click += new System.EventHandler(this.areaSYMBOLIZEDBORDERSToolStripMenuItem1_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lookupTableToolStripMenuItem1});
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.replaceToolStripMenuItem.Text = "&Replace";
            // 
            // lookupTableToolStripMenuItem1
            // 
            this.lookupTableToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointsPAPERCHARTToolStripMenuItem1,
            this.pointsSIMPLIFIEDToolStripMenuItem2,
            this.linesToolStripMenuItem1,
            this.areaPLAINBORDERSToolStripMenuItem1,
            this.areaSYMBOLIZEDBORDERSToolStripMenuItem2});
            this.lookupTableToolStripMenuItem1.Name = "lookupTableToolStripMenuItem1";
            this.lookupTableToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.lookupTableToolStripMenuItem1.Text = "&Lookup table";
            // 
            // pointsPAPERCHARTToolStripMenuItem1
            // 
            this.pointsPAPERCHARTToolStripMenuItem1.Name = "pointsPAPERCHARTToolStripMenuItem1";
            this.pointsPAPERCHARTToolStripMenuItem1.Size = new System.Drawing.Size(253, 22);
            this.pointsPAPERCHARTToolStripMenuItem1.Text = "&Points (PAPER _CHART)...";
            this.pointsPAPERCHARTToolStripMenuItem1.Click += new System.EventHandler(this.pointsPAPERCHARTToolStripMenuItem1_Click);
            // 
            // pointsSIMPLIFIEDToolStripMenuItem2
            // 
            this.pointsSIMPLIFIEDToolStripMenuItem2.Name = "pointsSIMPLIFIEDToolStripMenuItem2";
            this.pointsSIMPLIFIEDToolStripMenuItem2.Size = new System.Drawing.Size(253, 22);
            this.pointsSIMPLIFIEDToolStripMenuItem2.Text = "P&oints (SIMPLIFIED)...";
            this.pointsSIMPLIFIEDToolStripMenuItem2.Click += new System.EventHandler(this.pointsSIMPLIFIEDToolStripMenuItem2_Click);
            // 
            // linesToolStripMenuItem1
            // 
            this.linesToolStripMenuItem1.Name = "linesToolStripMenuItem1";
            this.linesToolStripMenuItem1.Size = new System.Drawing.Size(253, 22);
            this.linesToolStripMenuItem1.Text = "&Lines...";
            this.linesToolStripMenuItem1.Click += new System.EventHandler(this.linesToolStripMenuItem1_Click);
            // 
            // areaPLAINBORDERSToolStripMenuItem1
            // 
            this.areaPLAINBORDERSToolStripMenuItem1.Name = "areaPLAINBORDERSToolStripMenuItem1";
            this.areaPLAINBORDERSToolStripMenuItem1.Size = new System.Drawing.Size(253, 22);
            this.areaPLAINBORDERSToolStripMenuItem1.Text = "&Area (PLAIN_BOUNDARIES)...";
            this.areaPLAINBORDERSToolStripMenuItem1.Click += new System.EventHandler(this.areaPLAINBORDERSToolStripMenuItem1_Click);
            // 
            // areaSYMBOLIZEDBORDERSToolStripMenuItem2
            // 
            this.areaSYMBOLIZEDBORDERSToolStripMenuItem2.Name = "areaSYMBOLIZEDBORDERSToolStripMenuItem2";
            this.areaSYMBOLIZEDBORDERSToolStripMenuItem2.Size = new System.Drawing.Size(253, 22);
            this.areaSYMBOLIZEDBORDERSToolStripMenuItem2.Text = "A&rea (SYMBOLIZED_BOUNDARIES)...";
            this.areaSYMBOLIZEDBORDERSToolStripMenuItem2.Click += new System.EventHandler(this.areaSYMBOLIZEDBORDERSToolStripMenuItem2_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortAllLookupTablesToolStripMenuItem,
            this.resetNumberingToolStripMenuItem,
            this.clearAllLookupTaToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.toolStripSeparator2,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // sortAllLookupTablesToolStripMenuItem
            // 
            this.sortAllLookupTablesToolStripMenuItem.Name = "sortAllLookupTablesToolStripMenuItem";
            this.sortAllLookupTablesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.sortAllLookupTablesToolStripMenuItem.Text = "&Sort all lookup tables";
            this.sortAllLookupTablesToolStripMenuItem.Click += new System.EventHandler(this.sortAllLookupTablesToolStripMenuItem_Click);
            // 
            // resetNumberingToolStripMenuItem
            // 
            this.resetNumberingToolStripMenuItem.Name = "resetNumberingToolStripMenuItem";
            this.resetNumberingToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.resetNumberingToolStripMenuItem.Text = "&Reset numbering";
            this.resetNumberingToolStripMenuItem.ToolTipText = "Renumbers all the records starting from 1";
            this.resetNumberingToolStripMenuItem.Click += new System.EventHandler(this.resetNumberingToolStripMenuItem_Click);
            // 
            // clearAllLookupTaToolStripMenuItem
            // 
            this.clearAllLookupTaToolStripMenuItem.Name = "clearAllLookupTaToolStripMenuItem";
            this.clearAllLookupTaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.clearAllLookupTaToolStripMenuItem.Text = "Clear all lookup tables";
            this.clearAllLookupTaToolStripMenuItem.Click += new System.EventHandler(this.clearAllLookupTaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.toolStripMenuItem1.Text = "CSV Merger";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(175, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.optionsToolStripMenuItem.Text = "&Options...";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.documentationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.documentationToolStripMenuItem.Text = "&Documentation";
            this.documentationToolStripMenuItem.Click += new System.EventHandler(this.documentationToolStripMenuItem_Click);
            // 
            // symbolsToPNGToolStripMenuItem
            // 
            this.symbolsToPNGToolStripMenuItem.Name = "symbolsToPNGToolStripMenuItem";
            this.symbolsToPNGToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.symbolsToPNGToolStripMenuItem.Text = "Symbols to PNG";
            this.symbolsToPNGToolStripMenuItem.Click += new System.EventHandler(this.symbolsToPNGToolStripMenuItem_Click);
            // 
            // RleEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 510);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFilename);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(675, 411);
            this.Name = "RleEditorForm";
            this.Text = "Rasterization Rules Editor";
            this.Load += new System.EventHandler(this.RleEditorFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RLEEditorFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBitmapView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBitmapOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBitmapOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBitmapWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBitmapHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBitmapHotspotX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBitmapHotspotY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBitmapValue3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBitmapValue4)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageColorTables.ResumeLayout(false);
            this.tabPageColorTables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditColory1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditColorx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditColorY)).EndInit();
            this.tabPageBitmaps.ResumeLayout(false);
            this.tabPageBitmaps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBitmapSymbolId)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBitmapEditor)).EndInit();
            this.tabPageVectors.ResumeLayout(false);
            this.tabPageVectors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVectorSymbolId)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVectorRendering)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVectorVal4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVectorVal3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVectorOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVectorOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVectorWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVectorHotspotY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVectorHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVectorHotspotX)).EndInit();
            this.tabPageLUPTs.ResumeLayout(false);
            this.tabPageLUPTs.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox textBoxFilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxBitmaps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBitmapColorTables;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxBitmapView;
        private System.Windows.Forms.NumericUpDown numericUpDownBitmapOffsetX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownBitmapOffsetY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownBitmapWidth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownBitmapHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownBitmapHotspotX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownBitmapHotspotY;
        private System.Windows.Forms.TextBox textBoxBitmapVal1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxBitmapDescription;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxBitmapVal2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDownBitmapValue3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDownBitmapValue4;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageColorTables;
        private System.Windows.Forms.TabPage tabPageBitmaps;
        private System.Windows.Forms.TabPage tabPageVectors;
        private System.Windows.Forms.TabPage tabPageLUPTs;
        private System.Windows.Forms.ListView listViewColorTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxColorTablesList;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBoxLookupTables;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDownEditColorY;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxColorName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxColorCode;
        private System.Windows.Forms.PictureBox pictureBoxColorSample;
        private System.Windows.Forms.Button buttonCommitColorChange;
        private System.Windows.Forms.Button buttonShowColorDialog;
        private System.Windows.Forms.NumericUpDown numericUpDownEditColory1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown numericUpDownEditColorx;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBoxBitmapEditor;
        private System.Windows.Forms.ComboBox comboBoxZoom;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitmapsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vectorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lookupTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointsPAPERCHARTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointsSIMPLIFIEDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaPLAINBORDERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaSYMBOLIZEDBORDERSToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxVectors;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ListBox listBoxVectors;
        private System.Windows.Forms.NumericUpDown numericUpDownVectorVal4;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox comboBoxVectorColorTables;
        private System.Windows.Forms.NumericUpDown numericUpDownVectorVal3;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBoxVectorVal2;
        private System.Windows.Forms.NumericUpDown numericUpDownVectorOffsetX;
        private System.Windows.Forms.TextBox textBoxVectorDescription;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown numericUpDownVectorOffsetY;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBoxVectorVal1;
        private System.Windows.Forms.NumericUpDown numericUpDownVectorWidth;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.NumericUpDown numericUpDownVectorHotspotY;
        private System.Windows.Forms.NumericUpDown numericUpDownVectorHeight;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.NumericUpDown numericUpDownVectorHotspotX;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBoxVectorRendering;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBoxBitmapText;
        private System.Windows.Forms.Button btnDeleteBitmap;
        private System.Windows.Forms.Button btnDelVector;
        private System.Windows.Forms.Button btnExportVectors;
        private System.Windows.Forms.Button btnExportBitmaps;
        private System.Windows.Forms.Button btnExportLookupTable;
        private System.Windows.Forms.Button btnReplaceTableFromFile;
        private System.Windows.Forms.Button btnMergeLookupTable;
        private System.Windows.Forms.Button btnMergeBitmaps;
        private System.Windows.Forms.Button btnMergeVectors;
        private System.Windows.Forms.Button btnExportBitmap;
        private System.Windows.Forms.Button btnExportVector;
        private System.Windows.Forms.Button btnSortLupt;
        private System.Windows.Forms.ToolStripMenuItem mergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitmapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetNumberingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lookupTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointsPAPERCHARTToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pointsSIMPLIFIEDToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem linesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem areaPLAINBORDERSToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem areaSYMBOLIZEDBORDERSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lookupTableToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pointsPAPERCHARTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pointsSIMPLIFIEDToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem linesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem areaPLAINBORDERSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem areaSYMBOLIZEDBORDERSToolStripMenuItem2;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.NumericUpDown numericUpDownVectorSymbolId;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.NumericUpDown numericUpDownBitmapSymbolId;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Button btnExportColorTables;
        private System.Windows.Forms.Button btnExportColorTable;
        private System.Windows.Forms.ListView listViewLookupTable;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStripMenuItem sortAllLookupTablesToolStripMenuItem;
        private System.Windows.Forms.Button btnCloneRule;
        private System.Windows.Forms.Button btnNewRule;
        private System.Windows.Forms.Button btnDeleteLupt;
        private System.Windows.Forms.Button btnEditLupt;
        private System.Windows.Forms.Button btnCloneBitmap;
        private System.Windows.Forms.ComboBox colorComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem clearAllLookupTaToolStripMenuItem;
        private System.Windows.Forms.Button btnCloneVector;
        private System.Windows.Forms.Button btnReplaceColorTables;
        private System.Windows.Forms.Button btnMergeColorTables;
        private System.Windows.Forms.Button btnDeleteColorTable;
        private System.Windows.Forms.TextBox tbSymbolCode;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox tbVectorCode;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ToolStripMenuItem symbolsToPNGToolStripMenuItem;
    }
}

