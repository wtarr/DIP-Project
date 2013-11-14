namespace DIP_Project
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
            this.btnApply = new System.Windows.Forms.Button();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.lblX1 = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblY1 = new System.Windows.Forms.Label();
            this.lblY2 = new System.Windows.Forms.Label();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(678, 455);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // pBox
            // 
            this.pBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBox.Location = new System.Drawing.Point(13, 13);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(394, 340);
            this.pBox.TabIndex = 2;
            this.pBox.TabStop = false;
            this.pBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBox_MouseMove);
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(581, 366);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(20, 13);
            this.lblX1.TabIndex = 3;
            this.lblX1.Text = "X1";
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(581, 412);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(20, 13);
            this.lblX2.TabIndex = 4;
            this.lblX2.Text = "X2";
            // 
            // lblY1
            // 
            this.lblY1.AutoSize = true;
            this.lblY1.Location = new System.Drawing.Point(678, 366);
            this.lblY1.Name = "lblY1";
            this.lblY1.Size = new System.Drawing.Size(20, 13);
            this.lblY1.TabIndex = 5;
            this.lblY1.Text = "Y1";
            // 
            // lblY2
            // 
            this.lblY2.AutoSize = true;
            this.lblY2.Location = new System.Drawing.Point(678, 412);
            this.lblY2.Name = "lblY2";
            this.lblY2.Size = new System.Drawing.Size(20, 13);
            this.lblY2.TabIndex = 6;
            this.lblY2.Text = "Y2";
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(607, 359);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(49, 20);
            this.txtX1.TabIndex = 7;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(704, 403);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(49, 20);
            this.txtY2.TabIndex = 8;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(607, 405);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(49, 20);
            this.txtX2.TabIndex = 9;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(704, 359);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(49, 20);
            this.txtY1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(413, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ContrastStretch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 501);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.lblY2);
            this.Controls.Add(this.lblY1);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.lblX1);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.btnApply);
            this.Name = "ContrastStretch";
            this.Text = "ContrastStretch";
            this.Load += new System.EventHandler(this.ContrastStretch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label lblY1;
        private System.Windows.Forms.Label lblY2;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}