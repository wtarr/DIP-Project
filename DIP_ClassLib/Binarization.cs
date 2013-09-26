using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_ClassLib
{
    public class Binarization
    {
        public Bitmap Binarize(int threshold, Bitmap orig)
        {
            int width = orig.Width;
            int height = orig.Height;

            Rectangle r2 = new Rectangle(0, 0, width, height);

            Bitmap procImage = orig.Clone(r2, PixelFormat.Format8bppIndexed);

            BitmapData bmData = procImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite,
                PixelFormat.Format8bppIndexed);

            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                for (var y = 0; y < height; ++y)
                {
                    for (var x = 0; x < width; ++x)
                    {
                        if (p[0] >= threshold)
                        {
                            p[0] = 255;
                        }
                        else
                        {
                            p[0] = 0;
                        }

                        ++p;
                    }

                }
            }

            procImage.UnlockBits(bmData);
            
            return procImage;
            
        }
        

    }



}
