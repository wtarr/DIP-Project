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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInterface));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ContrastStretchDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pBox_Original = new System.Windows.Forms.PictureBox();
            this.pBox_ProcImg = new System.Windows.Forms.PictureBox();
            this.thresholdPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblThresholdValue = new System.Windows.Forms.Label();
            this.main_Trackbar = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.listboxHistory = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pBoxHistOrig = new System.Windows.Forms.PictureBox();
            this.pBoxHistProc = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblZoomFactor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.zoomTrackbar = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb270 = new System.Windows.Forms.RadioButton();
            this.rb180 = new System.Windows.Forms.RadioButton();
            this.rb90 = new System.Windows.Forms.RadioButton();
            this.btnClockwiseRotation = new System.Windows.Forms.Button();
            this.txtRotation = new System.Windows.Forms.TextBox();
            this.btnAntiClockwiseRotation = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rotationTimer = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_ProcImg)).BeginInit();
            this.thresholdPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_Trackbar)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHistOrig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHistProc)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackbar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.saveToolStripMenuItem});
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
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
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
            this.Laplacian_true.Click += new System.EventHandler(this.MenuItemClicked);
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
            // ContrastStretchDialog
            // 
            this.ContrastStretchDialog.Name = "ContrastStretchDialog";
            this.ContrastStretchDialog.Size = new System.Drawing.Size(104, 20);
            this.ContrastStretchDialog.Text = "Contrast Stretch";
            this.ContrastStretchDialog.Click += new System.EventHandler(this.ContrastStretchDialog_Click);
            // 
            // pBox_Original
            // 
            this.pBox_Original.Location = new System.Drawing.Point(12, 63);
            this.pBox_Original.Name = "pBox_Original";
            this.pBox_Original.Size = new System.Drawing.Size(512, 512);
            this.pBox_Original.TabIndex = 1;
            this.pBox_Original.TabStop = false;
            // 
            // pBox_ProcImg
            // 
            this.pBox_ProcImg.Location = new System.Drawing.Point(3, 3);
            this.pBox_ProcImg.Name = "pBox_ProcImg";
            this.pBox_ProcImg.Size = new System.Drawing.Size(512, 512);
            this.pBox_ProcImg.TabIndex = 2;
            this.pBox_ProcImg.TabStop = false;
            // 
            // thresholdPanel
            // 
            this.thresholdPanel.Controls.Add(this.groupBox1);
            this.thresholdPanel.Location = new System.Drawing.Point(355, 611);
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
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAccept);
            this.panel1.Location = new System.Drawing.Point(1100, 613);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 116);
            this.panel1.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(34, 68);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(34, 16);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // listboxHistory
            // 
            this.listboxHistory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listboxHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listboxHistory.FormattingEnabled = true;
            this.listboxHistory.Location = new System.Drawing.Point(12, 21);
            this.listboxHistory.Name = "listboxHistory";
            this.listboxHistory.Size = new System.Drawing.Size(133, 481);
            this.listboxHistory.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listboxHistory);
            this.groupBox2.Location = new System.Drawing.Point(1209, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 512);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "History";
            // 
            // pBoxHistOrig
            // 
            this.pBoxHistOrig.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pBoxHistOrig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBoxHistOrig.Location = new System.Drawing.Point(12, 609);
            this.pBoxHistOrig.Name = "pBoxHistOrig";
            this.pBoxHistOrig.Size = new System.Drawing.Size(260, 120);
            this.pBoxHistOrig.TabIndex = 9;
            this.pBoxHistOrig.TabStop = false;
            // 
            // pBoxHistProc
            // 
            this.pBoxHistProc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pBoxHistProc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBoxHistProc.Location = new System.Drawing.Point(782, 609);
            this.pBoxHistProc.Name = "pBoxHistProc";
            this.pBoxHistProc.Size = new System.Drawing.Size(260, 120);
            this.pBoxHistProc.TabIndex = 10;
            this.pBoxHistProc.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Location = new System.Drawing.Point(1086, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 552);
            this.panel2.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblZoomFactor);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.zoomTrackbar);
            this.groupBox4.Location = new System.Drawing.Point(3, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(111, 320);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Zoom (Original)";
            // 
            // lblZoomFactor
            // 
            this.lblZoomFactor.AutoSize = true;
            this.lblZoomFactor.Location = new System.Drawing.Point(68, 21);
            this.lblZoomFactor.Name = "lblZoomFactor";
            this.lblZoomFactor.Size = new System.Drawing.Size(13, 13);
            this.lblZoomFactor.TabIndex = 6;
            this.lblZoomFactor.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zoom factor:";
            // 
            // zoomTrackbar
            // 
            this.zoomTrackbar.Location = new System.Drawing.Point(30, 53);
            this.zoomTrackbar.Maximum = 12;
            this.zoomTrackbar.Minimum = 1;
            this.zoomTrackbar.Name = "zoomTrackbar";
            this.zoomTrackbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.zoomTrackbar.Size = new System.Drawing.Size(45, 261);
            this.zoomTrackbar.TabIndex = 4;
            this.zoomTrackbar.Value = 4;
            this.zoomTrackbar.Scroll += new System.EventHandler(this.zoomTrackbar_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb270);
            this.groupBox3.Controls.Add(this.rb180);
            this.groupBox3.Controls.Add(this.rb90);
            this.groupBox3.Controls.Add(this.btnClockwiseRotation);
            this.groupBox3.Controls.Add(this.txtRotation);
            this.groupBox3.Controls.Add(this.btnAntiClockwiseRotation);
            this.groupBox3.Location = new System.Drawing.Point(3, 356);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(111, 162);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rotate (Original)";
            // 
            // rb270
            // 
            this.rb270.AutoSize = true;
            this.rb270.Location = new System.Drawing.Point(68, 98);
            this.rb270.Name = "rb270";
            this.rb270.Size = new System.Drawing.Size(43, 17);
            this.rb270.TabIndex = 5;
            this.rb270.TabStop = true;
            this.rb270.Text = "270";
            this.rb270.UseVisualStyleBackColor = true;
            // 
            // rb180
            // 
            this.rb180.AutoSize = true;
            this.rb180.Location = new System.Drawing.Point(68, 75);
            this.rb180.Name = "rb180";
            this.rb180.Size = new System.Drawing.Size(43, 17);
            this.rb180.TabIndex = 4;
            this.rb180.TabStop = true;
            this.rb180.Text = "180";
            this.rb180.UseVisualStyleBackColor = true;
            // 
            // rb90
            // 
            this.rb90.AutoSize = true;
            this.rb90.Location = new System.Drawing.Point(68, 52);
            this.rb90.Name = "rb90";
            this.rb90.Size = new System.Drawing.Size(37, 17);
            this.rb90.TabIndex = 3;
            this.rb90.TabStop = true;
            this.rb90.Text = "90";
            this.rb90.UseVisualStyleBackColor = true;
            // 
            // btnClockwiseRotation
            // 
            this.btnClockwiseRotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClockwiseRotation.Image = ((System.Drawing.Image)(resources.GetObject("btnClockwiseRotation.Image")));
            this.btnClockwiseRotation.Location = new System.Drawing.Point(11, 19);
            this.btnClockwiseRotation.Name = "btnClockwiseRotation";
            this.btnClockwiseRotation.Size = new System.Drawing.Size(40, 50);
            this.btnClockwiseRotation.TabIndex = 0;
            this.btnClockwiseRotation.UseVisualStyleBackColor = true;
            this.btnClockwiseRotation.Click += new System.EventHandler(this.btnClockwiseRotation_Click);
            this.btnClockwiseRotation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnIncreaseRotation_MouseDown);
            this.btnClockwiseRotation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnClockwiseRotation_MouseUp);
            // 
            // txtRotation
            // 
            this.txtRotation.Enabled = false;
            this.txtRotation.Location = new System.Drawing.Point(11, 75);
            this.txtRotation.Name = "txtRotation";
            this.txtRotation.Size = new System.Drawing.Size(40, 20);
            this.txtRotation.TabIndex = 1;
            this.txtRotation.Text = "0";
            // 
            // btnAntiClockwiseRotation
            // 
            this.btnAntiClockwiseRotation.Image = ((System.Drawing.Image)(resources.GetObject("btnAntiClockwiseRotation.Image")));
            this.btnAntiClockwiseRotation.Location = new System.Drawing.Point(11, 101);
            this.btnAntiClockwiseRotation.Name = "btnAntiClockwiseRotation";
            this.btnAntiClockwiseRotation.Size = new System.Drawing.Size(40, 54);
            this.btnAntiClockwiseRotation.TabIndex = 2;
            this.btnAntiClockwiseRotation.UseVisualStyleBackColor = true;
            this.btnAntiClockwiseRotation.Click += new System.EventHandler(this.btnDecreaseRotation_Click);
            this.btnAntiClockwiseRotation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAntiClockwiseRotation_MouseDown);
            this.btnAntiClockwiseRotation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAntiClockwiseRotation_MouseUp);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.pBox_ProcImg);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(533, 61);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(550, 546);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(786, 613);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Histogram";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(14, 613);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Histogram";
            // 
            // rotationTimer
            // 
            this.rotationTimer.Tick += new System.EventHandler(this.rotationTimer_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Original";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(533, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Processed";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(14, 517);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 31);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Auto scale works only for Zoom Factor 1";
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pBoxHistProc);
            this.Controls.Add(this.pBoxHistOrig);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.thresholdPanel);
            this.Controls.Add(this.pBox_Original);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainInterface";
            this.Text = "Foto Flop";
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
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHistOrig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHistProc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackbar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ListBox listboxHistory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem HistogramEqualisation_false;
        private System.Windows.Forms.ToolStripMenuItem ContrastStretchDialog;
        private System.Windows.Forms.PictureBox pBoxHistOrig;
        private System.Windows.Forms.PictureBox pBoxHistProc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar zoomTrackbar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClockwiseRotation;
        private System.Windows.Forms.TextBox txtRotation;
        private System.Windows.Forms.Button btnAntiClockwiseRotation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.RadioButton rb270;
        private System.Windows.Forms.RadioButton rb180;
        private System.Windows.Forms.RadioButton rb90;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblZoomFactor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer rotationTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}

