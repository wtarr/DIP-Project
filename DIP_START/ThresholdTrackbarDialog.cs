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

        private Bitmap _procImg;

        private Process _operation;

        public ThresholdTrackbarDialog(IUseTrackbarThresholding process, Process operation)
        {
            InitializeComponent();
            _g = CreateGraphics();
            _process = process;
            _operation = operation;
            ThresholdValue = new int[3];
            ThresholdValue[0] = 127;

            lbl_Value.Text = ThresholdValue[0].ToString();

            _transformation = new Transformation();
            
        }

        public ThresholdTrackbarDialog(Bitmap processed)
        {
            InitializeComponent();
            Trackbar_1.Enabled = false;
            _g = CreateGraphics();
            _procImg = processed;
            _transformation = new Transformation();

            groupBox_Threshold.Visible = false;
        }

        private void Trackbar_1_Scroll(object sender, EventArgs e)
        {
            ThresholdValue[0] = Trackbar_1.Value;

            lbl_Value.Text = ThresholdValue[0].ToString();

            _procImg = _process.Execute(ThresholdValue, _operation);

            Size destSize;
            var o = _transformation.ScaleWithMaintainedRatio(_procImg, new Size(450, 450), out destSize);
            _g.DrawImage(o, new Rectangle(10, 10, destSize.Width, destSize.Height));

        }

        public void BininarizationSettingsDialog_Load(object sender, EventArgs e)
        {
            if (_process != null)
            {
                _procImg = _process.Execute(ThresholdValue, _operation);
            }

            Size destSize;
            var o = _transformation.ScaleWithMaintainedRatio(_procImg, new Size(450, 450), out destSize);
            _g.DrawImage(o, new Rectangle(10, 10, destSize.Width, destSize.Height));
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apply image and update history");
        }

        private void ThresholdTrackbarDialog_Paint(object sender, PaintEventArgs e)
        {
            if (_procImg != null)
            {
                Size destSize;
                var o = _transformation.ScaleWithMaintainedRatio(_procImg, new Size(450, 450), out destSize);
                _g.DrawImage(o, new Rectangle(10, 10, destSize.Width, destSize.Height));

                
            }

        }

        
    }
}
