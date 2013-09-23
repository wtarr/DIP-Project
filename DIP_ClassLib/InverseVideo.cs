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
        public Bitmap inverse(Bitmap originalImage)
        {
            int width = originalImage.Width;
            int height = originalImage.Height;

            var r = new Rectangle(535, 50, originalImage.Width, originalImage.Height);
            var r2 = new Rectangle(0, 0, originalImage.Width, originalImage.Height);

            var procImage = originalImage.Clone(r2, PixelFormat.Format8bppIndexed);


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
