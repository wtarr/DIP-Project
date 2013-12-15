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
        public Bitmap OriginalImage, ProcImage, ProcRotated;
        private int _rotation;
        private Boolean _clkWise = true;
        private float _zoomFact = 1;


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
                ResetRotationAndZoomControl();

                String[] array = itemClicked.Name.Split('_');
                _currentProcess = (Process)Enum.Parse(typeof(Process), array[0]);

                thresholdPanel.Enabled = Boolean.Parse(array[1]);

                ProcImage = _imgProcessing.Execute((Process)_currentProcess, OriginalImage, main_Trackbar.Value);
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
            float scaleFactor = (p.Height - 10) / l;
            Pen mPen = new Pen(Color.Gray);
            var gf = Graphics.FromImage(hist);
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
            if (OriginalImage == null)
            {
                MessageBox.Show("No Image in memory");
                return;
            }

            ContrastStretch cs;

            _currentProcess = Process.ContrastStretch;

            using (cs = new ContrastStretch(OriginalImage))
            {
                if (cs.ShowDialog() != DialogResult.OK || cs.Proc == null) return;
                ProcImage = cs.Proc;
                pBox_ProcImg.Image = ProcImage;
                if (ProcImage != null)
                    DrawHistogram(ProcImage, pBoxHistProc);
                cs.Close();
            }
        }

        private void btnAccept_Click(object sender, System.EventArgs e)
        {
            if (ProcImage != null && _currentProcess != Process.Zoom && _currentProcess != Process.Rotate)
            {
                OriginalImage = ProcImage;
                pBox_Original.Image = OriginalImage;
                pBox_ProcImg.Image = new Bitmap(pBox_ProcImg.Width, pBox_ProcImg.Height);
                ProcImage = null;
                pBoxHistProc.Image = new Bitmap(pBoxHistProc.Width, pBoxHistProc.Height);
                DrawHistogram(OriginalImage, pBoxHistOrig);
                listboxHistory.Items.Add(_currentProcess.ToString());
                ResetThresholdPanel();
                ResetRotationAndZoomControl();
            }
            else
            {
                MessageBox.Show("This process cannot be applied, Sorry");

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetRotationAndZoomControl();
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

        private void zoomTrackbar_Scroll(object sender, System.EventArgs e)
        {
            if (OriginalImage != null)
            {
                if (ProcImage == null)
                {
                    ProcImage = OriginalImage;
                    pBox_ProcImg.Image = ProcImage;
                }
                _currentProcess = Process.Zoom;
                pBox_ProcImg.SizeMode = PictureBoxSizeMode.Zoom;

                _zoomFact = zoomTrackbar.Value / 4f;
                lblZoomFactor.Text = _zoomFact.ToString();
                var w = pBox_ProcImg.Image.Width;
                var h = pBox_ProcImg.Image.Height;

                pBox_ProcImg.Width = Convert.ToInt32(w * _zoomFact);
                pBox_ProcImg.Height = Convert.ToInt32(h * _zoomFact);

                pBox_ProcImg.Image = ProcImage;
            }
            else
            {
                MessageBox.Show("No image in memory");
                zoomTrackbar.Value = 4;
            }

        }

        private void RotateClockwise()
        {
            ManageRotation(1);
            var r = RotateImage();
            if (r != null)
            {
                ProcImage = r;
                pBox_ProcImg.Image = ProcImage;
            }
        }

        private void RotateAntiClockwise()
        {
            ManageRotation(-1);
            var r = RotateImage();
            if (r != null)
            {
                ProcImage = r;
                pBox_ProcImg.Image = ProcImage;
            }
        }



        private void ResetRotationAndZoomControl()
        {
            zoomTrackbar.Value = 4;
            _zoomFact = 1;
            lblZoomFactor.Text = "1";
            _rotation = 0;
            txtRotation.Text = "0";
        }

        private Bitmap RotateImage()
        {
            if (OriginalImage == null)
            {
                MessageBox.Show("No image in memory");

                return null;
            }

            _currentProcess = Process.Rotate;

            //if (ProcImage == null)
            //    ProcImage = OriginalImage;

            Image img = OriginalImage;

            // http://www.codeproject.com/Articles/58815/C-Image-PictureBox-Rotations
            Bitmap rot = new Bitmap(OriginalImage.Width, OriginalImage.Height);
            rot.SetResolution(OriginalImage.HorizontalResolution, OriginalImage.VerticalResolution);

            Graphics g = Graphics.FromImage(rot);

            g.TranslateTransform(OriginalImage.Width / 2f, OriginalImage.Height / 2f);

            g.RotateTransform(_rotation);

            float scaleFactor = (_zoomFact <= 1)
                ? (float)CalculateConstraintScale(_rotation, OriginalImage.Width, OriginalImage.Height)
                : 1;

            g.ScaleTransform(scaleFactor, scaleFactor);

            g.TranslateTransform(-1 * (OriginalImage.Width / 2f), -1 * (OriginalImage.Height / 2f));

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
            double rotationRadians = rotation * (Math.PI / 180);

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

        private void ManageRotation(int increment)
        {
            _rotation = Int32.Parse(txtRotation.Text);
            _rotation += increment;
            if (_rotation >= 360)
                _rotation = 0;
            if (_rotation < 0)
                _rotation = 359;
            txtRotation.Text = _rotation.ToString();
        }

        private void btnIncreaseRotation_MouseDown(object sender, MouseEventArgs e)
        {
            if (OriginalImage != null)
            {
                rotationTimer.Enabled = true;
                _clkWise = true;
                rotationTimer.Start();
            }
            else
            {
                MessageBox.Show("No image in memory");
            }
        }

        private void btnClockwiseRotation_MouseUp(object sender, MouseEventArgs e)
        {
            rotationTimer.Stop();
        }

        private void rotationTimer_Tick(object sender, System.EventArgs e)
        {
            if (_clkWise)
                RotateClockwise();
            else
                RotateAntiClockwise();
        }

        private void btnClockwiseRotation_Click(object sender, System.EventArgs e)
        {
            RotateClockwise();
        }

        private void btnDecreaseRotation_Click(object sender, System.EventArgs e)
        {
            RotateAntiClockwise();
        }

        private void btnAntiClockwiseRotation_MouseDown(object sender, MouseEventArgs e)
        {
            if (OriginalImage != null)
            {
                rotationTimer.Enabled = true;
                _clkWise = false;
                rotationTimer.Start();
            }
            else
            {
                MessageBox.Show("No image in memory");
            }

        }

        private void btnAntiClockwiseRotation_MouseUp(object sender, MouseEventArgs e)
        {
            rotationTimer.Stop();
        }

        private void RotationCheckedChanged(object sender, System.EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.Checked)
            {
                var txt = radioButton.Text;
                _rotation = int.Parse(txt);
                ProcImage = RotateImage();
                pBox_ProcImg.Image = ProcImage;
                txtRotation.Text = _rotation.ToString();
            }
        }


    }

}

