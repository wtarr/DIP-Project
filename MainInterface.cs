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
        private const int ThresholdDefault = 127;
        private Graphics _g;
        private readonly ImageProcessing _imgProcessing;
        private Process _currentProcess;
        public Bitmap OriginalImage, ProcImage;
        

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
            // show the openFile dialog box            
            Graphics g = this.CreateGraphics();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OriginalImage = new Bitmap(openFileDialog1.FileName);
            }
            pBox_Original.Image = OriginalImage;
            //Rectangle r = new Rectangle(10, 50, original_image.Width, original_image.Height);
            //g.DrawImage(original_image, r);
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

            if (itemClicked != null)
            {
               

                String[] array = itemClicked.Name.Split('_');
                _currentProcess = (Process)Enum.Parse(typeof (Process), array[0]);

                thresholdPanel.Enabled = Boolean.Parse(array[1]);

                ProcImage = _imgProcessing.Execute((Process) _currentProcess, OriginalImage, main_Trackbar.Value);
                pBox_ProcImg.Image = ProcImage;
                DrawHistogram(ProcImage, pBoxHistProc);
                
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
            cs.ShowDialog();
        }
        
    }

}

