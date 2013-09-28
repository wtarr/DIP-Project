using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_ClassLib
{
    public class Binarization : IUseTrackbarThresholding
    {

        private int toW, toB, total, exp;

        private Bitmap _original;
        
        public Binarization(Bitmap orig)
        {
            _original = orig;
        }

        public Bitmap Binarize(int threshold)
        {
            int width = _original.Width;
            int height = _original.Height;

            exp = width*height; 
            toB = 0;
            toW = 0;
            
            Rectangle r2 = new Rectangle(0, 0, width, height);

            Bitmap procImage = _original.Clone(r2, PixelFormat.Format8bppIndexed);

            BitmapData bmData = procImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite,
                PixelFormat.Format8bppIndexed);

            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                for (var y = 0; y < height; y++)
                {
                    for (var x = 0; x < width; x++)
                    {
                        if (p[0] >= threshold)
                        {
                            p[0] = 255;
                            toW++;

                            if (threshold == 255 && p[0] == 255)
                                p[0] = 0;
                        }
                        else
                        {
                            p[0] = 0;
                            toB++;

                            
                        }

                        p++;
                    }

                }
            }

            procImage.UnlockBits(bmData);

            Console.WriteLine("Img size " + exp);
            Console.WriteLine("To white " + toW);
            Console.WriteLine("To black " + toB);
            Console.WriteLine("Yes/No " + (toW + toB));

          
            return procImage;
            
        }


        public Bitmap Execute(int threshold)
        {
            return Binarize(threshold);
        }
    }



}
