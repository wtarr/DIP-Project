using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DIP_ClassLib;

namespace DIP_START
{
    public partial class ThresholdTrackbarDialog : Form
    {
        public event EventHandler OnTrackBarChange;
        
        public int[] ThresholdValue { get; private set; }

        private IUseTrackbarThresholding _process;

        private Graphics _g;

        private Transformation _transformation;

        public Bitmap ProcImg { get; private set; }

        private Process _operation;

        private bool _Visible;

        public ThresholdTrackbarDialog(IUseTrackbarThresholding process, Process operation, string visible)
        {
            InitializeComponent();
            _g = CreateGraphics();
            _process = process;
            _operation = operation;
            ThresholdValue = new int[3];
            ThresholdValue[0] = 127;

            lbl_Value.Text = ThresholdValue[0].ToString();

            _transformation = new Transformation();
            _Visible = bool.Parse(visible);
            Trackbar_1.Enabled = _Visible;
            groupBox_Threshold.Visible = _Visible;
            
        }

        public ThresholdTrackbarDialog(Bitmap processed, string visible)
        {
            _Visible = bool.Parse(visible);
            InitializeComponent();
            
            _g = CreateGraphics();
            ProcImg = processed;
            _transformation = new Transformation();
            Trackbar_1.Enabled = _Visible;
            groupBox_Threshold.Visible = _Visible;
        }

        private void Trackbar_1_Scroll(object sender, EventArgs e)
        {
            ThresholdValue[0] = Trackbar_1.Value;

            lbl_Value.Text = ThresholdValue[0].ToString();

            ProcImg = _process.Execute(ThresholdValue, _operation);

            Size destSize;
            var o = _transformation.ScaleWithMaintainedRatio(ProcImg, new Size(450, 450), out destSize);
            _g.DrawImage(o, new Rectangle(10, 10, destSize.Width, destSize.Height));

        }
        
        public void BininarizationSettingsDialog_Load(object sender, EventArgs e)
        {
            if (_process != null)
            {
                ProcImg = _process.Execute(ThresholdValue, _operation);
            }

            Size destSize;
            var o = _transformation.ScaleWithMaintainedRatio(ProcImg, new Size(450, 450), out destSize);
            _g.DrawImage(o, new Rectangle(10, 10, destSize.Width, destSize.Height));
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
           
        }

        private void ThresholdTrackbarDialog_Paint(object sender, PaintEventArgs e)
        {
            if (ProcImg != null)
            {
                Size destSize;
                var o = _transformation.ScaleWithMaintainedRatio(ProcImg, new Size(450, 450), out destSize);
                _g.DrawImage(o, new Rectangle(10, 10, destSize.Width, destSize.Height));

                
            }

        }

        
    }
}
