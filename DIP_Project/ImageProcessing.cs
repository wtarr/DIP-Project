using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using DIP_START;

namespace DIP_Project
{
    public class ImageProcessing
    {
        //public Bitmap original_image, proc_image;

        public ImageProcessing()
        {
            
        }

        // -----------------------------------------
        // -------------- Inverse ------------------
        // -----------------------------------------

        private Bitmap InverseVideo(Bitmap original)
        {
            
            int width = original.Width;
            int height = original.Height;

            Rectangle r = new Rectangle(535, 50, width, height);
            Rectangle r2 = new Rectangle(0, 0, width, height);

            var proc_image = original.Clone(r2, PixelFormat.Format8bppIndexed);


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

            return proc_image;
        }

        // -----------------------------------------
        // -------------- Darken- ------------------
        // -----------------------------------------

        private Bitmap Darken(Bitmap original)
        {
            int width = original.Width;
            int height = original.Height;

            Rectangle r = new Rectangle(535, 50, width, height);
            Rectangle r2 = new Rectangle(0, 0, width, height);

            var proc_image = original.Clone(r2, PixelFormat.Format8bppIndexed);

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
                        if (p[0] > 120)
                        {
                            if (p[0] < 195)
                                p[0] = 0;
                        }
                        ++p;
                    }

                }
            }

            proc_image.UnlockBits(bmData);

            return proc_image;
        }

        // -----------------------------------------
        // -------------- Brighten------------------
        // -----------------------------------------

        private Bitmap Brighten(Bitmap original)
        {
            int width = original.Width;
            int height = original.Height;
            
            Rectangle r2 = new Rectangle(0, 0, width, height);

            var procImage = original.Clone(r2, PixelFormat.Format8bppIndexed);


            BitmapData bmData = procImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                for (int y = 0; y < height; ++y)
                {
                    for (int x = 0; x < width; ++x)
                    {

                        if (p[0] > 10 && p[0] < 100)
                        {
                            p[0] = 255;
                        }

                        ++p;
                    }

                }
            }

            procImage.UnlockBits(bmData);

            return procImage;
        }

        // -----------------------------------------
        // -------------- Binarize------------------
        // -----------------------------------------

        public Bitmap Binarize(Bitmap original)
        {
            int width = original.Width;
            int height = original.Height;

            Rectangle r2 = new Rectangle(0, 0, width, height);

            Bitmap procImage = original.Clone(r2, PixelFormat.Format8bppIndexed);

            BitmapData bmData = procImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite,
                PixelFormat.Format8bppIndexed);

            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                for (var y = 0; y < height; y++)
                {
                    for (var x = 0; x < width; x++)
                    {
                        if (*p >= MainInterface.ThresholdValue)
                        {
                            *p = 255;

                            if (MainInterface.ThresholdValue == 255 && *p == 255)
                                *p = 0;
                        }
                        else
                        {
                            *p = 0;

                        }

                        p++;
                    }

                }
            }

            procImage.UnlockBits(bmData);

            return procImage;
        }

        // -----------------------------------------
        // ------- Neighbourhood Averaging----------
        // -----------------------------------------

        public Bitmap NeighbourhoodAveraging(Bitmap original)
        {
            // One method will serve Averaging with and Without thresholding

            int width = original.Width - 2;
            int height = original.Height - 2;

            Rectangle r2 = new Rectangle(0, 0, original.Width, original.Height);

            Bitmap procImage = original.Clone(r2, PixelFormat.Format8bppIndexed);


            BitmapData origData = original.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
            BitmapData procData = procImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int strideOrig = origData.Stride;

            IntPtr origScan0 = origData.Scan0;
            var procScan0 = procData.Scan0;

            unsafe
            {
                byte* o = (byte*)(void*)origScan0;
                byte* p = (byte*)(void*)procScan0;


                for (int y = 0; y < height; ++y)
                {
                    // Ensure on correct row
                    p = (byte*)(void*)procScan0 + (y * strideOrig);
                    o = (byte*)(void*)origScan0 + (y * strideOrig);

                    for (int x = 0; x < width; ++x)
                    {
                        var p1 = *o;
                        var p2 = *(o + 1);
                        var p3 = *(o + 2);

                        var p4 = *(o + strideOrig);
                        //var p5 = (o + strideOrig + 1)[0];
                        var p6 = *(o + strideOrig + 2);

                        var p7 = *(o + strideOrig * 2);
                        var p8 = *(o + strideOrig * 2 + 1);
                        var p9 = *(o + strideOrig * 2 + 2);

                        var avg = (byte)((p1 + p2 + p3 + p4 + p6 + p7 + p8 + p9) / 8);

                        // if below threshold change else leave alone
                        if (*(p + strideOrig + 1) <= MainInterface.ThresholdValue)
                            *(p + strideOrig + 1) = avg;

                        ++p;
                        ++o;
                    }

                }
            }

            original.UnlockBits(origData);
            procImage.UnlockBits(procData);

            return procImage;
        }

        // -----------------------------------------
        // --------- Median Filtering---------------
        // -----------------------------------------

        public Bitmap Median(Bitmap original)
        {
            int width = original.Width - 2;
            int height = original.Height - 2;

            Rectangle r2 = new Rectangle(0, 0, width, height);

            Bitmap procImage = original.Clone(r2, PixelFormat.Format8bppIndexed);


            BitmapData origData = original.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
            BitmapData procData = procImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int strideOrig = origData.Stride;

            IntPtr origScan0 = origData.Scan0;
            var procScan0 = procData.Scan0;

            List<Byte> byteMe = new List<byte>();

            unsafe
            {
                byte* o = (byte*)(void*)origScan0;
                byte* p = (byte*)(void*)procScan0;

                for (int y = 0; y < height; ++y)
                {
                    // Ensure on correct row
                    p = (byte*)(void*)procScan0 + (y * strideOrig);
                    o = (byte*)(void*)origScan0 + (y * strideOrig);

                    for (int x = 0; x < width; ++x)
                    {
                        var p1 = *o;
                        var p2 = *(o + 1);
                        var p3 = *(o + 2);

                        var p4 = *(o + strideOrig);
                        var p5 = *(o + strideOrig + 1);
                        var p6 = *(o + strideOrig + 2);

                        var p7 = *(o + strideOrig * 2);
                        var p8 = *(o + strideOrig * 2 + 1);
                        var p9 = *(o + strideOrig * 2 + 2);

                        byteMe = new List<byte>() { p1, p2, p3, p4, p5, p6, p7, p8, p9 };

                        byteMe.Sort();

                        *(p + strideOrig + 1) = byteMe[4];

                        ++p;
                        ++o;
                    }

                }
            }

            original.UnlockBits(origData);
            procImage.UnlockBits(procData);

            return procImage;
        }

        // -----------------------------------------
        // --------- Roberts Gradient --------------
        // ----------With and Without --------------
        // ----------Thresholding-------------------
        // -----------------------------------------

        public Bitmap RobertsGradient(Bitmap original)
        {
            const int borderAllowance = 1;

            int width = original.Width - borderAllowance;
            int height = original.Height - borderAllowance;

            Rectangle r2 = new Rectangle(0, 0, width, height);

            Bitmap procImage = original.Clone(r2, PixelFormat.Format8bppIndexed);


            BitmapData origData = original.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
            BitmapData procData = procImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int strideOrig = origData.Stride;

            IntPtr origScan0 = origData.Scan0;
            var procScan0 = procData.Scan0;

            List<Byte> byteMe = new List<byte>();

            unsafe
            {
                byte* o = (byte*)(void*)origScan0;
                byte* p = (byte*)(void*)procScan0;


                for (int y = 0; y < height; ++y)
                {
                    // Ensure on correct row
                    p = (byte*)(void*)procScan0 + (y * strideOrig);
                    o = (byte*)(void*)origScan0 + (y * strideOrig);

                    for (int x = 0; x < width; ++x)
                    {

                        var a = *o;
                        var b = *(o + 1);

                        var c = *(o + strideOrig);
                        var d = *(o + strideOrig + 1);

                        var result = Math.Abs(a - b) + Math.Abs(c - d);

                        if (result >= MainInterface.ThresholdValue && MainInterface.ThresholdValue != 255)
                            *p = (byte)result;
                        // White or Black
                        ++p;
                        ++o;

                    }

                }

            }

            original.UnlockBits(origData);
            procImage.UnlockBits(procData);

            return procImage;
        }

        public Bitmap RobertsGradientWithPseudo(Bitmap original)
        {
            const int borderAllowance = 1;
            int width = original.Width - borderAllowance;
            int height = original.Height - borderAllowance;

            Rectangle r2 = new Rectangle(0, 0, width, height);

            Bitmap procImage = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            using (Graphics g = Graphics.FromImage(procImage))
            {
                g.PageUnit = GraphicsUnit.Pixel;
                g.DrawImage(original, r2);
            }

            BitmapData origData = original.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);

            int strideOrig = origData.Stride;

            IntPtr origScan0 = origData.Scan0;

            List<Byte> byteMe = new List<byte>();

            unsafe
            {
                byte* o = (byte*)(void*)origScan0;

                for (int y = 0; y < height; ++y)
                {
                    o = (byte*)(void*)origScan0 + (y * strideOrig);

                    for (int x = 0; x < width; ++x)
                    {

                        var a = *o;
                        var b = *(o + 1);


                        var c = *(o + strideOrig);
                        var d = *(o + strideOrig + 1);

                        var result = Math.Abs(a - b) + Math.Abs(c - d);

                        if (result >= MainInterface.ThresholdValue && MainInterface.ThresholdValue != 255)
                        {
                            procImage.SetPixel(x, y, Color.Red);
                        }

                        ++o;
                    }
                }

            }
            original.UnlockBits(origData);

            return procImage;
        }



        public Bitmap Execute(Process process, Bitmap original)
        {
            switch (process)
            {
                case Process.Inverse:
                    return InverseVideo(original);
                case Process.Darken:
                    return Darken(original);
                case Process.Brighten:
                    return Brighten(original);
                case Process.Binarize:
                    return Binarize(original);
                case Process.NeighbourhoodAveraging:
                    return NeighbourhoodAveraging(original);
                case Process.Median:
                    return Median(original);
                case Process.RobertsGradientDirect:
                case Process.RobertsGradientWithThresholding:
                    return RobertsGradient(original);
                case Process.RobertsGradientWithPseudoColor:
                    return RobertsGradientWithPseudo(original);
                    
                    
                default:
                    return null;
            }
            
        }

    }
}
