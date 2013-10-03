using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace DIP_ClassLib
{
    public class RobertsGradient : IUseTrackbarThresholding
    {

        private Bitmap _original; 

        public RobertsGradient(Bitmap orig)
        {
            _original = orig;
        }


        public Bitmap WithThreshold()
        {
            throw new NotImplementedException();
        }

        public Bitmap Direct()
        {
            int width = _original.Width - 2;
            int height = _original.Height - 2;

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

                        var a = o[0];//
                        var b = (o + 1)[0];//


                        var c = (o + strideOrig)[0];//
                        var d = (o + strideOrig + 1)[0];//

                        var direct = Math.Abs(a - b) + Math.Abs(c - d);

                        p[0] = direct <= 255 ? (byte)direct : (byte)255;

                        p++;
                        o++;

                    }

                }


            }

            _original.UnlockBits(origData);
            procImage.UnlockBits(procData);

            return procImage;
        }

        public Bitmap Pseudo()
        {
            throw new NotImplementedException();
        }

        public Bitmap Execute(int threshold, Process process)
        {
            switch (process)
            {
                case Process.RobertsGradientWithThresholding:
                    return WithThreshold();
                case Process.RobertsGradientWithPseudoColor:
                    return Pseudo();
                   
            }

            throw new ArgumentException();
        }
    }
}
