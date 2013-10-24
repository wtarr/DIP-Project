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

namespace DIP_START
{


    public partial class Form1 : Form
    {
        public Bitmap original_image, proc_image;
        public int[] bins = new int[256];
        int max;

        public Form1()
        {
            InitializeComponent();
            original_image = null;
            proc_image = null;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (original_image != null)
            {
                Graphics g = e.Graphics;
                Rectangle r = new Rectangle(10, 50, original_image.Width, original_image.Height);
                g.DrawImage(original_image, r);


            }

        }

        //                OPEN IMAGE FILE
        /******************************************************************************************/

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // show the openFile dialog box            
            Graphics g = this.CreateGraphics();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                original_image = new Bitmap(openFileDialog1.FileName);
                
            }
            
            Rectangle r = new Rectangle(10, 50, original_image.Width, original_image.Height);
            g.DrawImage(original_image, r);
        }
        //                 EXIT APPLICATION
        /************************************************************************************/

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
            Graphics g = this.CreateGraphics();

            int width = original_image.Width;
            int height = original_image.Height;

            Rectangle r = new Rectangle(535, 50, original_image.Width, original_image.Height);
            Rectangle r2 = new Rectangle(0, 0, original_image.Width, original_image.Height);

            proc_image = original_image.Clone(r2, PixelFormat.Format8bppIndexed);


            BitmapData bmData = proc_image.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                for (int y = 0; y < height; ++y)
                {
                    for (int x = 0; x < width; ++x)
                    {
                        p[0] = (byte)(255 - p[0]);
                        ++p;
                    }

                }
            }

            proc_image.UnlockBits(bmData);
           
            g.DrawImage(proc_image, r);


        }

        

      /*****************************************************************************************/

        /***********************************************************************************/
        //           Darken VIDEO
        /***********************************************************************************/
        private void DarkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            int width = original_image.Width;
            int height = original_image.Height;

            Rectangle r = new Rectangle(535, 50, original_image.Width, original_image.Height);
            Rectangle r2 = new Rectangle(0, 0, original_image.Width, original_image.Height);

            proc_image = original_image.Clone(r2, PixelFormat.Format8bppIndexed);


            BitmapData bmData = proc_image.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                for (int y = 0; y < height; ++y)
                {
                    for (int x = 0; x < width; ++x)
                    {
                       if(p[0] >120){
                           if (p[0] < 195)
                               p[0] = 0;
                       }
                        ++p;
                    }

                }
            }

            proc_image.UnlockBits(bmData);

            g.DrawImage(proc_image, r);


        }

        private void brightenToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void binariseToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int threshold = 100;

            int width = original_image.Width;
            int height = original_image.Height;

            Rectangle r = new Rectangle(535, 50, original_image.Width, original_image.Height);
            Rectangle r2 = new Rectangle(0, 0, original_image.Width, original_image.Height);

            proc_image = original_image.Clone(r2, PixelFormat.Format8bppIndexed);


            BitmapData bmData = proc_image.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                

                for (int y = 0; y < height; ++y)
                {
                    for (int x = 0; x < width; ++x)
                    {
                        p[0] = (byte)(255 - p[0]);
                        ++p;
                    }

                }

                byte* n = (byte*)(void*)Scan0;

                for (int y = 0; y < height; ++y)
                {
                    for (int x = 0; x < width; ++x)
                    {
                        if (n[0] < threshold)
                          n[0] = 0;
                        else
                            n[0] = 255;
                        ++n;
                    }

                }
            }

            proc_image.UnlockBits(bmData);

            g.DrawImage(proc_image, r);


        }









        /*****************************************************************************************/  
        
    }

}

