using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace DIP_ClassLib
{
    public class Filters : IUseTrackbarThresholding
    {
        private readonly Bitmap _original;

        public Filters(Bitmap orig)
        {
            _original = orig;
        }


        public Bitmap NeighbourhoodAveraging()
        {
            //Graphics g = this.CreateGraphics();

            int width = _original.Width;
            int height = _original.Height;

            Rectangle r = new Rectangle(535, 50, _original.Width, _original.Height);
            Rectangle r2 = new Rectangle(0, 0, _original.Width, _original.Height);

            Bitmap procImage = _original.Clone(r2, PixelFormat.Format8bppIndexed);


            BitmapData origData = _original.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
            BitmapData procData = procImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int strideOrig = origData.Stride;
            int strideProc = procData.Stride;

            System.IntPtr origScan0 = origData.Scan0;
            System.IntPtr procScan0 = procData.Scan0;

            unsafe
            {
                byte* o = (byte*)(void*)origScan0;
                byte* p = (byte*)(void*)procScan0;

               
                for (int y = 1; y < height; ++y)
                {
                    for (int x = 1; x < width; ++x)
                    {

                        var p1 = o[0];
                        var p2 = (o + 1)[0];
                        var p3 = (o + 2)[0];
                        var p4 = (o + strideOrig)[0];
                        //var p5 = (o + strideOrig + 1)[0];
                        var p6 = (o + strideOrig + 2)[0];
                        var p7 = (o + strideOrig * 2 + 1)[0];
                        var p8 = (o + strideOrig * 2 + 2)[0];
                        var p9 = (o + strideOrig * 2 + 3)[0];
                       
                        var avg = (byte)((p1 + p2 + p3 + p4 + p6 + p7 + p8 + p9) / 8);

                        (p + strideOrig + 1)[0] = avg;
                        
                        ++p;
                        ++o;

                    }

                }


            }

            _original.UnlockBits(origData);
            procImage.UnlockBits(procData);

            return procImage;
        }
        
        public Bitmap NeighbourhoodAveragingWithThresholding(int thresholding)
        {
            int width = _original.Width -2;
            int height = _original.Height -2;
            
            Rectangle r2 = new Rectangle(0, 0, _original.Width, _original.Height);

            Bitmap procImage = _original.Clone(r2, PixelFormat.Format8bppIndexed);


            BitmapData origData = _original.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
            BitmapData procData = procImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int strideOrig = origData.Stride;

            IntPtr origScan0 = origData.Scan0;
            var procScan0 = procData.Scan0;

            unsafe
            {
                byte* o = (byte*)(void*)origScan0;
                byte* p = (byte*)(void*)procScan0;


                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {

                        var p1 = o[0];
                        var p2 = (o + 1)[0];
                        var p3 = (o + 2)[0];
                        var p4 = (o + strideOrig)[0];
                        //var p5 = (o + strideOrig + 1)[0];
                        var p6 = (o + strideOrig + 2)[0];
                        var p7 = (o + strideOrig * 2 + 1)[0];
                        var p8 = (o + strideOrig * 2 + 2)[0];
                        var p9 = (o + strideOrig * 2 + 3)[0];

                        var avg = (byte)((p1 + p2 + p3 + p4 + p6 + p7 + p8 + p9) / 8);

                        // if below threshold change else leave alone
                        if ((p + strideOrig + 1)[0] <= thresholding)
                            (p + strideOrig + 1)[0] = avg;

                        p++;
                        o++;

                    }

                }


            }

            _original.UnlockBits(origData);
            procImage.UnlockBits(procData);

            return procImage;
        }

        public Bitmap MedianFiltering()
        {
            int width = _original.Width;
            int height = _original.Height;

            Rectangle r2 = new Rectangle(0, 0, _original.Width, _original.Height);

            Bitmap procImage = _original.Clone(r2, PixelFormat.Format8bppIndexed);


            BitmapData origData = _original.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
            BitmapData procData = procImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int strideOrig = origData.Stride;

            IntPtr origScan0 = origData.Scan0;
            var procScan0 = procData.Scan0;
            
            List<Byte> byteMe = new List<byte>();

            unsafe
            {
                byte* o = (byte*)(void*)origScan0;
                byte* p = (byte*)(void*)procScan0;


                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {

                        var p1 = o[0];
                        var p2 = (o + 1)[0];
                        var p3 = (o + 2)[0];
                        var p4 = (o + strideOrig)[0];
                        var p5 = (o + strideOrig + 1)[0];
                        var p6 = (o + strideOrig + 2)[0];
                        var p7 = (o + strideOrig * 2 + 1)[0];
                        var p8 = (o + strideOrig * 2 + 2)[0];
                        var p9 = (o + strideOrig * 2 + 3)[0];

                        byteMe = new List<byte>() { p1, p2, p3, p4, p5, p6, p7, p8, p9 };

                        byteMe.Sort();

                        (p + strideOrig + 1)[0] = byteMe[5];
                       
                        p++;
                        o++;

                    }

                }


            }

            _original.UnlockBits(origData);
            procImage.UnlockBits(procData);

            return procImage;
        }

        public Bitmap Execute(int threshold, Process proc)
        {
            return NeighbourhoodAveragingWithThresholding(threshold);
        }
    }
}
