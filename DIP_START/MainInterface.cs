using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
        
        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // show the openFile dialog box            

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _originalImage = new Bitmap(openFileDialog1.FileName);
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

            using (var dialog = new ThresholdTrackbarDialog(binarization))
            {
                dialog.Text = "Binarization Threshold";
                dialog.ShowDialog();
            }
        }
        
        private void withoutThresholdingToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Filters filters = new Filters(_originalImage);
            var processed = filters.NeighbourhoodAveraging();

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
        
    }

}

