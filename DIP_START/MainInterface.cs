using System;
using System.Drawing;
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
            //int startX = -350;
            var histogram = new Histogram();

            int[] res = histogram.CalculateBins(img);

            var l = res.Max();

            Array.Reverse(res);

            float scaleFactor = 110.0f / l;

            Pen mPen = new Pen(Color.Gray);

            var gf = this.CreateGraphics();

            gf.TranslateTransform(270, 650);
            gf.RotateTransform(180);

            Label lbl = new Label();
            lbl.Text = "Histogram";
            lbl.Width = 60;
            lbl.Location = new Point(25, 525);
            this.Controls.Add(lbl);
            lbl.Show();


            gf.DrawRectangle(mPen, new Rectangle(0, 0, 255, 120));

            int x = 1;

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

                object obj = Activator.CreateInstance(Type.GetType("DIP_ClassLib." + array[0] + ", DIP_ClassLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), _originalImage);

                var thresholding = obj as IUseTrackbarThresholding;
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
                else
                {
                    Type t = obj.GetType();
                    Object ts = t.InvokeMember(array[1], BindingFlags.InvokeMethod, Type.DefaultBinder, obj, null);

                    using (var dialog = new ThresholdTrackbarDialog((Bitmap)ts, array[2]))
                    {
                        dialog.Text = array[1];
                        var result = dialog.ShowDialog();
                        if (result == DialogResult.OK && ts != null)
                        {
                            UpdateOriginal((Bitmap)ts);
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

