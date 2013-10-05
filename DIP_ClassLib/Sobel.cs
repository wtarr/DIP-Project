using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace DIP_ClassLib
{
    public enum Gx
    {
        A = -1,
        B = 0,
        C = 1,
        D = -2,
        E = 0,
        F = 2,
        G = -1,
        H = 0,
        I = 1
    }

    public enum Gy
    {
        A = (byte)1,
        B = 2,
        C = 1,
        D = 0,
        E = 0,
        F = 0,
        G = -1,
        H = -2,
        I = -1
    }

    public class Sobel : IUseTrackbarThresholding
    {
        private readonly Bitmap _original;
        private const int BorderAllowance = 2;

        public int GxTrackbar { get; set; }
        public int GyTrackbar { get; set; }

        public Sobel(Bitmap original)
        {
            _original = original;
        }

        public Bitmap Calculate_Gx(int threshold)
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

                        var gx = Math.Abs(g + 2*h + i) - Math.Abs(a + 2*b + c);
                        
                        var newValue = gx > 255 ? (byte)255 : (byte)gx;

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

                        var gy = Math.Abs(c + 2 * f + i) - Math.Abs(a + 2 * d + g);

                        var newValue = gy > 255 ? (byte)255 : (byte)gy;

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


        public Bitmap Execute(int[] threshold, Process process)
        {
            switch (process)
            {
                case Process.SobelGx:
                    return Calculate_Gx(threshold[0]);
                case Process.SobelGy:
                    return Calculate_Gy(threshold[0]);
                case Process.SobelGxGy:
                    return Calculate_GxGy(threshold);
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
    }
}
