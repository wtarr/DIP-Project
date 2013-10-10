using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace DIP_ClassLib
{
    public class SharpenFilters : IUseTrackbarThresholding
    {
        private readonly Bitmap _original;
        private const int BorderAllowance = 2;
        
        public int GxTrackbar { get; set; }
        public int GyTrackbar { get; set; }

        private int[] _sobelGx = new[] {-1, -2, -1, 0, 0, 0, 1, 2, 1};
        private int[] _sobelGy = new[] {-1, 0, 1, -2, 0, 2, -1, 0, 1};
        private int[] _laplacian = new[] {0, 1, 0, 1, -4, 1, 0, 1, 0};
        private int[] _pointDet = new[] {-1, -1, -1, -1, 8, -1, -1, -1, -1};
        private int[] _horizontal = new[] {-1, -1, -1, 2, 2, 2, -1, -1, -1};
        private int[] _vertical = new[] {-1, 2, -1, -1, 2, -1, -1, 2, -1};
        private int[] _pos45 = new[] {-1, -1, 2, -1, 2, -1, 2, -1, -1};
        private int[] _neg45 = new[] {2, -1, -1, -1, 2, -1, -1, -1, 2};

        private int[] _3x3Selection = new int[9];

        public SharpenFilters(Bitmap original)
        {
            _original = original;
        }

        public Bitmap Execute_Filter(int threshold, int[] filter)
        {
            int width = _original.Width - BorderAllowance;
            int height = _original.Height - BorderAllowance;

            Rectangle r = new Rectangle(535, 50, _original.Width, _original.Height);
            Rectangle r2 = new Rectangle(0, 0, _original.Width, _original.Height);

            Bitmap procImage = _original.Clone(r2, PixelFormat.Format8bppIndexed);

            BitmapData origData = _original.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
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

                        _3x3Selection[0] = o[y * strideOrig + x];
                        _3x3Selection[1] = o[y * strideOrig + x + 1];
                        _3x3Selection[2] = o[y * strideOrig + x + 2];

                        _3x3Selection[3] = o[(y + 1) * strideOrig + x];
                        _3x3Selection[4] = o[(y + 1) * strideOrig + x + 1];
                        _3x3Selection[5] = o[(y + 1) * strideOrig + x + 2];

                        _3x3Selection[6] = o[(y + 2) * strideOrig + x];
                        _3x3Selection[7] = o[(y + 2) * strideOrig + x + 1];
                        _3x3Selection[8] = o[(y + 2) * strideOrig + x + 2];
                        
                        int gx = 0;

                        for (int i = 0; i < _3x3Selection.Length; i++)
                        {
                            gx += filter[i]*_3x3Selection[i];
                        }
                        
                        if (gx >= threshold)
                        {
                            p[(y + 1) * strideOrig + x + 1] = 255;
                        }
                        else
                        {
                            p[(y + 1) * strideOrig + x + 1] = 0;
                        }
                        
                        
                    }
                }
            }

            _original.UnlockBits(origData);
            procImage.UnlockBits(procData);

            return procImage;

        }

        public Bitmap Calculate_Gy(int threshold)
        {
            int width = _original.Width - BorderAllowance;
            int height = _original.Height - BorderAllowance;

            Rectangle r = new Rectangle(535, 50, _original.Width, _original.Height);
            Rectangle r2 = new Rectangle(0, 0, _original.Width, _original.Height);

            Bitmap procImage = _original.Clone(r2, PixelFormat.Format8bppIndexed);

            BitmapData origData = _original.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
            BitmapData procData = procImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int strideOrig = origData.Stride;

            System.IntPtr origScan0 = origData.Scan0;
            System.IntPtr procScan0 = procData.Scan0;

            unsafe
            {
                byte* o = (byte*)(void*)origScan0;
                byte* p = (byte*)(void*)procScan0;

                for (int y = 0; y < height; ++y)
                {
                    for (int x = 0; x < width; ++x)
                    {

                        var a = o[y * strideOrig + x];
                        var b = o[y * strideOrig + x + 1];
                        var c = o[y * strideOrig + x + 2];

                        var d = o[(y + 1) * strideOrig + x];
                        var e = o[(y + 1) * strideOrig + x + 1];
                        var f = o[(y + 1) * strideOrig + x + 2];

                        var g = o[(y + 2) * strideOrig + x];
                        var h = o[(y + 2) * strideOrig + x + 1];
                        var i = o[(y + 2) * strideOrig + x + 2];

                        var gy = Math.Abs(c + 2 * f + i) - Math.Abs(a + 2 * d + g);

                       

                        if (gy >= threshold)
                        {
                            p[(y + 1)*strideOrig + x + 1] = 255;
                        }
                        else
                        {
                            p[(y + 1) * strideOrig + x + 1] = 0;
                        }
                    }
                }
            }

            _original.UnlockBits(origData);
            procImage.UnlockBits(procData);

            return procImage;


        }


        public Bitmap Execute(int[] threshold, Process process)
        {
            switch (process)
            {
                case Process.SobelGx:
                    return Execute_Filter(threshold[0], _sobelGx);
                case Process.SobelGy:
                    return Calculate_Gy(threshold[0]);
                case Process.SobelGxGy:
                    return Calculate_GxGy(threshold);
                case Process.Laplacian:
                    return Calculate_Laplacian(threshold[0]);
                case Process.PointDetection:
                    return PointDetection(threshold[0]);
                case Process.HorizontalLine:
                    return HorizontalLineDetection(threshold[0]);
                case Process.VerticalLine:
                    return VerticalLineDetection(threshold[0]);
                case Process.Positive45DegreeLine:
                    return Positive45DegreeLine(threshold[0]);
                case Process.Negative45DegreeLine:
                    return Negative45DegreeLine(threshold[0]);
            }

            throw new Exception("Needs a process");
        }

        

        private Bitmap Calculate_GxGy(int[] threshold)
        {

            int width = _original.Width - BorderAllowance;
            int height = _original.Height - BorderAllowance;

            //Rectangle r1 = new Rectangle(0, 0, _original.Width, _original.Height);
            Rectangle r2 = new Rectangle(0, 0, _original.Width, _original.Height);

            //Bitmap procImage = _original.Clone(r2, PixelFormat.Format8bppIndexed);
            Bitmap procImage = _original.Clone(r2, PixelFormat.Format8bppIndexed);

            BitmapData origData = _original.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
            BitmapData procData = procImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int strideOrig = origData.Stride;

            System.IntPtr origScan0 = origData.Scan0;
            System.IntPtr procScan0 = procData.Scan0;

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

                        var a = (int)*o;
                        var b = (int)*(o + 1);
                        var c = (int)*(o + 2);

                        var d = (int)*(o + strideOrig);
                        var e = (int)*(o + strideOrig + 1);
                        var f = (int)*(o + strideOrig + 2);

                        var g = (int)*(o + strideOrig * 2);
                        var h = (int)*(o + strideOrig * 2 + 1);
                        var i = (int)*(o + strideOrig * 2 + 2);

                        var gx = Math.Abs(g + 2 * h + i) - Math.Abs(a + 2 * b + c);
                        var gy = Math.Abs(c + 2 * f + i) - Math.Abs(a + 2 * d + g);
                        
                        var combined = (Math.Abs(gx) + Math.Abs(gy)) > 255 ? (byte)255 : (byte)(Math.Abs(gx) + Math.Abs(gy));

                        *(p + strideOrig + 1) = combined;

                        ++p;
                        ++o;

                    }
                }
            }

            _original.UnlockBits(origData);
            procImage.UnlockBits(procData);

            return procImage;

        }

        public Bitmap Calculate_Laplacian(int threshold)
        {
            int width = _original.Width - BorderAllowance;
            int height = _original.Height - BorderAllowance;

            Rectangle r = new Rectangle(535, 50, _original.Width, _original.Height);
            Rectangle r2 = new Rectangle(0, 0, _original.Width, _original.Height);

            Bitmap procImage = _original.Clone(r2, PixelFormat.Format8bppIndexed);

            BitmapData origData = _original.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
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

                        var a = o[y * strideOrig + x];
                        var b = o[y * strideOrig + x + 1];
                        var c = o[y * strideOrig + x + 2];

                        var d = o[(y + 1) * strideOrig + x];
                        var e = o[(y + 1) * strideOrig + x + 1];
                        var f = o[(y + 1) * strideOrig + x + 2];

                        var g = o[(y + 2) * strideOrig + x];
                        var h = o[(y + 2) * strideOrig + x + 1];
                        var i = o[(y + 2) * strideOrig + x + 2];

                        var laplacian = Math.Abs(b + d - (4 * e) + f + h) ;


                        if (laplacian > threshold)
                        {
                            p[(y + 1) * strideOrig + x + 1] = 255;
                        }
                        else
                        {
                            p[(y + 1) * strideOrig + x + 1] = 0;
                        }
                    }
                }
            }

            _original.UnlockBits(origData);
            procImage.UnlockBits(procData);

            return procImage;

        }


        public Bitmap PointDetection(int threshold)
        {
            int width = _original.Width - BorderAllowance;
            int height = _original.Height - BorderAllowance;

            Rectangle r = new Rectangle(535, 50, _original.Width, _original.Height);
            Rectangle r2 = new Rectangle(0, 0, _original.Width, _original.Height);

            Bitmap procImage = _original.Clone(r2, PixelFormat.Format8bppIndexed);

            BitmapData origData = _original.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
            BitmapData procData = procImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int strideOrig = origData.Stride;

            System.IntPtr origScan0 = origData.Scan0;
            System.IntPtr procScan0 = procData.Scan0;

            unsafe
            {
                byte* o = (byte*)(void*)origScan0;
                byte* p = (byte*)(void*)procScan0;

                for (int y = 0; y < height; ++y)
                {
                    
                    for (int x = 0; x < width; ++x)
                    {
                        var a = o[y * strideOrig + x];
                        var b = o[y * strideOrig + x + 1];
                        var c = o[y * strideOrig + x + 2];

                        var d = o[(y + 1) * strideOrig + x];
                        var e = o[(y + 1) * strideOrig + x + 1];
                        var f = o[(y + 1) * strideOrig + x + 2];

                        var g = o[(y + 2) * strideOrig + x];
                        var h = o[(y + 2) * strideOrig + x + 1];
                        var i = o[(y + 2) * strideOrig + x + 2];
                        
                        var point = Math.Abs( -a - b - c - d + (8 * e) - f - g - h - i  );
                        
                        if (point > threshold)
                        {
                            p[(y + 1) * strideOrig + x + 1] = 255;
                        }
                        else
                        {
                            p[(y + 1) * strideOrig + x + 1] = 0;
                        }

                    }
                }
            }

            _original.UnlockBits(origData);
            procImage.UnlockBits(procData);

            return procImage;

        }

        private Bitmap Negative45DegreeLine(int threshold)
        {
            int width = _original.Width - BorderAllowance;
            int height = _original.Height - BorderAllowance;

            Rectangle r = new Rectangle(535, 50, _original.Width, _original.Height);
            Rectangle r2 = new Rectangle(0, 0, _original.Width, _original.Height);

            Bitmap procImage = _original.Clone(r2, PixelFormat.Format8bppIndexed);

            BitmapData origData = _original.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
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
                        var a = o[y * strideOrig + x];
                        var b = o[y * strideOrig + x + 1];
                        var c = o[y * strideOrig + x + 2];

                        var d = o[(y + 1) * strideOrig + x];
                        var e = o[(y + 1) * strideOrig + x + 1];
                        var f = o[(y + 1) * strideOrig + x + 2];

                        var g = o[(y + 2) * strideOrig + x];
                        var h = o[(y + 2) * strideOrig + x + 1];
                        var i = o[(y + 2) * strideOrig + x + 2];

                        var fortyfive = (2 * a) - b - c - d + (2 * e) - f - g - h + (2 * i);
                        
                        if (fortyfive >= threshold)
                        {
                            p[(y + 1) * strideOrig + x + 1] = 255;
                        }
                        else
                        {
                            p[(y + 1) * strideOrig + x + 1] = 0;
                        }

                    }
                }
            }

            _original.UnlockBits(origData);
            procImage.UnlockBits(procData);

            return procImage;
        }

        private Bitmap Positive45DegreeLine(int threshold)
        {
            int width = _original.Width - BorderAllowance;
            int height = _original.Height - BorderAllowance;

            Rectangle r = new Rectangle(535, 50, _original.Width, _original.Height);
            Rectangle r2 = new Rectangle(0, 0, _original.Width, _original.Height);

            Bitmap procImage = _original.Clone(r2, PixelFormat.Format8bppIndexed);

            BitmapData origData = _original.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
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
                        var a = o[y * strideOrig + x];
                        var b = o[y * strideOrig + x + 1];
                        var c = o[y * strideOrig + x + 2];

                        var d = o[(y + 1) * strideOrig + x];
                        var e = o[(y + 1) * strideOrig + x + 1];
                        var f = o[(y + 1) * strideOrig + x + 2];

                        var g = o[(y + 2) * strideOrig + x];
                        var h = o[(y + 2) * strideOrig + x + 1];
                        var i = o[(y + 2) * strideOrig + x + 2];

                        var fortyfive = Math.Abs(-a - b + (2 * c) - d + (2 * e) - f + (2 * g) - h - i);

                        if (fortyfive >threshold)
                        {
                            p[(y + 1)*strideOrig + x + 1] = 255;
                        }
                        else
                        {
                            p[(y + 1)*strideOrig + x + 1] = 0;
                        }
                    }
                }
            }

            _original.UnlockBits(origData);
            procImage.UnlockBits(procData);

            return procImage;
        }

        private Bitmap VerticalLineDetection(int threshold)
        {
            int width = _original.Width - BorderAllowance;
            int height = _original.Height - BorderAllowance;

            Rectangle r = new Rectangle(535, 50, _original.Width, _original.Height);
            Rectangle r2 = new Rectangle(0, 0, _original.Width, _original.Height);

            Bitmap procImage = _original.Clone(r2, PixelFormat.Format8bppIndexed);

            BitmapData origData = _original.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
            BitmapData procData = procImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int strideOrig = origData.Stride;

            System.IntPtr origScan0 = origData.Scan0;
            System.IntPtr procScan0 = procData.Scan0;

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

                        var a = (int)*o;
                        var b = (int)*(o + 1);
                        var c = (int)*(o + 2);

                        var d = (int)*(o + strideOrig);
                        var e = (int)*(o + strideOrig + 1);
                        var f = (int)*(o + strideOrig + 2);

                        var g = (int)*(o + strideOrig * 2);
                        var h = (int)*(o + strideOrig * 2 + 1);
                        var i = (int)*(o + strideOrig * 2 + 2);

                        var vertical = Math.Abs(-a + (2 * b) - c  - d + (2 * e) - f - g + (2 * h) - i);

                        var newValue = vertical > 255 ? (byte)255 : (byte)vertical;

                        if (newValue >= threshold && threshold != 255)
                        {
                            *(p + strideOrig + 1) = newValue;
                        }

                        ++p;
                        ++o;

                    }
                }
            }

            _original.UnlockBits(origData);
            procImage.UnlockBits(procData);

            return procImage;

        }

        private Bitmap HorizontalLineDetection(int threshold)
        {
            int width = _original.Width - BorderAllowance;
            int height = _original.Height - BorderAllowance;

            Rectangle r = new Rectangle(535, 50, _original.Width, _original.Height);
            Rectangle r2 = new Rectangle(0, 0, _original.Width, _original.Height);

            Bitmap procImage = _original.Clone(r2, PixelFormat.Format8bppIndexed);

            BitmapData origData = _original.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
            BitmapData procData = procImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int strideOrig = origData.Stride;

            System.IntPtr origScan0 = origData.Scan0;
            System.IntPtr procScan0 = procData.Scan0;

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

                        var a = (int)*o;
                        var b = (int)*(o + 1);
                        var c = (int)*(o + 2);

                        var d = (int)*(o + strideOrig);
                        var e = (int)*(o + strideOrig + 1);
                        var f = (int)*(o + strideOrig + 2);

                        var g = (int)*(o + strideOrig * 2);
                        var h = (int)*(o + strideOrig * 2 + 1);
                        var i = (int)*(o + strideOrig * 2 + 2);

                        var horizontal = -a -b -c + (2 * d) + (2 * e) + (2 * f ) -g -h -i;

                        
                        if (horizontal <= threshold )
                        {
                            var newValue = horizontal > 255 ? (byte)255 : (byte)horizontal;
                            newValue = horizontal < 0 ? (byte)0 : (byte)horizontal;

                            *(p + strideOrig + 1) = newValue;
                        }

                        ++p;
                        ++o;

                    }
                }
            }

            _original.UnlockBits(origData);
            procImage.UnlockBits(procData);

            return procImage;

        }

    }
}
