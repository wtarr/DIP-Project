using System;
using System.CodeDom.Compiler;
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
using DIP_Project;

namespace DIP_START
{
    public partial class MainInterface : Form
    {
        public static int ThresholdValue;
        private int thresholdDefault = 127;
        private Graphics _g;
        private readonly ImageProcessing _imgProcessing;
        private Process _currentProcess;
        public Bitmap OriginalImage, ProcImage;
        

        public MainInterface()
        {
            ThresholdValue = 127;
            InitializeComponent();
            OriginalImage = null;
            ProcImage = null;
            _g = CreateGraphics();
            _imgProcessing = new ImageProcessing();
            thresholdPanel.Enabled = false;

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
            main_Trackbar.Value = thresholdDefault;

            if (itemClicked != null)
            {
               

                String[] array = itemClicked.Name.Split('_');
                _currentProcess = (Process)Enum.Parse(typeof (Process), array[0]);

                thresholdPanel.Enabled = Boolean.Parse(array[1]);

                ProcImage = _imgProcessing.Execute((Process) _currentProcess, OriginalImage);
                pBox_ProcImg.Image = ProcImage;
            }
        }
       

        private void main_Trackbar_Scroll(object sender, System.EventArgs e)
        {
            ThresholdValue = main_Trackbar.Value;
            lblThresholdValue.Text = ThresholdValue.ToString();
            ProcImage = _imgProcessing.Execute(_currentProcess, OriginalImage);
            pBox_ProcImg.Image = ProcImage;
        }

        private void main_Trackbar_ValueChanged(object sender, System.EventArgs e)
        {
            ThresholdValue = main_Trackbar.Value;
            lblThresholdValue.Text = ThresholdValue.ToString();
        }









        
        
    }

}

