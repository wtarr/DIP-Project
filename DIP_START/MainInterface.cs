using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DIP_ClassLib;

namespace DIP_START
{

    public partial class MainInterface : Form
    {
        private Bitmap _originalImage;
        public int[] bins = new int[256];
        int max;
        private Graphics _g;
        private readonly Transformation _transformation;
        private const int StartX = 10;
        private const int StartY = 50;
        private const int PrefWidth = 450;
        private const int PrefHeight = 450;

        public MainInterface()
        {
            InitializeComponent();
            _originalImage = null;
            _g = CreateGraphics();
            _transformation = new Transformation();

        }

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (_originalImage != null)
            {
                UpdateOriginal(_originalImage);
            }

        }

        private void DrawHistogram(Bitmap img)
        {
            var histogram = new Histogram();
            int[] res = histogram.CalculateBins(img);
            float l = res.Max();
            Array.Reverse(res);
            float scaleFactor = (panel_Histogram.Height-10) / l;
            Pen mPen = new Pen(Color.Gray);
            var gf = panel_Histogram.CreateGraphics();
            Matrix m = new Matrix();
            m.RotateAt(180, new PointF(panel_Histogram.Width/2f, panel_Histogram.Height/2f));
            gf.Transform = m;
            mPen.Color = Color.Blue;
            for (int i = 0; i < res.Length; i++)
            {
                gf.DrawLine(mPen, i, 0, i, res[i] * scaleFactor);
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
                this.Text = "PhotoChop - " + openFileDialog1.SafeFileName;
                UpdateOriginal(_originalImage);
                HistoryList.Items.Clear();
                HistoryList.Items.Add("Open - " + openFileDialog1.SafeFileName);
            }

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Dispose();
            Application.Exit();
        }

        private void UpdateOriginal(Bitmap img)
        {
            Refresh();
            _originalImage = img;
            Size destSize;
            var o = _transformation.ScaleWithMaintainedRatio(_originalImage, new Size(PrefWidth, PrefHeight), out destSize);
            _g.DrawImage(o, new Rectangle(StartX, StartY, destSize.Width, destSize.Height));
            DrawHistogram(img);
        }

        private void MenuItem_Clicked(object sender, System.EventArgs e)
        {
            // Single event handler for all menu item clicks regarding processes

            ToolStripMenuItem temp = sender as ToolStripMenuItem;

            if (temp != null)
            {
                String[] array = temp.Name.Split('_'); // Class name _ method/process to invoke _ should display trackbar

                object obj = null;
                try
                {
                    obj = Activator.CreateInstance(
                            Type.GetType(string.Format("DIP_ClassLib.{0}," +
                                                       " DIP_ClassLib," +
                                                       " Version=1.0.0.0," +
                                                       " Culture=neutral," +
                                                       " PublicKeyToken=null",
                                                       array[0])),
                            _originalImage);
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Class/Method not found");
                }

                var thresholding = obj as ImAnImageProcess;
                if (thresholding != null)
                {
                    var t = thresholding;
                    var es = Enum.Parse(typeof(Process), array[1]);

                    using (var dialog = new ThresholdTrackbarDialog(t, (Process)es, array[2]))
                    {
                        dialog.Text = array[1];
                        if (dialog.ShowDialog() == DialogResult.OK && dialog.ProcImg != null)
                        {
                            UpdateOriginal(dialog.ProcImg);
                            HistoryList.Items.Add(dialog.Text);
                        }
                    }

                }
            }

        }

        private void MainInterface_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                
            }
            else
            {
                UpdateOriginal(_originalImage);
            }
        }


    }

}

