using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DIP_Project;

namespace DIP_START
{
    public partial class MainInterface : Form
    {
        //public static int ThresholdValue;
        private const int ThresholdDefault = 127, ThresholdDefaultMaximum = 255;
        private Graphics _g;
        private readonly ImageProcessing _imgProcessing;
        private Process _currentProcess;
        public Bitmap OriginalImage, ProcImage;
        private int rotation;
        

        public MainInterface()
        {
            //ThresholdValue = 127;
            InitializeComponent();
            OriginalImage = null;
            ProcImage = null;
            _g = CreateGraphics();
            _imgProcessing = new ImageProcessing();
            _imgProcessing.MaxValueChanged += new EventHandler(thesholdMax_Change);
            thresholdPanel.Enabled = false;
           

        }

        private void thesholdMax_Change(object sender, EventArgs e)
        {
            var s = e as ThresholdEventArgs;
            main_Trackbar.Maximum = s.Max;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (OriginalImage != null)
            {

            }

        }

        //-------------------------------------------------------
        //-----------------OPEN IMAGE----------------------------
        //-------------------------------------------------------

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoadBitmapFromFile();
        }

        private void LoadBitmapFromFile()
        {
            // show the openFile dialog box            
            Graphics g = this.CreateGraphics();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OriginalImage = new Bitmap(openFileDialog1.FileName);
            }
            pBox_Original.Image = OriginalImage;
            //Rectangle r = new Rectangle(10, 50, original_image.Width, original_image.Height);
            //g.DrawImage(original_image, r);
            if (OriginalImage != null)
                DrawHistogram(OriginalImage, pBoxHistOrig);
        }

        //-------------------------------------------------------
        //-----------------EXIT APPLICATION----------------------
        //-------------------------------------------------------

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Dispose();
            Application.Exit();
        }

        private void MenuItemClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem itemClicked = sender as ToolStripMenuItem;
            main_Trackbar.Value = ThresholdDefault;

            if (OriginalImage != null)
            {
               

                String[] array = itemClicked.Name.Split('_');
                _currentProcess = (Process)Enum.Parse(typeof (Process), array[0]);

                thresholdPanel.Enabled = Boolean.Parse(array[1]);

                ProcImage = _imgProcessing.Execute((Process) _currentProcess, OriginalImage, main_Trackbar.Value);
                pBox_ProcImg.Image = ProcImage;
                if (ProcImage != null)
                    DrawHistogram(ProcImage, pBoxHistProc);
                
            }
            else
            {
                MessageBox.Show("No image loaded");
            }
        }
       

        private void main_Trackbar_Scroll(object sender, System.EventArgs e)
        {
            //ThresholdValue = main_Trackbar.Value;
            lblThresholdValue.Text = main_Trackbar.Value.ToString();
            ProcImage = _imgProcessing.Execute(_currentProcess, OriginalImage, main_Trackbar.Value);
            pBox_ProcImg.Image = ProcImage;
        }

        private void main_Trackbar_ValueChanged(object sender, System.EventArgs e)
        {
            //ThresholdValue = main_Trackbar.Value;
            lblThresholdValue.Text = main_Trackbar.Value.ToString();
        }


        private void DrawHistogram(Bitmap img, PictureBox p)
        {
            p.Refresh();

            var hist = new Bitmap(p.Width, p.Height);


            int[] res = _imgProcessing.CalculateHistogramBins(img);
            float l = res.Max();
            //Array.Reverse(res);
            float scaleFactor = (p.Height - 10) / l;
            Pen mPen = new Pen(Color.Gray);
            //var gf = p.CreateGraphics();
            var gf = Graphics.FromImage(hist);
            //Matrix m = new Matrix();
            //m.RotateAt(180, new PointF(p.Width / 2f, p.Height / 2f));
            //gf.Transform = m;
            mPen.Color = Color.Blue;
            for (int i = 0; i < res.Length; i++)
            {
                gf.DrawLine(mPen, i, 0, i, res[i] * scaleFactor);
            }
            mPen.Dispose();
            gf.Dispose();

            hist.RotateFlip(RotateFlipType.RotateNoneFlipY);
            p.Image = hist;

        }

        private void ContrastStretchDialog_Click(object sender, System.EventArgs e)
        {
            ContrastStretch cs = new ContrastStretch(OriginalImage);
            _currentProcess = Process.ContrastStretch;
            //cs.ShowDialog();

            if (cs.ShowDialog() == DialogResult.OK && cs.Proc != null)
            {
                ProcImage = cs.Proc;
                pBox_ProcImg.Image = ProcImage;
                if (ProcImage != null)
                    DrawHistogram(ProcImage, pBoxHistProc);
                cs.Close();
            }
        }

        private void btnAccept_Click(object sender, System.EventArgs e)
        {
            if (ProcImage != null)
            {
                OriginalImage = ProcImage;
                pBox_Original.Image = OriginalImage;
                pBox_ProcImg.Image = new Bitmap(pBox_ProcImg.Width, pBox_ProcImg.Height);
                ProcImage = null;
                pBoxHistProc.Image = new Bitmap(pBoxHistProc.Width, pBoxHistProc.Height);
                DrawHistogram(OriginalImage, pBoxHistOrig);
                listboxHistory.Items.Add(_currentProcess.ToString());
                ResetThresholdPanel();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ProcImage != null)
            {
                pBox_ProcImg.Image = new Bitmap(pBox_ProcImg.Width, pBox_ProcImg.Height);
                ProcImage = null;
                pBoxHistProc.Image = new Bitmap(pBoxHistProc.Width, pBoxHistProc.Height);
                ResetThresholdPanel();
            }
        }

        private void ResetThresholdPanel()
        {
            thresholdPanel.Enabled = false;
            main_Trackbar.Value = ThresholdDefault;
            main_Trackbar.Maximum = ThresholdDefaultMaximum;
        }

        private void transformToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void zoomTrackbar_Scroll(object sender, System.EventArgs e)
        {
            pBox_ProcImg.SizeMode = PictureBoxSizeMode.Zoom;
            
            float zoomFact = zoomTrackbar.Value/4f;
            var w = pBox_ProcImg.Image.Width;
            var h = pBox_ProcImg.Image.Height;

            pBox_ProcImg.Width = Convert.ToInt32(w*zoomFact);
            pBox_ProcImg.Height = Convert.ToInt32(h*zoomFact);

            pBox_ProcImg.Image = ProcImage;

        }

        private void btnIncreaseRotation_Click(object sender, System.EventArgs e)
        {
            var r = RotateImage(1);
            if (r != null)
                pBox_ProcImg.Image = r;
        }

        private void btnDecreaseRotation_Click(object sender, System.EventArgs e)
        {
            var r = RotateImage(-1);
            if (r != null)
                pBox_ProcImg.Image = r;
        }

        private Bitmap RotateImage(Int32 increment) 
        {
            if (OriginalImage == null)
            {
                MessageBox.Show("No image in memory");

                return null;
            }

            if (ProcImage == null)
                ProcImage = OriginalImage;

            Image img = ProcImage;
            
            rotation = Int32.Parse(txtRotation.Text);
            rotation += increment;
            if (rotation >= 360)
                rotation = 0;
            if (rotation < 0)
                rotation = 359;
            txtRotation.Text = rotation.ToString();
            
            // http://www.codeproject.com/Articles/58815/C-Image-PictureBox-Rotations
            Bitmap rot = new Bitmap(ProcImage.Width, ProcImage.Height);
            rot.SetResolution(ProcImage.HorizontalResolution, ProcImage.VerticalResolution);
            
            Graphics g = Graphics.FromImage(rot);

            g.TranslateTransform(ProcImage.Width / 2f, ProcImage.Height / 2f);

            g.RotateTransform(rotation);

            var scaleFactor = (float)CalculateConstraintScale(rotation, ProcImage.Width, ProcImage.Height);

            g.ScaleTransform(scaleFactor, scaleFactor);

            g.TranslateTransform(-1 * (ProcImage.Width / 2f), -1 * (ProcImage.Height / 2f));

            g.DrawImage(img, new Point(0, 0));

            return rot;
        }


        /************************************ 
         * Scale to fit
         * http://stackoverflow.com/a/6802332 
         ************************************/
        private double CalculateConstraintScale(double rotation, int pixelWidth, int pixelHeight)
        {
            // Convert angle to radians for the math lib
            double rotationRadians = rotation * (Math.PI/180);

            // Centre is half the width and height
            double width = pixelWidth / 2.0;
            double height = pixelHeight / 2.0;
            double radius = Math.Sqrt(width * width + height * height);

            // Convert BR corner into polar coordinates
            double angle = Math.Atan(height / width);

            // Now create the matching BL corner in polar coordinates
            double angle2 = Math.Atan(height / -width);

            // Apply the rotation to the points
            angle += rotationRadians;
            angle2 += rotationRadians;

            // Convert back to rectangular coordinate
            double x = Math.Abs(radius * Math.Cos(angle));
            double y = Math.Abs(radius * Math.Sin(angle));
            double x2 = Math.Abs(radius * Math.Cos(angle2));
            double y2 = Math.Abs(radius * Math.Sin(angle2));

            // Find the largest extents in X & Y
            x = Math.Max(x, x2);
            y = Math.Max(y, y2);

            // Find the largest change (pixel, not ratio)
            double deltaX = x - width;
            double deltaY = y - height;

            // Return the ratio that will bring the largest change into the region
            return (deltaX > deltaY) ? width / x : height / y;
        }

        
    }

}

