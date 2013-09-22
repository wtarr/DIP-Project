using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace DIP_ClassLib
{
    public class Transformation
    {
        public Image ScaleWithMaintainedRatio(Image imageToScale, Size maxSize, out Size destSize)
        {
            // Based on http://tech.pro/tutorial/620/csharp-tutorial-image-editing-saving-cropping-and-resizing
            
            int sourceWidth = imageToScale.Width;
            int sourceHeight = imageToScale.Height;

            int destWidth, destHeight;
            
            float scaleFactor = maxSize.Width/(float)imageToScale.Width;

            if (scaleFactor < 1)
            {
                // width needs to come down
                destWidth = (int)(imageToScale.Width*scaleFactor);
                destHeight = (int) (imageToScale.Height*scaleFactor);
            }
            else
            {
                destWidth = maxSize.Width;
                destHeight = (int)(imageToScale.Height*(1f + scaleFactor));
            }
            

            destSize = new Size(destWidth, destHeight);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imageToScale, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Image)b;

        }
    }
}
