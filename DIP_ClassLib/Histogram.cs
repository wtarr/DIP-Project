using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace DIP_ClassLib
{
    public class Histogram
    {
        public int[] Bins;
        private readonly Bitmap _orig;

        public Histogram(Bitmap orig)
        {
            _orig = orig;
            Bins = new int[256];
        }

        public int[] CalculateBins()
        {

            int width = _orig.Width;
            int height = _orig.Height;
            

            BitmapData bmData = _orig.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite,
                PixelFormat.Format8bppIndexed);

            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                for (var y = 0; y < height; y++)
                {
                    for (var x = 0; x < width; x++)
                    {
                        Bins[*p]++;

                        p++;
                    }

                }
            }

            _orig.UnlockBits(bmData);

            return Bins;


        }
    }
}
