﻿namespace DIP_Project
{
    partial class ContrastStretch
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
            this.contrastStretchPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contrastStretchPanel
            // 
            this.contrastStretchPanel.BackColor = System.Drawing.SystemColors.Control;
            this.contrastStretchPanel.Location = new System.Drawing.Point(38, 47);
            this.contrastStretchPanel.Name = "contrastStretchPanel";
            this.contrastStretchPanel.Size = new System.Drawing.Size(334, 292);
            this.contrastStretchPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContrastStretch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contrastStretchPanel);
            this.Name = "ContrastStretch";
            this.Text = "ContrastStretch";
            this.Load += new System.EventHandler(this.ContrastStretch_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contrastStretchPanel;
        private System.Windows.Forms.Button button1;
    }
}