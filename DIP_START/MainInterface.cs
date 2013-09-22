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
        private Transformation _transformation;


        public MainInterface()
        {
            InitializeComponent();
            _originalImage = null;
            _procImage = null;
            _g = this.CreateGraphics();
            _transformation = new Transformation();
            

        }


        private void Form1_Load(object sender, EventArgs e)
        {

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
            _g = this.CreateGraphics();

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

        
        /***********************************************************************************/
        //           INVERSE VIDEO
        /***********************************************************************************/
        private void inverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InverseImage();
        }

        private void InverseImage()
        {
            _g = this.CreateGraphics();

            int width = _originalImage.Width;
            int height = _originalImage.Height;

            Rectangle r = new Rectangle(535, 50, _originalImage.Width, _originalImage.Height);
            Rectangle r2 = new Rectangle(0, 0, _originalImage.Width, _originalImage.Height);

            _procImage = _originalImage.Clone(r2, PixelFormat.Format8bppIndexed);


            BitmapData bmData = _procImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite,
                PixelFormat.Format8bppIndexed);

            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*) (void*) Scan0;

                for (int y = 0; y < height; ++y)
                {
                    for (int x = 0; x < width; ++x)
                    {
                        p[0] = (byte) (255 - p[0]);
                        ++p;
                    }
                }
            }

            _procImage.UnlockBits(bmData);

            //_g.DrawImage(_procImage, r);


            Size destSize;
            var o = _transformation.ScaleWithMaintainedRatio(_procImage, new Size(450, 450), out destSize);
            _g.DrawImage(o, new Rectangle(500, 50, destSize.Width, destSize.Height));
        }

        private void DarkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DarkenImage();
        }

        private void DarkenImage()
        {
            _g = this.CreateGraphics();

            int width = _originalImage.Width;
            int height = _originalImage.Height;

            Rectangle r = new Rectangle(535, 50, _originalImage.Width, _originalImage.Height);
            Rectangle r2 = new Rectangle(0, 0, _originalImage.Width, _originalImage.Height);

            _procImage = _originalImage.Clone(r2, PixelFormat.Format8bppIndexed);


            BitmapData bmData = _procImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite,
                PixelFormat.Format8bppIndexed);

            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*) (void*) Scan0;

                for (int y = 0; y < height; ++y)
                {
                    for (int x = 0; x < width; ++x)
                    {
                        if (p[0] > 120)
                        {
                            if (p[0] < 195)
                                p[0] = 0;
                        }
                        ++p;
                    }
                }
            }

            _procImage.UnlockBits(bmData);

            //_g.DrawImage(_procImage, r);

            Size destSize;
            var o = _transformation.ScaleWithMaintainedRatio(_procImage, new Size(450, 450), out destSize);
            _g.DrawImage(o, new Rectangle(500, 50, destSize.Width, destSize.Height));
        }

        private void brightenToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            BrightenImage();
        }

        private void BrightenImage()
        {            

            Graphics g = this.CreateGraphics();

            int width = _originalImage.Width;
            int height = _originalImage.Height;

            Rectangle r = new Rectangle(535, 50, _originalImage.Width, _originalImage.Height);
            Rectangle r2 = new Rectangle(0, 0, _originalImage.Width, _originalImage.Height);

            _procImage = _originalImage.Clone(r2, PixelFormat.Format8bppIndexed);


            BitmapData bmData = _procImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                for (int y = 0; y < height; ++y)
                {
                    for (int x = 0; x < width; ++x)
                    {

                        if (p[0] > 10 && p[0] < 100)
                        {
                            p[0] = 255;
                        }

                        ++p;
                    }

                }
            }

            _procImage.UnlockBits(bmData);

            //g.DrawImage(_procImage, r);

            Size destSize;
            var o = _transformation.ScaleWithMaintainedRatio(_procImage, new Size(450, 450), out destSize);
            _g.DrawImage(o, new Rectangle(500, 50, destSize.Width, destSize.Height));
        }

        private void binarizeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //Binarize();
            // Open Dialog here

            var b = new Binarization();
            var bin_img = b.Binarize(127, _originalImage);

            Size destSize;
            var o = _transformation.ScaleWithMaintainedRatio(bin_img, new Size(450, 450), out destSize);
            _g.DrawImage(o, new Rectangle(500, 50, destSize.Width, destSize.Height));

        }

        private void trackBar1_Scroll(object sender, System.EventArgs e)
        {
            //var val = trackBar1.Value;

            //binarize();
            output.Text = trackBar1.Value.ToString();

            Binarization b = new Binarization();
            var bin_img = b.Binarize(Convert.ToInt32(output.Text), _originalImage);

            Size destSize;
            var o = _transformation.ScaleWithMaintainedRatio(bin_img, new Size(450, 450), out destSize);
            _g.DrawImage(o, new Rectangle(500, 50, destSize.Width, destSize.Height));
            
            //Binarize(trackBar1.Value);
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var value = trackBar1.Value;
            output.Text = value.ToString();
        }









        /*****************************************************************************************/  
        
    }

}

