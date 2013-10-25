using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO.Compression;
using System.Linq;
using System.Text;
using DIP_START;

namespace DIP_Project
{
    public class ThresholdEventArgs : EventArgs
    {
        public int Max { get; set; }

        public ThresholdEventArgs(int newMax)
        {
            Max = newMax;
        }
    }

    public class ImageProcessing
    {
        public event EventHandler MaxValueChanged;

        public void OnMaxChanged(ThresholdEventArgs e)
        {
            if (MaxValueChanged != null)
                MaxValueChanged(this, e);
        }

        private int _maxValue = 255; // going to be 255 at very least

        //public Bitmap original_image, proc_image;
        private readonly int[] _sobelGx = new[] { -1, -2, -1, 0, 0, 0, 1, 2, 1 };
        private readonly int[] _sobelGy = new[] { -1, 0, 1, -2, 0, 2, -1, 0, 1 };
        private readonly int[] _laplacian = new[] { 0, 1, 0, 1, -4, 1, 0, 1, 0 };
        private readonly int[] _pointDet = new[] { -1, -1, -1, -1, 8, -1, -1, -1, -1 };
        private readonly int[] _horizontal = new[] { -1, -1, -1, 2, 2, 2, -1, -1, -1 };
        private readonly int[] _vertical = new[] { -1, 2, -1, -1, 2, -1, -1, 2, -1 };
        private readonly int[] _pos45 = new[] { -1, -1, 2, -1, 2, -1, 2, -1, -1 };
        private readonly int[] _neg45 = new[] { 2, -1, -1, -1, 2, -1, -1, -1, 2 };


        public ImageProcessing()
        {

        }

        // -----------------------------------------
        // -------------- Inverse ------------------
        // -----------------------------------------

        private Bitmap InverseVideo(Bitmap original, int threshold)
        {
            MaxValueChanged(this, new ThresholdEventArgs(255));

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

        private Bitmap Darken(Bitmap original, int threshold)
        {
            MaxValueChanged(this, new ThresholdEventArgs(255));

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

        private Bitmap Brighten(Bitmap original, int threshold)
        {
            MaxValueChanged(this, new ThresholdEventArgs(255));

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

        public Bitmap Binarize(Bitmap original, int threshold)
        {
            MaxValueChanged(this, new ThresholdEventArgs(255));

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
                        if (*p >= threshold)
                        {
                            *p = 255;

                            if (threshold == 255 && *p == 255)
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

        public Bitmap NeighbourhoodAveraging(Bitmap original, int threshold)
        {
            MaxValueChanged(this, new ThresholdEventArgs(255));
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
                        if (*(p + strideOrig + 1) <= threshold)
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

        public Bitmap Median(Bitmap original, int threshold)
        {
            MaxValueChanged(this, new ThresholdEventArgs(255));

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

        public Bitmap RobertsGradient(Bitmap original, int threshold)
        {
            MaxValueChanged(this, new ThresholdEventArgs(255));

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

                        if (result >= threshold && threshold != 255)
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

        // ------------------------------------------------------
        // -------Roberts Gradient With Pseudo ------------------
        // ------------------------------------------------------

        public Bitmap RobertsGradientWithPseudo(Bitmap original, int threshold)
        {
            MaxValueChanged(this, new ThresholdEventArgs(255));

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

                        if (result >= threshold && threshold != 255)
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

        // ----------------------------------------------------
        // ------ Sobel/Laplacian/Point/Line Filters ----------
        // ----------------------------------------------------

        public Bitmap Execute_Filter(Bitmap original, int[] filter, int threshold)
        {
            MaxValueChanged(this, new ThresholdEventArgs(_maxValue));

            const int borderAllowance = 2;

            int width = original.Width - borderAllowance;
            int height = original.Height - borderAllowance;

            var _3X3Selection = new int[9];

            Rectangle r2 = new Rectangle(0, 0, original.Width, original.Height);

            Bitmap procImage = original.Clone(r2, PixelFormat.Format8bppIndexed);

            BitmapData origData = original.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
            BitmapData procData = procImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int strideOrig = origData.Stride;

            System.IntPtr origScan0 = origData.Scan0;
            System.IntPtr procScan0 = procData.Scan0;

            unsafe
            {
                byte* o = (byte*)(void*)origScan0;
                byte* p = (byte*)(void*)procScan0;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {

                        _3X3Selection[0] = o[y * strideOrig + x];
                        _3X3Selection[1] = o[y * strideOrig + x + 1];
                        _3X3Selection[2] = o[y * strideOrig + x + 2];

                        _3X3Selection[3] = o[(y + 1) * strideOrig + x];
                        _3X3Selection[4] = o[(y + 1) * strideOrig + x + 1];
                        _3X3Selection[5] = o[(y + 1) * strideOrig + x + 2];

                        _3X3Selection[6] = o[(y + 2) * strideOrig + x];
                        _3X3Selection[7] = o[(y + 2) * strideOrig + x + 1];
                        _3X3Selection[8] = o[(y + 2) * strideOrig + x + 2];

                        int gx = 0;

                        for (int i = 0; i < _3X3Selection.Length; i++)
                        {
                            gx += filter[i] * _3X3Selection[i];
                        }

                        if (Math.Abs(gx) >= threshold)
                        {
                            p[(y + 1) * strideOrig + x + 1] = 255;
                        }
                        else
                        {
                            p[(y + 1) * strideOrig + x + 1] = 0;
                        }

                        if (gx > _maxValue)
                        {
                            double m = Math.Ceiling(gx / 100f) * 100;
                            _maxValue = (int)m;
                        }

                    }
                }
            }

            original.UnlockBits(origData);
            procImage.UnlockBits(procData);

            return procImage;

        }

        private Bitmap Calculate_GxGy(Bitmap original, int threshold)
        {
            MaxValueChanged(this, new ThresholdEventArgs(_maxValue));
            // compare gx and gy and if either is greater than the threshold then 255
            // else 0
            const int BorderAllowance = 2;


            var width = original.Width - BorderAllowance;
            var height = original.Height - BorderAllowance;

            Bitmap newBitmap = new Bitmap(
                width, height, PixelFormat.Format8bppIndexed);

            int[] _3X3Selection = new int[9];

            BitmapData origData = original.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
            BitmapData procData = newBitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int strideOrig = origData.Stride;

            System.IntPtr origScan0 = origData.Scan0;
            System.IntPtr newScan0 = procData.Scan0;

            unsafe
            {
                byte* o = (byte*)(void*)origScan0;
                byte* c = (byte*)(void*)newScan0;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {

                        _3X3Selection[0] = o[y * strideOrig + x];
                        _3X3Selection[1] = o[y * strideOrig + x + 1];
                        _3X3Selection[2] = o[y * strideOrig + x + 2];

                        _3X3Selection[3] = o[(y + 1) * strideOrig + x];
                        _3X3Selection[4] = o[(y + 1) * strideOrig + x + 1];
                        _3X3Selection[5] = o[(y + 1) * strideOrig + x + 2];

                        _3X3Selection[6] = o[(y + 2) * strideOrig + x];
                        _3X3Selection[7] = o[(y + 2) * strideOrig + x + 1];
                        _3X3Selection[8] = o[(y + 2) * strideOrig + x + 2];

                        int gx = 0;
                        int gy = 0;

                        for (int i = 0; i < _3X3Selection.Length; i++)
                        {
                            gx += _sobelGx[i] * _3X3Selection[i];
                        }

                        for (int i = 0; i < _3X3Selection.Length; i++)
                        {
                            gy += _sobelGy[i] * _3X3Selection[i];
                        }

                        if (Math.Abs(gx) + Math.Abs(gy) >= threshold)
                        {
                            c[(y + 1) * strideOrig + x + 1] = 255;
                        }
                        else
                        {
                            c[(y + 1) * strideOrig + x + 1] = 0;
                        }

                        if ((Math.Abs(gx) + Math.Abs(gy)) > _maxValue)
                        {
                            double m = Math.Ceiling((Math.Abs(gx) + Math.Abs(gy)) / 100f) * 100;
                            _maxValue = (int)m;
                        }
                    }
                }
            }

            original.UnlockBits(origData);
            newBitmap.UnlockBits(procData);

            return newBitmap;

        }

        //------------------------------------------------
        //-----------Calculate Histogram Bins-------------
        //------------------------------------------------

        public int[] CalculateHistogramBins(Bitmap _orig)
        {
            int[] Bins = new int[256];
            
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



        public Bitmap Execute(Process process, Bitmap original, int threshold)
        {
            switch (process)
            {
                case Process.Inverse:
                    return InverseVideo(original, threshold);
                case Process.Darken:
                    return Darken(original, threshold);
                case Process.Brighten:
                    return Brighten(original, threshold);
                case Process.Binarize:
                    return Binarize(original, threshold);
                case Process.NeighbourhoodAveraging:
                    return NeighbourhoodAveraging(original, threshold);
                case Process.Median:
                    return Median(original, threshold);
                case Process.RobertsGradientDirect:
                case Process.RobertsGradientWithThresholding:
                    return RobertsGradient(original, threshold);
                case Process.RobertsGradientWithPseudoColor:
                    return RobertsGradientWithPseudo(original, threshold);
                case Process.SobelGx:
                    return Execute_Filter(original, _sobelGx, threshold);
                case Process.SobelGy:
                    return Execute_Filter(original, _sobelGy, threshold);
                case Process.SobelGxGy:
                    return Calculate_GxGy(original, threshold);
                case Process.Laplacian:
                    return Execute_Filter(original, _laplacian, threshold);
                case Process.PointDetection:
                    return Execute_Filter(original, _pointDet, threshold);
                case Process.HorizontalLine:
                    return Execute_Filter(original, _horizontal, threshold);
                case Process.VerticalLine:
                    return Execute_Filter(original, _vertical, threshold);
                case Process.Pos45DegreeLine:
                    return Execute_Filter(original, _pos45, threshold);
                case Process.Negative45DegreeLine:
                    return Execute_Filter(original, _neg45, threshold);
                default:
                    return null;
            }

        }

    }
}
