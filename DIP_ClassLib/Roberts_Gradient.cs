using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace DIP_ClassLib
{
    public class RobertsGradient : ImAnImageProcess
    {

        private readonly Bitmap _original;
        private const int BorderAllowance = 1;

        public RobertsGradient(Bitmap orig)
        {
            _original = orig;
        }


        public Bitmap WithThreshold(int threshold)
        {
            int width = _original.Width - BorderAllowance;
            int height = _original.Height - BorderAllowance;

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

            _original.UnlockBits(origData);
            procImage.UnlockBits(procData);

            return procImage;
        }

        public Bitmap Direct()
        {
            int width = _original.Width - BorderAllowance;
            int height = _original.Height - BorderAllowance;

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


                for (int y = 0; y < height; ++y)
                {
                    p = (byte*)(void*)procScan0 + (y * strideOrig);
                    o = (byte*)(void*)origScan0 + (y * strideOrig);

                    for (int x = 0; x < width; ++x)
                    {

                        var a = *o;//
                        var b = *(o + 1);//


                        var c = *(o + strideOrig);//
                        var d = *(o + strideOrig + 1);//

                        var direct = Math.Abs(a - b) + Math.Abs(c - d);

                        *p = direct <= 255 ? (byte)direct : (byte)255;

                        ++p;
                        ++o;

                    }

                }


            }

            _original.UnlockBits(origData);
            procImage.UnlockBits(procData);

            return procImage;
        }

        public Bitmap Pseudo(int threshold)
        {
            int width = _original.Width - BorderAllowance;
            int height = _original.Height - BorderAllowance;

            Rectangle r2 = new Rectangle(0, 0, _original.Width, _original.Height);

            Bitmap procImage = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            using (Graphics g = Graphics.FromImage(procImage))
            {
                g.PageUnit = GraphicsUnit.Pixel;
                g.DrawImage(_original, r2);
            }

            BitmapData origData = _original.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
           
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
            _original.UnlockBits(origData);

            return procImage;
        }

        public Bitmap Execute(int[] threshold, Process process)
        {
            switch (process)
            {
                case Process.RobertsGradientWithThresholding:
                    return WithThreshold(threshold[0]);
                case Process.RobertsGradientWithPseudoColor:
                    return Pseudo(threshold[0]);
                case Process.RobertsGradientDirect:
                    return Direct();
            }

            throw new ArgumentException();
        }
    }
}
