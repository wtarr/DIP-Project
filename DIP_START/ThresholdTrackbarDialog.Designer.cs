﻿namespace DIP_START
{
    partial class ThresholdTrackbarDialog
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
            this.Trackbar_Threshold = new System.Windows.Forms.TrackBar();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox_Threshold = new System.Windows.Forms.GroupBox();
            this.lbl_Value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar_Threshold)).BeginInit();
            this.groupBox_Threshold.SuspendLayout();
            this.SuspendLayout();
            // 
            // Trackbar_Threshold
            // 
            this.Trackbar_Threshold.Location = new System.Drawing.Point(6, 48);
            this.Trackbar_Threshold.Maximum = 255;
            this.Trackbar_Threshold.Name = "Trackbar_Threshold";
            this.Trackbar_Threshold.Size = new System.Drawing.Size(404, 45);
            this.Trackbar_Threshold.TabIndex = 0;
            this.Trackbar_Threshold.Value = 127;
            this.Trackbar_Threshold.Scroll += new System.EventHandler(this.Trackbar_Threshold_Scroll);
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(254, 103);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(75, 23);
            this.btn_Apply.TabIndex = 1;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(335, 103);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // groupBox_Threshold
            // 
            this.groupBox_Threshold.Controls.Add(this.lbl_Value);
            this.groupBox_Threshold.Controls.Add(this.Trackbar_Threshold);
            this.groupBox_Threshold.Controls.Add(this.btn_Cancel);
            this.groupBox_Threshold.Controls.Add(this.btn_Apply);
            this.groupBox_Threshold.Location = new System.Drawing.Point(12, 484);
            this.groupBox_Threshold.Name = "groupBox_Threshold";
            this.groupBox_Threshold.Size = new System.Drawing.Size(447, 132);
            this.groupBox_Threshold.TabIndex = 4;
            this.groupBox_Threshold.TabStop = false;
            this.groupBox_Threshold.Text = "Threshold";
            // 
            // lbl_Value
            // 
            this.lbl_Value.AutoSize = true;
            this.lbl_Value.Location = new System.Drawing.Point(416, 48);
            this.lbl_Value.Name = "lbl_Value";
            this.lbl_Value.Size = new System.Drawing.Size(25, 13);
            this.lbl_Value.TabIndex = 4;
            this.lbl_Value.Text = "127";
            // 
            // ThresholdTrackbarDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 626);
            this.Controls.Add(this.groupBox_Threshold);
            this.Name = "ThresholdTrackbarDialog";
            this.Text = "Title set at runtime";
            this.Load += new System.EventHandler(this.BininarizationSettingsDialog_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ThresholdTrackbarDialog_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar_Threshold)).EndInit();
            this.groupBox_Threshold.ResumeLayout(false);
            this.groupBox_Threshold.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar Trackbar_Threshold;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.GroupBox groupBox_Threshold;
        private System.Windows.Forms.Label lbl_Value;
    }
}