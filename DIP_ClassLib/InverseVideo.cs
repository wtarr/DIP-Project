using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace DIP_ClassLib
{
    public class InverseVideo
    {

        private Bitmap orig;

        public InverseVideo(Bitmap orig)
        {
            this.orig = orig;
        }

        public Bitmap Inverse()
        {
            int width = orig.Width;
            int height = orig.Height;

            var r = new Rectangle(535, 50, orig.Width, orig.Height);
            var r2 = new Rectangle(0, 0, orig.Width, orig.Height);

            var procImage = orig.Clone(r2, PixelFormat.Format8bppIndexed);


            BitmapData bmData = procImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite,
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
                        p[0] = (byte)(255 - p[0]);
                        ++p;
                    }
                }
            }

            procImage.UnlockBits(bmData);

            return procImage;

        }
    }
}
