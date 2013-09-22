using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_ClassLib
{
    public class Binarization
    {
        public Bitmap Binarize(int threshold, Bitmap orig)
        {
            //Graphics g = this.CreateGraphics();

            int width = orig.Width;
            int height = orig.Height;

            Rectangle r = new Rectangle(535, 50, width, height);
            Rectangle r2 = new Rectangle(0, 0, width, height);

            Bitmap proc_image = orig.Clone(r2, PixelFormat.Format8bppIndexed);

            BitmapData bmData = proc_image.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite,
                PixelFormat.Format8bppIndexed);

            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                for (int y = 0; y < height; ++y)
                {
                    for (int x = 0; x < width; ++x)
                    {
                        if (p[0] > threshold)
                            p[0] = 255;
                        else
                            p[0] = 0;
                        ++p;
                    }

                }
            }

            proc_image.UnlockBits(bmData);

            return proc_image;

            //g.DrawImage(proc_image, r);
        }
        

    }



}
