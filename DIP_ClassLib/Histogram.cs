using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace DIP_ClassLib
{
    public class Histogram
    {
        public int[] Bins;


        private Bitmap _orig;

        public Histogram(Bitmap orig)
        {
            _orig = orig;
            Bins = new int[256];
        }

        public Histogram()
        {
            Bins = new int[256];
        }

        public int[] CalculateBins(Bitmap _orig)
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

        public Bitmap EqualisedHistogram()
        {

            int[] Bins = CalculateBins(_orig);

            int n = _orig.Width * _orig.Height;

            double[] nkn = new double[256];
            double[] cdf = new double[256];


            double runningTotal = 0;

            for (int i = 0; i < Bins.Length; i++)
            {
                var nV = Bins[i]/(double)n;

                nkn[i] = nV;

                runningTotal += nV;

                cdf[i] = runningTotal;
            }



            int width = _orig.Width;
            int height = _orig.Height;

            Bitmap newBitmap = _orig.Clone(new Rectangle(0, 0, width, height), PixelFormat.Format8bppIndexed);

            BitmapData newData = newBitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite,
                PixelFormat.Format8bppIndexed);
            
            BitmapData bmData = _orig.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly,
                PixelFormat.Format8bppIndexed);


            IntPtr nScan0 = newData.Scan0;
            IntPtr oScan0 = bmData.Scan0;

            unsafe
            {
                byte* o = (byte*)(void*)oScan0;
                byte* p = (byte*)(void*)nScan0;


                for (var y = 0; y < height; y++)
                {
                    for (var x = 0; x < width; x++)
                    {
                        double b = Math.Round(cdf[*o]*255);
                        *p = (byte)b;
                        //Console.WriteLine(b); 
                        o++;
                        p++;
                    }

                }
            }

            newBitmap.UnlockBits(newData);
            _orig.UnlockBits(bmData);

            return newBitmap;
        }
    }
}
