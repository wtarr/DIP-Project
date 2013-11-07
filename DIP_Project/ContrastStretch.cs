using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DIP_Project
{
    public partial class ContrastStretch : Form
    {
        public ContrastStretch()
        {
            InitializeComponent();
            //InitializeContrastGraph();
        }

            

        private void ContrastStretch_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contrastStretchPanel.Refresh();
            var w = contrastStretchPanel.Width;
            var h = contrastStretchPanel.Height;
                
            Matrix m = new Matrix();
                        
            m.RotateAt(180, new PointF(w / 2f, h / 2f));            

            Pen mPen = new Pen(Color.Red);
            var gf = contrastStretchPanel.CreateGraphics();
            gf.Transform = m;


            // mPen.Color = Color.Blue;

            gf.DrawLine(mPen, 0, 0, 100, 100);

            mPen.Dispose();
            gf.Dispose();
        }
    }
}
