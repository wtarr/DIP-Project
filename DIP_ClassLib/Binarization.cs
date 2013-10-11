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

        

        private Bitmap _original;
        
        public Binarization(Bitmap orig)
        {
            _original = orig;
        }

        public Bitmap Binarize(int threshold)
        {
            int width = _original.Width;
            int height = _original.Height;
            
            Rectangle r2 = new Rectangle(0, 0, width, height);

            Bitmap procImage = _original.Clone(r2, PixelFormat.Format8bppIndexed);

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


        public Bitmap Execute(int[] threshold, Process process)
        {
            return Binarize(threshold[0]);
        }
    }



}
