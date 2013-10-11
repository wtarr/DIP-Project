using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DIP_ClassLib;

namespace DIP_START
{

    public partial class MainInterface : Form
    {
        private Bitmap _originalImage, _procImage;
        public int[] bins = new int[256];
        int max;
        private Graphics _g;
        private readonly Transformation _transformation;
        private Histogram _histogram;


        public MainInterface()
        {
            InitializeComponent();
            _originalImage = null;
            _procImage = null;
            _g = CreateGraphics();
            _transformation = new Transformation();
            

        }

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (_originalImage != null)
            {
                _g = e.Graphics;
                Rectangle r = new Rectangle(10, 50, _originalImage.Width, _originalImage.Height);
                _g.DrawImage(_originalImage, r);

            }

        }

        

        private void DrawHistogram()
        {
            //int startX = -350;
            int[] res = _histogram.CalculateBins();
            
            var l = res.Max();

            Array.Reverse(res);

            float scaleFactor = 110.0f/l;

            Pen mPen = new Pen(Color.Black);

            var gf = this.CreateGraphics();
            
            gf.TranslateTransform(320, 650);
            gf.RotateTransform(180);

            gf.DrawRectangle(mPen, new Rectangle(0, 0, 255, 120));
            
            int x = 1;

            mPen.Color = Color.Blue;

            for (int i = 0 ; i < res.Length; i++)
            {
                gf.DrawLine(mPen,  i , 0, i , res[i] * scaleFactor);
            }
            
            mPen.Dispose();

            gf.Dispose();


        }
        
        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // show the openFile dialog box            

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _originalImage = new Bitmap(openFileDialog1.FileName);
                _histogram = new Histogram(_originalImage);
                DrawHistogram();
            }
            

            Size destSize;
            var o = _transformation.ScaleWithMaintainedRatio(_originalImage, new Size(450, 450), out destSize);

            //Rectangle r = new Rectangle(10, 50, original_image.Width, original_image.Height);
            //g.DrawImage(original_image, r);
            _g.DrawImage(o, new Rectangle(10, 50, destSize.Width, destSize.Height));
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Dispose();
            Application.Exit();
        }

        private void inverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inverseVideo = new InverseVideo();
            var _procImage = inverseVideo.inverse(_originalImage);

            using (var dialog = new ThresholdTrackbarDialog(_procImage))
            {
                dialog.Text = "Inverse";
                dialog.ShowDialog();
            }
            
        }

        private void binarizeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            IUseTrackbarThresholding binarization = new Binarization(_originalImage);

            using (var dialog = new ThresholdTrackbarDialog(binarization, Process.Binarize))
            {
                dialog.Text = "Binarization Threshold";
                dialog.ShowDialog();
            }
        }
        
        private void withoutThresholdingToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            SmoothingFilters smoothingFilters = new SmoothingFilters(_originalImage);
            var processed = smoothingFilters.NeighbourhoodAveraging();

            using (var dialog = new ThresholdTrackbarDialog(processed))
            {
                dialog.Text = "Neighbourhood Averaging";
                dialog.ShowDialog();
            }
        }

        private void darkenToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            var lvls = new Levels();
            var processed = lvls.Darken(_originalImage);

            using (var dialog = new ThresholdTrackbarDialog(processed))
            {
                dialog.Text = "Darken";
                dialog.ShowDialog();
            }
        }

        private void brightenToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            var lvls = new Levels();
            var processed = lvls.Brighten(_originalImage);

            using (var dialog = new ThresholdTrackbarDialog(processed))
            {
                dialog.Text = "Brighten";
                dialog.ShowDialog();
            }
           
        }

        private void withThresholdingToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            IUseTrackbarThresholding filters = new SmoothingFilters(_originalImage);
            
            using (var dialog = new ThresholdTrackbarDialog(filters, Process.NeibhourhoodAverage))
            {
                dialog.Text = "Neighbourhood Averaging";
                dialog.ShowDialog();
            }
        }

        private void medToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            var lvls = new SmoothingFilters(_originalImage);
            var processed = lvls.MedianFiltering();

            using (var dialog = new ThresholdTrackbarDialog(processed))
            {
                dialog.Text = "Median Filtering";
                dialog.ShowDialog();
            }
        }

        private void directToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            RobertsGradient rg = new RobertsGradient(_originalImage);
            using (var dialog = new ThresholdTrackbarDialog(rg.Direct()))
            {
                dialog.Text = "Roberts Gradient (Direct)";
                dialog.ShowDialog();
            }
        }

        private void RobertsGradientwithThresholdToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            IUseTrackbarThresholding rgThresholding = new RobertsGradient(_originalImage);

            using (var dialog = new ThresholdTrackbarDialog(rgThresholding, Process.RobertsGradientWithThresholding))
            {
                dialog.Text = "Roberts Gradient (Threshold)";
                dialog.ShowDialog();
            }
        }

        private void PseudoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            IUseTrackbarThresholding rgThresholding = new RobertsGradient(_originalImage);

            using (var dialog = new ThresholdTrackbarDialog(rgThresholding, Process.RobertsGradientWithPseudoColor))
            {
                dialog.Text = "Roberts Gradient with Pseudo color (Threshold)";
                dialog.ShowDialog();
            }
        }

        private void Sobel_GxToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            IUseTrackbarThresholding sb = new SharpenFilters(_originalImage);
            using (var dialog = new ThresholdTrackbarDialog(sb, Process.SobelGx))
            {
                dialog.Text = "SharpenFilters Gx";
                dialog.ShowDialog();
            }
        }

        private void Soblel_GyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            IUseTrackbarThresholding sb = new SharpenFilters(_originalImage);
            using (var dialog = new ThresholdTrackbarDialog(sb, Process.SobelGy))
            {
                dialog.Text = "SharpenFilters Gy";
                dialog.ShowDialog();
            }
        }

        private void Sobel_GxAndGyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            IUseTrackbarThresholding sb = new SharpenFilters(_originalImage);
            using (var dialog = new ThresholdTrackbarDialog(sb, Process.SobelGxGy))
            {
                dialog.Text = "SharpenFilters Gx + Gy";
                dialog.ShowDialog();
            }
        }

        private void laplacianToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            IUseTrackbarThresholding lp = new SharpenFilters(_originalImage);
            using ( var dialog = new ThresholdTrackbarDialog(lp, Process.Laplacian))
            {
                dialog.Text = "Laplacian Operator";
                dialog.ShowDialog();
            }
        }

        private void pointDetectionToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            IUseTrackbarThresholding pd = new SharpenFilters(_originalImage);
            using (var dialog = new ThresholdTrackbarDialog(pd, Process.PointDetection))
            {
                dialog.Text = "Point Detection";
                dialog.ShowDialog();
            }
        }

        private void horizontalToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            IUseTrackbarThresholding hd = new SharpenFilters(_originalImage);
            using (var dialog = new ThresholdTrackbarDialog(hd, Process.HorizontalLine))
            {
                dialog.Text = "Horizontal Line Detection";
                dialog.ShowDialog();
            }
        }

        private void verticalToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            IUseTrackbarThresholding vd = new SharpenFilters(_originalImage);
            using (var dialog = new ThresholdTrackbarDialog(vd, Process.VerticalLine))
            {
                dialog.Text = "Vertical Line Detection";
                dialog.ShowDialog();
            }
        }

        private void Positive45_Click(object sender, System.EventArgs e)
        {
            IUseTrackbarThresholding p45 = new SharpenFilters(_originalImage);
            using (var dialog = new ThresholdTrackbarDialog(p45, Process.Positive45DegreeLine))
            {
                dialog.Text = "Positive 45 Line Detection";
                dialog.ShowDialog();
            }
        }

        private void Negative45_Click(object sender, System.EventArgs e)
        {
            IUseTrackbarThresholding n45 = new SharpenFilters(_originalImage);
            using (var dialog = new ThresholdTrackbarDialog(n45, Process.Negative45DegreeLine))
            {
                dialog.Text = "Negative 45 Line Detection";
                dialog.ShowDialog();
            }
        }

        
    }

}

