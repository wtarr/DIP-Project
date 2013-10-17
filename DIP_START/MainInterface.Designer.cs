using System;

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
            this.Levels_Darken_false = new System.Windows.Forms.ToolStripMenuItem();
            this.Levels_Brighten_false = new System.Windows.Forms.ToolStripMenuItem();
            this.InverseVideo_Inverse_false = new System.Windows.Forms.ToolStripMenuItem();
            this.Binarization_Binarize_true = new System.Windows.Forms.ToolStripMenuItem();
            this.filitersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neighbourhoodAveragingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SmoothingFilters_NeibhourhoodAveragingWithThresholding_true = new System.Windows.Forms.ToolStripMenuItem();
            this.SmoothingFilters_NeibhourhoodAveraging_false = new System.Windows.Forms.ToolStripMenuItem();
            this.SmoothingFilters_MedianFiltering_false = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robertsGradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RobertsGradient_RobertsGradientWithPseudoColor_true = new System.Windows.Forms.ToolStripMenuItem();
            this.RobertsGradient_RobertsGradientDirect_false = new System.Windows.Forms.ToolStripMenuItem();
            this.RobertsGradient_RobertsGradientWithThresholding_true = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SharpenFilters_SobelGx_true = new System.Windows.Forms.ToolStripMenuItem();
            this.SharpenFilters_SobelGy_true = new System.Windows.Forms.ToolStripMenuItem();
            this.SharpenFilters_SobelGxGy_true = new System.Windows.Forms.ToolStripMenuItem();
            this.SharpenFilters_Laplacian_true = new System.Windows.Forms.ToolStripMenuItem();
            this.SharpenFilters_PointDetection_true = new System.Windows.Forms.ToolStripMenuItem();
            this.lineDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SharpenFilters_HorizontalLine_true = new System.Windows.Forms.ToolStripMenuItem();
            this.SharpenFilters_VerticalLine_true = new System.Windows.Forms.ToolStripMenuItem();
            this.SharpenFilters_Positive45DegreeLine_true = new System.Windows.Forms.ToolStripMenuItem();
            this.SharpenFilters_Pos45DegreeLine_true = new System.Windows.Forms.ToolStripMenuItem();
            this.SharpenFilters_Negative45DegreeLine_true = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Histogram_EqualisedHistogram_false = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HistoryList = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.levelsToolStripMenuItem,
            this.InverseVideo_Inverse_false,
            this.Binarization_Binarize_true,
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
            this.Levels_Darken_false,
            this.Levels_Brighten_false});
            this.levelsToolStripMenuItem.Name = "levelsToolStripMenuItem";
            this.levelsToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.levelsToolStripMenuItem.Text = "Levels";
            // 
            // Levels_Darken_false
            // 
            this.Levels_Darken_false.Name = "Levels_Darken_false";
            this.Levels_Darken_false.Size = new System.Drawing.Size(119, 22);
            this.Levels_Darken_false.Text = "Darken";
            this.Levels_Darken_false.Click += new System.EventHandler(this.MenuItem_Clicked);
            // 
            // Levels_Brighten_false
            // 
            this.Levels_Brighten_false.Name = "Levels_Brighten_false";
            this.Levels_Brighten_false.Size = new System.Drawing.Size(119, 22);
            this.Levels_Brighten_false.Text = "Brighten";
            this.Levels_Brighten_false.Click += new System.EventHandler(this.MenuItem_Clicked);
            // 
            // InverseVideo_Inverse_false
            // 
            this.InverseVideo_Inverse_false.Name = "InverseVideo_Inverse_false";
            this.InverseVideo_Inverse_false.Size = new System.Drawing.Size(56, 20);
            this.InverseVideo_Inverse_false.Text = "Inverse";
            this.InverseVideo_Inverse_false.Click += new System.EventHandler(this.MenuItem_Clicked);
            // 
            // Binarization_Binarize_true
            // 
            this.Binarization_Binarize_true.Name = "Binarization_Binarize_true";
            this.Binarization_Binarize_true.Size = new System.Drawing.Size(60, 20);
            this.Binarization_Binarize_true.Text = "Binarize";
            this.Binarization_Binarize_true.Click += new System.EventHandler(this.MenuItem_Clicked);
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
            this.SmoothingFilters_MedianFiltering_false});
            this.smoothingToolStripMenuItem.Name = "smoothingToolStripMenuItem";
            this.smoothingToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.smoothingToolStripMenuItem.Text = "Smoothing";
            // 
            // neighbourhoodAveragingToolStripMenuItem
            // 
            this.neighbourhoodAveragingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SmoothingFilters_NeibhourhoodAveragingWithThresholding_true,
            this.SmoothingFilters_NeibhourhoodAveraging_false});
            this.neighbourhoodAveragingToolStripMenuItem.Name = "neighbourhoodAveragingToolStripMenuItem";
            this.neighbourhoodAveragingToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.neighbourhoodAveragingToolStripMenuItem.Text = "Neighbourhood Averaging";
            // 
            // SmoothingFilters_NeibhourhoodAveragingWithThresholding_true
            // 
            this.SmoothingFilters_NeibhourhoodAveragingWithThresholding_true.Name = "SmoothingFilters_NeibhourhoodAveragingWithThresholding_true";
            this.SmoothingFilters_NeibhourhoodAveragingWithThresholding_true.Size = new System.Drawing.Size(190, 22);
            this.SmoothingFilters_NeibhourhoodAveragingWithThresholding_true.Text = "With Thresholding";
            this.SmoothingFilters_NeibhourhoodAveragingWithThresholding_true.Click += new System.EventHandler(this.MenuItem_Clicked);
            // 
            // SmoothingFilters_NeibhourhoodAveraging_false
            // 
            this.SmoothingFilters_NeibhourhoodAveraging_false.Name = "SmoothingFilters_NeibhourhoodAveraging_false";
            this.SmoothingFilters_NeibhourhoodAveraging_false.Size = new System.Drawing.Size(190, 22);
            this.SmoothingFilters_NeibhourhoodAveraging_false.Text = "Without Thresholding";
            this.SmoothingFilters_NeibhourhoodAveraging_false.Click += new System.EventHandler(this.MenuItem_Clicked);
            // 
            // SmoothingFilters_MedianFiltering_false
            // 
            this.SmoothingFilters_MedianFiltering_false.Name = "SmoothingFilters_MedianFiltering_false";
            this.SmoothingFilters_MedianFiltering_false.Size = new System.Drawing.Size(216, 22);
            this.SmoothingFilters_MedianFiltering_false.Text = "Median";
            this.SmoothingFilters_MedianFiltering_false.Click += new System.EventHandler(this.MenuItem_Clicked);
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.robertsGradientToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.SharpenFilters_Laplacian_true,
            this.SharpenFilters_PointDetection_true,
            this.lineDetectionToolStripMenuItem});
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            // 
            // robertsGradientToolStripMenuItem
            // 
            this.robertsGradientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RobertsGradient_RobertsGradientWithPseudoColor_true,
            this.RobertsGradient_RobertsGradientDirect_false,
            this.RobertsGradient_RobertsGradientWithThresholding_true});
            this.robertsGradientToolStripMenuItem.Name = "robertsGradientToolStripMenuItem";
            this.robertsGradientToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.robertsGradientToolStripMenuItem.Text = "Roberts Gradient";
            // 
            // RobertsGradient_RobertsGradientWithPseudoColor_true
            // 
            this.RobertsGradient_RobertsGradientWithPseudoColor_true.Name = "RobertsGradient_RobertsGradientWithPseudoColor_true";
            this.RobertsGradient_RobertsGradientWithPseudoColor_true.Size = new System.Drawing.Size(155, 22);
            this.RobertsGradient_RobertsGradientWithPseudoColor_true.Text = "Pseudo";
            this.RobertsGradient_RobertsGradientWithPseudoColor_true.Click += new System.EventHandler(this.MenuItem_Clicked);
            // 
            // RobertsGradient_RobertsGradientDirect_false
            // 
            this.RobertsGradient_RobertsGradientDirect_false.Name = "RobertsGradient_RobertsGradientDirect_false";
            this.RobertsGradient_RobertsGradientDirect_false.Size = new System.Drawing.Size(155, 22);
            this.RobertsGradient_RobertsGradientDirect_false.Text = "Direct";
            this.RobertsGradient_RobertsGradientDirect_false.Click += new System.EventHandler(this.MenuItem_Clicked);
            // 
            // RobertsGradient_RobertsGradientWithThresholding_true
            // 
            this.RobertsGradient_RobertsGradientWithThresholding_true.Name = "RobertsGradient_RobertsGradientWithThresholding_true";
            this.RobertsGradient_RobertsGradientWithThresholding_true.Size = new System.Drawing.Size(155, 22);
            this.RobertsGradient_RobertsGradientWithThresholding_true.Text = "With Threshold";
            this.RobertsGradient_RobertsGradientWithThresholding_true.Click += new System.EventHandler(this.MenuItem_Clicked);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SharpenFilters_SobelGx_true,
            this.SharpenFilters_SobelGy_true,
            this.SharpenFilters_SobelGxGy_true});
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.sobelToolStripMenuItem.Text = "SharpenFilters";
            // 
            // SharpenFilters_SobelGx_true
            // 
            this.SharpenFilters_SobelGx_true.Name = "SharpenFilters_SobelGx_true";
            this.SharpenFilters_SobelGx_true.Size = new System.Drawing.Size(115, 22);
            this.SharpenFilters_SobelGx_true.Text = "Gx";
            this.SharpenFilters_SobelGx_true.Click += new System.EventHandler(this.MenuItem_Clicked);
            // 
            // SharpenFilters_SobelGy_true
            // 
            this.SharpenFilters_SobelGy_true.Name = "SharpenFilters_SobelGy_true";
            this.SharpenFilters_SobelGy_true.Size = new System.Drawing.Size(115, 22);
            this.SharpenFilters_SobelGy_true.Text = "Gy";
            this.SharpenFilters_SobelGy_true.Click += new System.EventHandler(this.MenuItem_Clicked);
            // 
            // SharpenFilters_SobelGxGy_true
            // 
            this.SharpenFilters_SobelGxGy_true.Name = "SharpenFilters_SobelGxGy_true";
            this.SharpenFilters_SobelGxGy_true.Size = new System.Drawing.Size(115, 22);
            this.SharpenFilters_SobelGxGy_true.Text = "Gx + Gy";
            this.SharpenFilters_SobelGxGy_true.Click += new System.EventHandler(this.MenuItem_Clicked);
            // 
            // SharpenFilters_Laplacian_true
            // 
            this.SharpenFilters_Laplacian_true.Name = "SharpenFilters_Laplacian_true";
            this.SharpenFilters_Laplacian_true.Size = new System.Drawing.Size(162, 22);
            this.SharpenFilters_Laplacian_true.Text = "Laplacian";
            this.SharpenFilters_Laplacian_true.Click += new System.EventHandler(this.MenuItem_Clicked);
            // 
            // SharpenFilters_PointDetection_true
            // 
            this.SharpenFilters_PointDetection_true.Name = "SharpenFilters_PointDetection_true";
            this.SharpenFilters_PointDetection_true.Size = new System.Drawing.Size(162, 22);
            this.SharpenFilters_PointDetection_true.Text = "Point Detection";
            this.SharpenFilters_PointDetection_true.Click += new System.EventHandler(this.MenuItem_Clicked);
            // 
            // lineDetectionToolStripMenuItem
            // 
            this.lineDetectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SharpenFilters_HorizontalLine_true,
            this.SharpenFilters_VerticalLine_true,
            this.SharpenFilters_Positive45DegreeLine_true});
            this.lineDetectionToolStripMenuItem.Name = "lineDetectionToolStripMenuItem";
            this.lineDetectionToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.lineDetectionToolStripMenuItem.Text = "Line Detection";
            // 
            // SharpenFilters_HorizontalLine_true
            // 
            this.SharpenFilters_HorizontalLine_true.Name = "SharpenFilters_HorizontalLine_true";
            this.SharpenFilters_HorizontalLine_true.Size = new System.Drawing.Size(129, 22);
            this.SharpenFilters_HorizontalLine_true.Text = "Horizontal";
            this.SharpenFilters_HorizontalLine_true.Click += new System.EventHandler(this.MenuItem_Clicked);
            // 
            // SharpenFilters_VerticalLine_true
            // 
            this.SharpenFilters_VerticalLine_true.Name = "SharpenFilters_VerticalLine_true";
            this.SharpenFilters_VerticalLine_true.Size = new System.Drawing.Size(129, 22);
            this.SharpenFilters_VerticalLine_true.Text = "Vertical";
            this.SharpenFilters_VerticalLine_true.Click += new System.EventHandler(this.MenuItem_Clicked);
            // 
            // SharpenFilters_Positive45DegreeLine_true
            // 
            this.SharpenFilters_Positive45DegreeLine_true.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SharpenFilters_Pos45DegreeLine_true,
            this.SharpenFilters_Negative45DegreeLine_true});
            this.SharpenFilters_Positive45DegreeLine_true.Name = "SharpenFilters_Positive45DegreeLine_true";
            this.SharpenFilters_Positive45DegreeLine_true.Size = new System.Drawing.Size(129, 22);
            this.SharpenFilters_Positive45DegreeLine_true.Text = "Inclined";
            // 
            // SharpenFilters_Pos45DegreeLine_true
            // 
            this.SharpenFilters_Pos45DegreeLine_true.Name = "SharpenFilters_Pos45DegreeLine_true";
            this.SharpenFilters_Pos45DegreeLine_true.Size = new System.Drawing.Size(97, 22);
            this.SharpenFilters_Pos45DegreeLine_true.Text = "+ 45";
            this.SharpenFilters_Pos45DegreeLine_true.Click += new System.EventHandler(this.MenuItem_Clicked);
            // 
            // SharpenFilters_Negative45DegreeLine_true
            // 
            this.SharpenFilters_Negative45DegreeLine_true.Name = "SharpenFilters_Negative45DegreeLine_true";
            this.SharpenFilters_Negative45DegreeLine_true.Size = new System.Drawing.Size(97, 22);
            this.SharpenFilters_Negative45DegreeLine_true.Text = "- 45";
            this.SharpenFilters_Negative45DegreeLine_true.Click += new System.EventHandler(this.MenuItem_Clicked);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Histogram_EqualisedHistogram_false});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.histogramToolStripMenuItem.Text = "Histogram";
            // 
            // Histogram_EqualisedHistogram_false
            // 
            this.Histogram_EqualisedHistogram_false.Name = "Histogram_EqualisedHistogram_false";
            this.Histogram_EqualisedHistogram_false.Size = new System.Drawing.Size(152, 22);
            this.Histogram_EqualisedHistogram_false.Text = "Equalise";
            this.Histogram_EqualisedHistogram_false.Click += new System.EventHandler(this.MenuItem_Clicked);
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
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainInterface";
            this.Text = "Photochop";
            this.SizeChanged += new System.EventHandler(this.MainInterface_SizeChanged);
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
        private System.Windows.Forms.ToolStripMenuItem InverseVideo_Inverse_false;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem Binarization_Binarize_true;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem filitersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smoothingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neighbourhoodAveragingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SmoothingFilters_MedianFiltering_false;
        private System.Windows.Forms.ToolStripMenuItem levelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Levels_Darken_false;
        private System.Windows.Forms.ToolStripMenuItem Levels_Brighten_false;
        private System.Windows.Forms.ToolStripMenuItem SmoothingFilters_NeibhourhoodAveragingWithThresholding_true;
        private System.Windows.Forms.ToolStripMenuItem SmoothingFilters_NeibhourhoodAveraging_false;
        private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robertsGradientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RobertsGradient_RobertsGradientWithPseudoColor_true;
        private System.Windows.Forms.ToolStripMenuItem RobertsGradient_RobertsGradientDirect_false;
        private System.Windows.Forms.ToolStripMenuItem SharpenFilters_SobelGx_true;
        private System.Windows.Forms.ToolStripMenuItem SharpenFilters_SobelGy_true;
        private System.Windows.Forms.ToolStripMenuItem SharpenFilters_SobelGxGy_true;
        private System.Windows.Forms.ToolStripMenuItem RobertsGradient_RobertsGradientWithThresholding_true;
        private System.Windows.Forms.ToolStripMenuItem SharpenFilters_Laplacian_true;
        private System.Windows.Forms.ToolStripMenuItem SharpenFilters_PointDetection_true;
        private System.Windows.Forms.ToolStripMenuItem lineDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SharpenFilters_HorizontalLine_true;
        private System.Windows.Forms.ToolStripMenuItem SharpenFilters_VerticalLine_true;
        private System.Windows.Forms.ToolStripMenuItem SharpenFilters_Positive45DegreeLine_true;
        private System.Windows.Forms.ToolStripMenuItem SharpenFilters_Pos45DegreeLine_true;
        private System.Windows.Forms.ToolStripMenuItem SharpenFilters_Negative45DegreeLine_true;
        private System.Windows.Forms.ListBox HistoryList;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Histogram_EqualisedHistogram_false;
    }
}

