namespace DIP_START
{
    partial class MainInterface
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.brightenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filitersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neighbourhoodAveragingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withThresholdingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withoutThresholdingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robertsGradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pseudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withThresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gxGyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inclinedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HistoryList = new System.Windows.Forms.ListBox();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equaliseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.levelsToolStripMenuItem,
            this.inverseToolStripMenuItem,
            this.binarizeToolStripMenuItem,
            this.filitersToolStripMenuItem,
            this.histogramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // levelsToolStripMenuItem
            // 
            this.levelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkenToolStripMenuItem1,
            this.brightenToolStripMenuItem1});
            this.levelsToolStripMenuItem.Name = "levelsToolStripMenuItem";
            this.levelsToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.levelsToolStripMenuItem.Text = "Levels";
            // 
            // darkenToolStripMenuItem1
            // 
            this.darkenToolStripMenuItem1.Name = "darkenToolStripMenuItem1";
            this.darkenToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.darkenToolStripMenuItem1.Text = "Darken";
            this.darkenToolStripMenuItem1.Click += new System.EventHandler(this.darkenToolStripMenuItem1_Click);
            // 
            // brightenToolStripMenuItem1
            // 
            this.brightenToolStripMenuItem1.Name = "brightenToolStripMenuItem1";
            this.brightenToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.brightenToolStripMenuItem1.Text = "Brighten";
            this.brightenToolStripMenuItem1.Click += new System.EventHandler(this.brightenToolStripMenuItem1_Click);
            // 
            // inverseToolStripMenuItem
            // 
            this.inverseToolStripMenuItem.Name = "inverseToolStripMenuItem";
            this.inverseToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.inverseToolStripMenuItem.Text = "Inverse";
            this.inverseToolStripMenuItem.Click += new System.EventHandler(this.inverseToolStripMenuItem_Click);
            // 
            // binarizeToolStripMenuItem
            // 
            this.binarizeToolStripMenuItem.Name = "binarizeToolStripMenuItem";
            this.binarizeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.binarizeToolStripMenuItem.Text = "Binarize";
            this.binarizeToolStripMenuItem.Click += new System.EventHandler(this.binarizeToolStripMenuItem_Click);
            // 
            // filitersToolStripMenuItem
            // 
            this.filitersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smoothingToolStripMenuItem,
            this.sharpenToolStripMenuItem});
            this.filitersToolStripMenuItem.Name = "filitersToolStripMenuItem";
            this.filitersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.filitersToolStripMenuItem.Text = "Filters";
            // 
            // smoothingToolStripMenuItem
            // 
            this.smoothingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neighbourhoodAveragingToolStripMenuItem,
            this.medToolStripMenuItem1});
            this.smoothingToolStripMenuItem.Name = "smoothingToolStripMenuItem";
            this.smoothingToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.smoothingToolStripMenuItem.Text = "Smoothing";
            // 
            // neighbourhoodAveragingToolStripMenuItem
            // 
            this.neighbourhoodAveragingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withThresholdingToolStripMenuItem,
            this.withoutThresholdingToolStripMenuItem});
            this.neighbourhoodAveragingToolStripMenuItem.Name = "neighbourhoodAveragingToolStripMenuItem";
            this.neighbourhoodAveragingToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.neighbourhoodAveragingToolStripMenuItem.Text = "Neighbourhood Averaging";
            // 
            // withThresholdingToolStripMenuItem
            // 
            this.withThresholdingToolStripMenuItem.Name = "withThresholdingToolStripMenuItem";
            this.withThresholdingToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.withThresholdingToolStripMenuItem.Text = "With Thresholding";
            this.withThresholdingToolStripMenuItem.Click += new System.EventHandler(this.NeibhourhoodAvgwithThresholdingToolStripMenuItem_Click);
            // 
            // withoutThresholdingToolStripMenuItem
            // 
            this.withoutThresholdingToolStripMenuItem.Name = "withoutThresholdingToolStripMenuItem";
            this.withoutThresholdingToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.withoutThresholdingToolStripMenuItem.Text = "Without Thresholding";
            this.withoutThresholdingToolStripMenuItem.Click += new System.EventHandler(this.withoutThresholdingToolStripMenuItem_Click);
            // 
            // medToolStripMenuItem1
            // 
            this.medToolStripMenuItem1.Name = "medToolStripMenuItem1";
            this.medToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.medToolStripMenuItem1.Text = "Median";
            this.medToolStripMenuItem1.Click += new System.EventHandler(this.medToolStripMenuItem1_Click);
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.robertsGradientToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.laplacianToolStripMenuItem,
            this.pointDetectionToolStripMenuItem,
            this.lineDetectionToolStripMenuItem});
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            // 
            // robertsGradientToolStripMenuItem
            // 
            this.robertsGradientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pseudoToolStripMenuItem,
            this.directToolStripMenuItem,
            this.withThresholdToolStripMenuItem});
            this.robertsGradientToolStripMenuItem.Name = "robertsGradientToolStripMenuItem";
            this.robertsGradientToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.robertsGradientToolStripMenuItem.Text = "Roberts Gradient";
            // 
            // pseudoToolStripMenuItem
            // 
            this.pseudoToolStripMenuItem.Name = "pseudoToolStripMenuItem";
            this.pseudoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.pseudoToolStripMenuItem.Text = "Pseudo";
            this.pseudoToolStripMenuItem.Click += new System.EventHandler(this.PseudoToolStripMenuItem_Click);
            // 
            // directToolStripMenuItem
            // 
            this.directToolStripMenuItem.Name = "directToolStripMenuItem";
            this.directToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.directToolStripMenuItem.Text = "Direct";
            this.directToolStripMenuItem.Click += new System.EventHandler(this.directToolStripMenuItem_Click);
            // 
            // withThresholdToolStripMenuItem
            // 
            this.withThresholdToolStripMenuItem.Name = "withThresholdToolStripMenuItem";
            this.withThresholdToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.withThresholdToolStripMenuItem.Text = "With Threshold";
            this.withThresholdToolStripMenuItem.Click += new System.EventHandler(this.RobertsGradientwithThresholdToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gxToolStripMenuItem,
            this.gyToolStripMenuItem,
            this.gxGyToolStripMenuItem});
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.sobelToolStripMenuItem.Text = "SharpenFilters";
            // 
            // gxToolStripMenuItem
            // 
            this.gxToolStripMenuItem.Name = "gxToolStripMenuItem";
            this.gxToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.gxToolStripMenuItem.Text = "Gx";
            this.gxToolStripMenuItem.Click += new System.EventHandler(this.Sobel_GxToolStripMenuItem_Click);
            // 
            // gyToolStripMenuItem
            // 
            this.gyToolStripMenuItem.Name = "gyToolStripMenuItem";
            this.gyToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.gyToolStripMenuItem.Text = "Gy";
            this.gyToolStripMenuItem.Click += new System.EventHandler(this.Soblel_GyToolStripMenuItem_Click);
            // 
            // gxGyToolStripMenuItem
            // 
            this.gxGyToolStripMenuItem.Name = "gxGyToolStripMenuItem";
            this.gxGyToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.gxGyToolStripMenuItem.Text = "Gx + Gy";
            this.gxGyToolStripMenuItem.Click += new System.EventHandler(this.Sobel_GxAndGyToolStripMenuItem_Click);
            // 
            // laplacianToolStripMenuItem
            // 
            this.laplacianToolStripMenuItem.Name = "laplacianToolStripMenuItem";
            this.laplacianToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.laplacianToolStripMenuItem.Text = "Laplacian";
            this.laplacianToolStripMenuItem.Click += new System.EventHandler(this.laplacianToolStripMenuItem_Click);
            // 
            // pointDetectionToolStripMenuItem
            // 
            this.pointDetectionToolStripMenuItem.Name = "pointDetectionToolStripMenuItem";
            this.pointDetectionToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.pointDetectionToolStripMenuItem.Text = "Point Detection";
            this.pointDetectionToolStripMenuItem.Click += new System.EventHandler(this.pointDetectionToolStripMenuItem_Click);
            // 
            // lineDetectionToolStripMenuItem
            // 
            this.lineDetectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.inclinedToolStripMenuItem});
            this.lineDetectionToolStripMenuItem.Name = "lineDetectionToolStripMenuItem";
            this.lineDetectionToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.lineDetectionToolStripMenuItem.Text = "Line Detection";
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // inclinedToolStripMenuItem
            // 
            this.inclinedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.inclinedToolStripMenuItem.Name = "inclinedToolStripMenuItem";
            this.inclinedToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.inclinedToolStripMenuItem.Text = "Inclined";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem2.Text = "+ 45";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.Positive45_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem3.Text = "- 45";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.Negative45_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HistoryList);
            this.groupBox1.Location = new System.Drawing.Point(625, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 501);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "History";
            // 
            // HistoryList
            // 
            this.HistoryList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.HistoryList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HistoryList.FormattingEnabled = true;
            this.HistoryList.Location = new System.Drawing.Point(6, 20);
            this.HistoryList.Name = "HistoryList";
            this.HistoryList.Size = new System.Drawing.Size(188, 468);
            this.HistoryList.TabIndex = 0;
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equaliseToolStripMenuItem});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.histogramToolStripMenuItem.Text = "Histogram";
            // 
            // equaliseToolStripMenuItem
            // 
            this.equaliseToolStripMenuItem.Name = "equaliseToolStripMenuItem";
            this.equaliseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.equaliseToolStripMenuItem.Text = "Equalise";
            this.equaliseToolStripMenuItem.Click += new System.EventHandler(this.equaliseToolStripMenuItem_Click);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainInterface";
            this.Text = "Photochop";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inverseToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem binarizeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem filitersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smoothingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neighbourhoodAveragingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem levelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem brightenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem withThresholdingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withoutThresholdingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robertsGradientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pseudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gxGyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withThresholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplacianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inclinedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ListBox HistoryList;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equaliseToolStripMenuItem;
    }
}

