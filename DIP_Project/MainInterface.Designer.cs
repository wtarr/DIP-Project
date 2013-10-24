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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Brighten_false = new System.Windows.Forms.ToolStripMenuItem();
            this.Darken_false = new System.Windows.Forms.ToolStripMenuItem();
            this.Inverse_false = new System.Windows.Forms.ToolStripMenuItem();
            this.Binarize_true = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pBox_Original = new System.Windows.Forms.PictureBox();
            this.pBox_ProcImg = new System.Windows.Forms.PictureBox();
            this.thresholdPanel = new System.Windows.Forms.Panel();
            this.main_Trackbar = new System.Windows.Forms.TrackBar();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neighbourhoodAveragingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Median_false = new System.Windows.Forms.ToolStripMenuItem();
            this.NeighbourhoodAveraging_true = new System.Windows.Forms.ToolStripMenuItem();
            this.NeighbourhoodAveraging_false = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblThresholdValue = new System.Windows.Forms.Label();
            this.robertsGradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pseudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withThresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gxGyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inclinedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_ProcImg)).BeginInit();
            this.thresholdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_Trackbar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.levelsToolStripMenuItem,
            this.Inverse_false,
            this.Binarize_true,
            this.filtersToolStripMenuItem,
            this.histogramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1260, 24);
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
            this.Brighten_false,
            this.Darken_false});
            this.levelsToolStripMenuItem.Name = "levelsToolStripMenuItem";
            this.levelsToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.levelsToolStripMenuItem.Text = "Levels";
            // 
            // Brighten_false
            // 
            this.Brighten_false.Name = "Brighten_false";
            this.Brighten_false.Size = new System.Drawing.Size(119, 22);
            this.Brighten_false.Text = "Brighten";
            this.Brighten_false.Click += new System.EventHandler(this.MenuItemClicked);
            // 
            // Darken_false
            // 
            this.Darken_false.Name = "Darken_false";
            this.Darken_false.Size = new System.Drawing.Size(119, 22);
            this.Darken_false.Text = "Darken";
            this.Darken_false.Click += new System.EventHandler(this.MenuItemClicked);
            // 
            // Inverse_false
            // 
            this.Inverse_false.Name = "Inverse_false";
            this.Inverse_false.Size = new System.Drawing.Size(56, 20);
            this.Inverse_false.Text = "Inverse";
            this.Inverse_false.Click += new System.EventHandler(this.MenuItemClicked);
            // 
            // Binarize_true
            // 
            this.Binarize_true.Name = "Binarize_true";
            this.Binarize_true.Size = new System.Drawing.Size(60, 20);
            this.Binarize_true.Text = "Binarize";
            this.Binarize_true.Click += new System.EventHandler(this.MenuItemClicked);
            // 
            // pBox_Original
            // 
            this.pBox_Original.Location = new System.Drawing.Point(12, 27);
            this.pBox_Original.Name = "pBox_Original";
            this.pBox_Original.Size = new System.Drawing.Size(512, 512);
            this.pBox_Original.TabIndex = 1;
            this.pBox_Original.TabStop = false;
            // 
            // pBox_ProcImg
            // 
            this.pBox_ProcImg.Location = new System.Drawing.Point(530, 27);
            this.pBox_ProcImg.Name = "pBox_ProcImg";
            this.pBox_ProcImg.Size = new System.Drawing.Size(512, 512);
            this.pBox_ProcImg.TabIndex = 2;
            this.pBox_ProcImg.TabStop = false;
            // 
            // thresholdPanel
            // 
            this.thresholdPanel.Controls.Add(this.groupBox1);
            this.thresholdPanel.Location = new System.Drawing.Point(530, 546);
            this.thresholdPanel.Name = "thresholdPanel";
            this.thresholdPanel.Size = new System.Drawing.Size(352, 118);
            this.thresholdPanel.TabIndex = 3;
            // 
            // main_Trackbar
            // 
            this.main_Trackbar.Location = new System.Drawing.Point(6, 29);
            this.main_Trackbar.Maximum = 255;
            this.main_Trackbar.Name = "main_Trackbar";
            this.main_Trackbar.Size = new System.Drawing.Size(263, 45);
            this.main_Trackbar.TabIndex = 0;
            this.main_Trackbar.Value = 127;
            this.main_Trackbar.Scroll += new System.EventHandler(this.main_Trackbar_Scroll);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smoothingToolStripMenuItem,
            this.sharpenToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // smoothingToolStripMenuItem
            // 
            this.smoothingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neighbourhoodAveragingToolStripMenuItem,
            this.Median_false});
            this.smoothingToolStripMenuItem.Name = "smoothingToolStripMenuItem";
            this.smoothingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.smoothingToolStripMenuItem.Text = "Smoothing";
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.robertsGradientToolStripMenuItem,
            this.sharpenFiltersToolStripMenuItem,
            this.laplacianToolStripMenuItem,
            this.pointDetectionToolStripMenuItem,
            this.lineDetectionToolStripMenuItem});
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            // 
            // neighbourhoodAveragingToolStripMenuItem
            // 
            this.neighbourhoodAveragingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NeighbourhoodAveraging_true,
            this.NeighbourhoodAveraging_false});
            this.neighbourhoodAveragingToolStripMenuItem.Name = "neighbourhoodAveragingToolStripMenuItem";
            this.neighbourhoodAveragingToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.neighbourhoodAveragingToolStripMenuItem.Text = "Neighbourhood Averaging";
            // 
            // Median_false
            // 
            this.Median_false.Name = "Median_false";
            this.Median_false.Size = new System.Drawing.Size(216, 22);
            this.Median_false.Text = "Median";
            this.Median_false.Click += new System.EventHandler(this.MenuItemClicked);
            // 
            // NeighbourhoodAveraging_true
            // 
            this.NeighbourhoodAveraging_true.Name = "NeighbourhoodAveraging_true";
            this.NeighbourhoodAveraging_true.Size = new System.Drawing.Size(190, 22);
            this.NeighbourhoodAveraging_true.Text = "With Thresholding";
            this.NeighbourhoodAveraging_true.Click += new System.EventHandler(this.MenuItemClicked);
            // 
            // NeighbourhoodAveraging_false
            // 
            this.NeighbourhoodAveraging_false.Name = "NeighbourhoodAveraging_false";
            this.NeighbourhoodAveraging_false.Size = new System.Drawing.Size(190, 22);
            this.NeighbourhoodAveraging_false.Text = "Without Thresholding";
            this.NeighbourhoodAveraging_false.Click += new System.EventHandler(this.MenuItemClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblThresholdValue);
            this.groupBox1.Controls.Add(this.main_Trackbar);
            this.groupBox1.Location = new System.Drawing.Point(20, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Threshold";
            // 
            // lblThresholdValue
            // 
            this.lblThresholdValue.AutoSize = true;
            this.lblThresholdValue.Location = new System.Drawing.Point(275, 29);
            this.lblThresholdValue.Name = "lblThresholdValue";
            this.lblThresholdValue.Size = new System.Drawing.Size(25, 13);
            this.lblThresholdValue.TabIndex = 1;
            this.lblThresholdValue.Text = "127";
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
            // sharpenFiltersToolStripMenuItem
            // 
            this.sharpenFiltersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gxToolStripMenuItem,
            this.gyToolStripMenuItem,
            this.gxGyToolStripMenuItem});
            this.sharpenFiltersToolStripMenuItem.Name = "sharpenFiltersToolStripMenuItem";
            this.sharpenFiltersToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.sharpenFiltersToolStripMenuItem.Text = "Sobel Filters";
            // 
            // laplacianToolStripMenuItem
            // 
            this.laplacianToolStripMenuItem.Name = "laplacianToolStripMenuItem";
            this.laplacianToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.laplacianToolStripMenuItem.Text = "Laplacian";
            // 
            // pointDetectionToolStripMenuItem
            // 
            this.pointDetectionToolStripMenuItem.Name = "pointDetectionToolStripMenuItem";
            this.pointDetectionToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.pointDetectionToolStripMenuItem.Text = "Point Detection";
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
            // pseudoToolStripMenuItem
            // 
            this.pseudoToolStripMenuItem.Name = "pseudoToolStripMenuItem";
            this.pseudoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.pseudoToolStripMenuItem.Text = "Pseudo";
            // 
            // directToolStripMenuItem
            // 
            this.directToolStripMenuItem.Name = "directToolStripMenuItem";
            this.directToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.directToolStripMenuItem.Text = "Direct";
            // 
            // withThresholdToolStripMenuItem
            // 
            this.withThresholdToolStripMenuItem.Name = "withThresholdToolStripMenuItem";
            this.withThresholdToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.withThresholdToolStripMenuItem.Text = "With Threshold";
            // 
            // gxToolStripMenuItem
            // 
            this.gxToolStripMenuItem.Name = "gxToolStripMenuItem";
            this.gxToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gxToolStripMenuItem.Text = "Gx";
            // 
            // gyToolStripMenuItem
            // 
            this.gyToolStripMenuItem.Name = "gyToolStripMenuItem";
            this.gyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gyToolStripMenuItem.Text = "Gy";
            // 
            // gxGyToolStripMenuItem
            // 
            this.gxGyToolStripMenuItem.Name = "gxGyToolStripMenuItem";
            this.gxGyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gxGyToolStripMenuItem.Text = "Gx + Gy";
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            // 
            // inclinedToolStripMenuItem
            // 
            this.inclinedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.inclinedToolStripMenuItem.Name = "inclinedToolStripMenuItem";
            this.inclinedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inclinedToolStripMenuItem.Text = "Inclined";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "+ 45";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "- 45";
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.histogramToolStripMenuItem.Text = "Histogram";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(893, 547);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 116);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Accept";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 485);
            this.listBox1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(1060, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 512);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 709);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.thresholdPanel);
            this.Controls.Add(this.pBox_ProcImg);
            this.Controls.Add(this.pBox_Original);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainInterface";
            this.Text = "PhotoFlop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_ProcImg)).EndInit();
            this.thresholdPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_Trackbar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Inverse_false;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem Binarize_true;
        private System.Windows.Forms.ToolStripMenuItem levelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Brighten_false;
        private System.Windows.Forms.ToolStripMenuItem Darken_false;
        private System.Windows.Forms.PictureBox pBox_Original;
        private System.Windows.Forms.PictureBox pBox_ProcImg;
        private System.Windows.Forms.Panel thresholdPanel;
        private System.Windows.Forms.TrackBar main_Trackbar;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smoothingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neighbourhoodAveragingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NeighbourhoodAveraging_true;
        private System.Windows.Forms.ToolStripMenuItem NeighbourhoodAveraging_false;
        private System.Windows.Forms.ToolStripMenuItem Median_false;
        private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblThresholdValue;
        private System.Windows.Forms.ToolStripMenuItem robertsGradientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pseudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withThresholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gxGyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplacianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inclinedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

