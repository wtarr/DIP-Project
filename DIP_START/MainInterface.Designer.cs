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
            this.inverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filitersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neighbourhoodAveragingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.levelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.brightenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.withThresholdingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withoutThresholdingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.inverseToolStripMenuItem,
            this.darkenToolStripMenuItem,
            this.brightenToolStripMenuItem,
            this.binarizeToolStripMenuItem,
            this.filitersToolStripMenuItem,
            this.levelsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1218, 24);
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
            // inverseToolStripMenuItem
            // 
            this.inverseToolStripMenuItem.Name = "inverseToolStripMenuItem";
            this.inverseToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.inverseToolStripMenuItem.Text = "Inverse";
            this.inverseToolStripMenuItem.Click += new System.EventHandler(this.inverseToolStripMenuItem_Click);
            // 
            // darkenToolStripMenuItem
            // 
            this.darkenToolStripMenuItem.Name = "darkenToolStripMenuItem";
            this.darkenToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.darkenToolStripMenuItem.Text = "Darken";
            this.darkenToolStripMenuItem.Click += new System.EventHandler(this.DarkenToolStripMenuItem_Click);
            // 
            // brightenToolStripMenuItem
            // 
            this.brightenToolStripMenuItem.Name = "brightenToolStripMenuItem";
            this.brightenToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.brightenToolStripMenuItem.Text = "Brighten";
            this.brightenToolStripMenuItem.Click += new System.EventHandler(this.brightenToolStripMenuItem_Click);
            // 
            // binarizeToolStripMenuItem
            // 
            this.binarizeToolStripMenuItem.Name = "binarizeToolStripMenuItem";
            this.binarizeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.binarizeToolStripMenuItem.Text = "Binarize";
            this.binarizeToolStripMenuItem.Click += new System.EventHandler(this.binarizeToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(1006, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 501);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "History";
            // 
            // filitersToolStripMenuItem
            // 
            this.filitersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smoothingToolStripMenuItem});
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
            this.smoothingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.neighbourhoodAveragingToolStripMenuItem.Click += new System.EventHandler(this.neighbourhoodAveragingToolStripMenuItem_Click);
            // 
            // medToolStripMenuItem1
            // 
            this.medToolStripMenuItem1.Name = "medToolStripMenuItem1";
            this.medToolStripMenuItem1.Size = new System.Drawing.Size(291, 22);
            this.medToolStripMenuItem1.Text = "Median";
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
            this.darkenToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.darkenToolStripMenuItem1.Text = "Darken";
            // 
            // brightenToolStripMenuItem1
            // 
            this.brightenToolStripMenuItem1.Name = "brightenToolStripMenuItem1";
            this.brightenToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.brightenToolStripMenuItem1.Text = "Brighten";
            // 
            // withThresholdingToolStripMenuItem
            // 
            this.withThresholdingToolStripMenuItem.Name = "withThresholdingToolStripMenuItem";
            this.withThresholdingToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.withThresholdingToolStripMenuItem.Text = "With Thresholding";
            // 
            // withoutThresholdingToolStripMenuItem
            // 
            this.withoutThresholdingToolStripMenuItem.Name = "withoutThresholdingToolStripMenuItem";
            this.withoutThresholdingToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.withoutThresholdingToolStripMenuItem.Text = "Without Thresholding";
            this.withoutThresholdingToolStripMenuItem.Click += new System.EventHandler(this.withoutThresholdingToolStripMenuItem_Click);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 541);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainInterface";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem darkenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightenToolStripMenuItem;
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
    }
}

