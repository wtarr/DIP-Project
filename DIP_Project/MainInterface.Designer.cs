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
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neighbourhoodAveragingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NeighbourhoodAveraging_true = new System.Windows.Forms.ToolStripMenuItem();
            this.NeighbourhoodAveraging_false = new System.Windows.Forms.ToolStripMenuItem();
            this.Median_false = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robertsGradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RobertsGradientWithPseudoColor_true = new System.Windows.Forms.ToolStripMenuItem();
            this.RobertsGradientDirect_false = new System.Windows.Forms.ToolStripMenuItem();
            this.RobertsGradientWithThresholding_true = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SobelGx_true = new System.Windows.Forms.ToolStripMenuItem();
            this.SobelGy_true = new System.Windows.Forms.ToolStripMenuItem();
            this.SobelGxGy_true = new System.Windows.Forms.ToolStripMenuItem();
            this.Laplacian_true = new System.Windows.Forms.ToolStripMenuItem();
            this.PointDetection_true = new System.Windows.Forms.ToolStripMenuItem();
            this.lineDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HorizontalLine_true = new System.Windows.Forms.ToolStripMenuItem();
            this.VerticalLine_true = new System.Windows.Forms.ToolStripMenuItem();
            this.inclinedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pos45DegreeLine_true = new System.Windows.Forms.ToolStripMenuItem();
            this.Negative45DegreeLine_true = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HistogramEqualisation_false = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pBox_Original = new System.Windows.Forms.PictureBox();
            this.pBox_ProcImg = new System.Windows.Forms.PictureBox();
            this.thresholdPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblThresholdValue = new System.Windows.Forms.Label();
            this.main_Trackbar = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listboxHistory = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelHistogramOriginal = new System.Windows.Forms.Panel();
            this.panelHistogramEqualised = new System.Windows.Forms.Panel();
            this.ContrastStretchDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_ProcImg)).BeginInit();
            this.thresholdPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_Trackbar)).BeginInit();
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
            this.histogramToolStripMenuItem,
            this.ContrastStretchDialog});
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
            this.smoothingToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.smoothingToolStripMenuItem.Text = "Smoothing";
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
            // Median_false
            // 
            this.Median_false.Name = "Median_false";
            this.Median_false.Size = new System.Drawing.Size(216, 22);
            this.Median_false.Text = "Median";
            this.Median_false.Click += new System.EventHandler(this.MenuItemClicked);
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.robertsGradientToolStripMenuItem,
            this.sharpenFiltersToolStripMenuItem,
            this.Laplacian_true,
            this.PointDetection_true,
            this.lineDetectionToolStripMenuItem});
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            // 
            // robertsGradientToolStripMenuItem
            // 
            this.robertsGradientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RobertsGradientWithPseudoColor_true,
            this.RobertsGradientDirect_false,
            this.RobertsGradientWithThresholding_true});
            this.robertsGradientToolStripMenuItem.Name = "robertsGradientToolStripMenuItem";
            this.robertsGradientToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.robertsGradientToolStripMenuItem.Text = "Roberts Gradient";
            // 
            // RobertsGradientWithPseudoColor_true
            // 
            this.RobertsGradientWithPseudoColor_true.Name = "RobertsGradientWithPseudoColor_true";
            this.RobertsGradientWithPseudoColor_true.Size = new System.Drawing.Size(155, 22);
            this.RobertsGradientWithPseudoColor_true.Text = "Pseudo";
            this.RobertsGradientWithPseudoColor_true.Click += new System.EventHandler(this.MenuItemClicked);
            // 
            // RobertsGradientDirect_false
            // 
            this.RobertsGradientDirect_false.Name = "RobertsGradientDirect_false";
            this.RobertsGradientDirect_false.Size = new System.Drawing.Size(155, 22);
            this.RobertsGradientDirect_false.Text = "Direct";
            this.RobertsGradientDirect_false.Click += new System.EventHandler(this.MenuItemClicked);
            // 
            // RobertsGradientWithThresholding_true
            // 
            this.RobertsGradientWithThresholding_true.Name = "RobertsGradientWithThresholding_true";
            this.RobertsGradientWithThresholding_true.Size = new System.Drawing.Size(155, 22);
            this.RobertsGradientWithThresholding_true.Text = "With Threshold";
            this.RobertsGradientWithThresholding_true.Click += new System.EventHandler(this.MenuItemClicked);
            // 
            // sharpenFiltersToolStripMenuItem
            // 
            this.sharpenFiltersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SobelGx_true,
            this.SobelGy_true,
            this.SobelGxGy_true});
            this.sharpenFiltersToolStripMenuItem.Name = "sharpenFiltersToolStripMenuItem";
            this.sharpenFiltersToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.sharpenFiltersToolStripMenuItem.Text = "Sobel Filters";
            // 
            // SobelGx_true
            // 
            this.SobelGx_true.Name = "SobelGx_true";
            this.SobelGx_true.Size = new System.Drawing.Size(115, 22);
            this.SobelGx_true.Text = "Gx";
            this.SobelGx_true.Click += new System.EventHandler(this.MenuItemClicked);
            // 
            // SobelGy_true
            // 
            this.SobelGy_true.Name = "SobelGy_true";
            this.SobelGy_true.Size = new System.Drawing.Size(115, 22);
            this.SobelGy_true.Text = "Gy";
            this.SobelGy_true.Click += new System.EventHandler(this.MenuItemClicked);
            // 
            // SobelGxGy_true
            // 
            this.SobelGxGy_true.Name = "SobelGxGy_true";
            this.SobelGxGy_true.Size = new System.Drawing.Size(115, 22);
            this.SobelGxGy_true.Text = "Gx + Gy";
            this.SobelGxGy_true.Click += new System.EventHandler(this.MenuItemClicked);
            // 
            // Laplacian_true
            // 
            this.Laplacian_true.Name = "Laplacian_true";
            this.Laplacian_true.Size = new System.Drawing.Size(162, 22);
            this.Laplacian_true.Text = "Laplacian";
            // 
            // PointDetection_true
            // 
            this.PointDetection_true.Name = "PointDetection_true";
            this.PointDetection_true.Size = new System.Drawing.Size(162, 22);
            this.PointDetection_true.Text = "Point Detection";
            this.PointDetection_true.Click += new System.EventHandler(this.MenuItemClicked);
            // 
            // lineDetectionToolStripMenuItem
            // 
            this.lineDetectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HorizontalLine_true,
            this.VerticalLine_true,
            this.inclinedToolStripMenuItem});
            this.lineDetectionToolStripMenuItem.Name = "lineDetectionToolStripMenuItem";
            this.lineDetectionToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.lineDetectionToolStripMenuItem.Text = "Line Detection";
            // 
            // HorizontalLine_true
            // 
            this.HorizontalLine_true.Name = "HorizontalLine_true";
            this.HorizontalLine_true.Size = new System.Drawing.Size(129, 22);
            this.HorizontalLine_true.Text = "Horizontal";
            this.HorizontalLine_true.Click += new System.EventHandler(this.MenuItemClicked);
            // 
            // VerticalLine_true
            // 
            this.VerticalLine_true.Name = "VerticalLine_true";
            this.VerticalLine_true.Size = new System.Drawing.Size(129, 22);
            this.VerticalLine_true.Text = "Vertical";
            this.VerticalLine_true.Click += new System.EventHandler(this.MenuItemClicked);
            // 
            // inclinedToolStripMenuItem
            // 
            this.inclinedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pos45DegreeLine_true,
            this.Negative45DegreeLine_true});
            this.inclinedToolStripMenuItem.Name = "inclinedToolStripMenuItem";
            this.inclinedToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.inclinedToolStripMenuItem.Text = "Inclined";
            // 
            // Pos45DegreeLine_true
            // 
            this.Pos45DegreeLine_true.Name = "Pos45DegreeLine_true";
            this.Pos45DegreeLine_true.Size = new System.Drawing.Size(97, 22);
            this.Pos45DegreeLine_true.Text = "+ 45";
            this.Pos45DegreeLine_true.Click += new System.EventHandler(this.MenuItemClicked);
            // 
            // Negative45DegreeLine_true
            // 
            this.Negative45DegreeLine_true.Name = "Negative45DegreeLine_true";
            this.Negative45DegreeLine_true.Size = new System.Drawing.Size(97, 22);
            this.Negative45DegreeLine_true.Text = "- 45";
            this.Negative45DegreeLine_true.Click += new System.EventHandler(this.MenuItemClicked);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HistogramEqualisation_false});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.histogramToolStripMenuItem.Text = "Histogram";
            // 
            // HistogramEqualisation_false
            // 
            this.HistogramEqualisation_false.Name = "HistogramEqualisation_false";
            this.HistogramEqualisation_false.Size = new System.Drawing.Size(197, 22);
            this.HistogramEqualisation_false.Text = "Histogram Equalisation";
            this.HistogramEqualisation_false.Click += new System.EventHandler(this.MenuItemClicked);
            // 
            // pBox_Original
            // 
            this.pBox_Original.Location = new System.Drawing.Point(12, 61);
            this.pBox_Original.Name = "pBox_Original";
            this.pBox_Original.Size = new System.Drawing.Size(512, 512);
            this.pBox_Original.TabIndex = 1;
            this.pBox_Original.TabStop = false;
            // 
            // pBox_ProcImg
            // 
            this.pBox_ProcImg.Location = new System.Drawing.Point(530, 61);
            this.pBox_ProcImg.Name = "pBox_ProcImg";
            this.pBox_ProcImg.Size = new System.Drawing.Size(512, 512);
            this.pBox_ProcImg.TabIndex = 2;
            this.pBox_ProcImg.TabStop = false;
            // 
            // thresholdPanel
            // 
            this.thresholdPanel.Controls.Add(this.groupBox1);
            this.thresholdPanel.Location = new System.Drawing.Point(355, 596);
            this.thresholdPanel.Name = "thresholdPanel";
            this.thresholdPanel.Size = new System.Drawing.Size(352, 118);
            this.thresholdPanel.TabIndex = 3;
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
            // main_Trackbar
            // 
            this.main_Trackbar.Location = new System.Drawing.Point(6, 29);
            this.main_Trackbar.Maximum = 255;
            this.main_Trackbar.Name = "main_Trackbar";
            this.main_Trackbar.Size = new System.Drawing.Size(263, 45);
            this.main_Trackbar.TabIndex = 0;
            this.main_Trackbar.Value = 127;
            this.main_Trackbar.Scroll += new System.EventHandler(this.main_Trackbar_Scroll);
            this.main_Trackbar.ValueChanged += new System.EventHandler(this.main_Trackbar_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1100, 613);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 116);
            this.panel1.TabIndex = 4;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Accept";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listboxHistory
            // 
            this.listboxHistory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listboxHistory.FormattingEnabled = true;
            this.listboxHistory.Location = new System.Drawing.Point(6, 19);
            this.listboxHistory.Name = "listboxHistory";
            this.listboxHistory.Size = new System.Drawing.Size(176, 485);
            this.listboxHistory.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listboxHistory);
            this.groupBox2.Location = new System.Drawing.Point(1060, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 512);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "History";
            // 
            // panelHistogramOriginal
            // 
            this.panelHistogramOriginal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelHistogramOriginal.Location = new System.Drawing.Point(13, 596);
            this.panelHistogramOriginal.Name = "panelHistogramOriginal";
            this.panelHistogramOriginal.Size = new System.Drawing.Size(255, 120);
            this.panelHistogramOriginal.TabIndex = 7;
            // 
            // panelHistogramEqualised
            // 
            this.panelHistogramEqualised.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelHistogramEqualised.Location = new System.Drawing.Point(787, 596);
            this.panelHistogramEqualised.Name = "panelHistogramEqualised";
            this.panelHistogramEqualised.Size = new System.Drawing.Size(255, 121);
            this.panelHistogramEqualised.TabIndex = 8;
            // 
            // ContrastStretchDialog
            // 
            this.ContrastStretchDialog.Name = "ContrastStretchDialog";
            this.ContrastStretchDialog.Size = new System.Drawing.Size(104, 20);
            this.ContrastStretchDialog.Text = "Contrast Stretch";
            this.ContrastStretchDialog.Click += new System.EventHandler(this.ContrastStretchDialog_Click);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 739);
            this.Controls.Add(this.panelHistogramEqualised);
            this.Controls.Add(this.panelHistogramOriginal);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_Trackbar)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem RobertsGradientWithPseudoColor_true;
        private System.Windows.Forms.ToolStripMenuItem RobertsGradientDirect_false;
        private System.Windows.Forms.ToolStripMenuItem RobertsGradientWithThresholding_true;
        private System.Windows.Forms.ToolStripMenuItem sharpenFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SobelGx_true;
        private System.Windows.Forms.ToolStripMenuItem SobelGy_true;
        private System.Windows.Forms.ToolStripMenuItem SobelGxGy_true;
        private System.Windows.Forms.ToolStripMenuItem Laplacian_true;
        private System.Windows.Forms.ToolStripMenuItem PointDetection_true;
        private System.Windows.Forms.ToolStripMenuItem lineDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HorizontalLine_true;
        private System.Windows.Forms.ToolStripMenuItem VerticalLine_true;
        private System.Windows.Forms.ToolStripMenuItem inclinedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Pos45DegreeLine_true;
        private System.Windows.Forms.ToolStripMenuItem Negative45DegreeLine_true;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listboxHistory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem HistogramEqualisation_false;
        private System.Windows.Forms.Panel panelHistogramOriginal;
        private System.Windows.Forms.Panel panelHistogramEqualised;
        private System.Windows.Forms.ToolStripMenuItem ContrastStretchDialog;
    }
}

