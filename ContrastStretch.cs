using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;


namespace DIP_Project
{
    public partial class ContrastStretch : Form
    {

        private Point _rect1, _rect2, _oldPoint1, _oldPoint2, _scaledRect1, _scaledRect2;
        private int rectWH = 20;
        private Bitmap _orig, _proc;


        public ContrastStretch(Bitmap orig)
        {
            InitializeComponent();
            //InitializeContrastGraph();
            _rect1 = new Point(pBox.Width / 4, pBox.Height / 4);
            _rect2 = new Point(3 * (pBox.Width / 4), 3 * (pBox.Height / 4));
            _oldPoint1 = new Point(_rect1.X, _rect1.Y);
            _oldPoint2 = new Point(_rect2.X, _rect2.Y);
            _scaledRect1 = new Point(0, 0);
            _scaledRect2 = new Point(0, 0);
            _orig = orig;

            ReDraw();
            UpdateScaledPoints();

            pictureBox1.Image = orig;

        }




        private void ContrastStretch_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }


        private void ReDraw()
        {
            pBox.Refresh();
            var w = pBox.Width;
            var h = pBox.Height;               

            Pen mPen = new Pen(Color.Red);

            var img = new Bitmap(pBox.Width, pBox.Height);

            var gf = Graphics.FromImage(img);           

            gf.DrawLine(mPen, 0, 0, _rect1.X, _rect1.Y);
            gf.DrawLine(mPen, _rect1.X, _rect1.Y, _rect2.X, _rect2.Y);
            gf.DrawLine(mPen, _rect2.X, _rect2.Y, img.Width, img.Height);

            mPen.Color = Color.Blue;
            gf.DrawRectangle(mPen, new Rectangle(_rect1.X - rectWH / 2, _rect1.Y - rectWH / 2, rectWH, rectWH));
            gf.DrawRectangle(mPen, new Rectangle(_rect2.X - rectWH / 2, _rect2.Y - rectWH / 2, rectWH, rectWH));

            mPen.Dispose();
            gf.Dispose();

            img.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pBox.Image = img;

        }

        private void UpdateScaledPoints()
        {

            _scaledRect1.X = (int)(((float)_rect1.X / pBox.Width) * 255);
            _scaledRect1.Y = (int)(((float)_rect1.Y / pBox.Height) * 255);
            _scaledRect2.X = (int)(((float)_rect2.X / pBox.Width) * 255);
            _scaledRect2.Y = (int)(((float)_rect2.Y / pBox.Height) * 255);

            txtX1.Text = _scaledRect1.X.ToString();
            txtY1.Text = _scaledRect1.Y.ToString();
            txtX2.Text = _scaledRect2.X.ToString();
            txtY2.Text = _scaledRect2.Y.ToString();
        }


        private void pBox_MouseMove(object sender, MouseEventArgs e)
        {          

            if (e.Button.Equals(MouseButtons.Left))
            {


                var yCoord = pBox.Height - e.Y; // because we flipped the image along horiontal

                if (e.X > _rect1.X - rectWH / 2 && e.X < _rect1.X + rectWH / 2 &&
                    yCoord > _rect1.Y - rectWH / 2 && yCoord < _rect1.Y + rectWH / 2)
                {

                    // Calculate delta

                    _rect1.X += e.X - _oldPoint1.X;
                    _rect1.Y += yCoord - _oldPoint1.Y;

                    ReDraw();

                    _oldPoint1.X = _rect1.X;
                    _oldPoint1.Y = _rect1.Y;
                }

                if (e.X > _rect2.X - rectWH / 2 && e.X < _rect2.X + rectWH / 2 &&
                    yCoord > _rect2.Y - rectWH / 2 && yCoord < _rect2.Y + rectWH / 2)
                {

                    // Calculate delta

                    _rect2.X += e.X - _oldPoint2.X;
                    _rect2.Y += yCoord - _oldPoint2.Y;

                    ReDraw();

                    _oldPoint2.X = _rect2.X;
                    _oldPoint2.Y = _rect2.Y;


                }

                UpdateScaledPoints();
                var newMap = BuildMap();
                Remap(newMap);
            }


        }

        private void btnApply_Click(object sender, EventArgs e)
        {

        }

        private void Remap(byte[] map)
        {
            int width = _orig.Width;
            int height = _orig.Height;

            _proc = (Bitmap)_orig.Clone();

            BitmapData bmData = _proc.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite,
                PixelFormat.Format8bppIndexed);

            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                for (var y = 0; y < height; y++)
                {
                    for (var x = 0; x < width; x++)
                    {
                        //var convert = BuildMap(*p);
                        var newpix = map[*p];
                        *p = newpix;
                        p++;
                    }

                }
            }

            _proc.UnlockBits(bmData);

            pictureBox1.Image = _proc;

        }

        private byte[] BuildMap()
        {
            byte[] mapped = new byte[256];

            var m1 = _scaledRect1.Y / (float)_scaledRect1.X;
            var m2 = (_scaledRect2.Y - _scaledRect1.Y) / ((float)(_scaledRect2.X - _scaledRect1.X));
            var m3 = (255 - _scaledRect2.Y) / ((float)(255 - _scaledRect2.X));

            for (int p = 0; p < 256; p++)
            {

                if (p >= 0 && p <= _scaledRect1.X)
                {
                    mapped[p] = (byte)(m1 * p);
                }
                else if (p > _scaledRect1.X && p <= _scaledRect2.X)
                {                                   
                    mapped[p] = (byte)((m2 * p) - (m2 * _scaledRect1.X) + _scaledRect1.Y);
                }
                else
                {
                    mapped[p] = (byte)((m3 * p) - (m3 * _scaledRect2.X) + _scaledRect2.Y); 
                }
            }

            return mapped;
        }
    }
}
