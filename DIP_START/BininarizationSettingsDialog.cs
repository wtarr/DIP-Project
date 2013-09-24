using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DIP_START
{
    public partial class BininarizationSettingsDialog : Form
    {
        public event EventHandler OnTrackBarChange;
        
        public int ThresholdValue { get; private set; } 

        public BininarizationSettingsDialog()
        {
            InitializeComponent();
            ThresholdValue = 127;
            lbl_Value.Text = ThresholdValue.ToString();
            //Trackbar_Threshold.Value = ThresholdValue;
        }

        private void Trackbar_Threshold_Scroll(object sender, EventArgs e)
        {
            ThresholdValue = Trackbar_Threshold.Value;
            lbl_Value.Text = ThresholdValue.ToString();

            var ev = new MyEventArgs {Value = Trackbar_Threshold.Value};

            if (OnTrackBarChange != null)
                OnTrackBarChange(this, ev);
        }

        public void BininarizationSettingsDialog_Load(object sender, EventArgs e)
        {
            //var ev = new MyEventArgs { Value = Trackbar_Threshold.Value };

            //if (OnTrackBarChange != null)
            //    OnTrackBarChange(this, ev);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apply image and update history");
        }
    }

    public class MyEventArgs : EventArgs
    {
        public int Value { get; set; }
    }
    
}
