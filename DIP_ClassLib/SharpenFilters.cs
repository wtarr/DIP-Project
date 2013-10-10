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

        private readonly int[] _sobelGx = new[] {-1, -2, -1, 0, 0, 0, 1, 2, 1};
        private readonly int[] _sobelGy = new[] {-1, 0, 1, -2, 0, 2, -1, 0, 1};
        private readonly int[] _laplacian = new[] {0, 1, 0, 1, -4, 1, 0, 1, 0};
        private readonly int[] _pointDet = new[] {-1, -1, -1, -1, 8, -1, -1, -1, -1};
        private readonly int[] _horizontal = new[] {-1, -1, -1, 2, 2, 2, -1, -1, -1};
        private readonly int[] _vertical = new[] {-1, 2, -1, -1, 2, -1, -1, 2, -1};
        private readonly int[] _pos45 = new[] {-1, -1, 2, -1, 2, -1, 2, -1, -1};
        private readonly int[] _neg45 = new[] {2, -1, -1, -1, 2, -1, -1, -1, 2};

        

        public SharpenFilters(Bitmap original)
        {
            _original = original;
        }

        public Bitmap Execute_Filter(int threshold, int[] filter)
        {
            int width = _original.Width - BorderAllowance;
            int height = _original.Height - BorderAllowance;

            var _3X3Selection = new int[9];

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
                            gx += filter[i]*_3X3Selection[i];
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

        
        public Bitmap Execute(int[] threshold, Process process)
        {
            switch (process)
            {
                case Process.SobelGx:
                    return Execute_Filter(threshold[0], _sobelGx);
                case Process.SobelGy:
                    return Execute_Filter(threshold[0], _sobelGy);
                case Process.SobelGxGy:
                    return Calculate_GxGy(threshold);
                case Process.Laplacian:
                    return Execute_Filter(threshold[0], _laplacian);
                case Process.PointDetection:
                    return Execute_Filter(threshold[0], _pointDet);
                case Process.HorizontalLine:
                    return Execute_Filter(threshold[0], _horizontal);
                case Process.VerticalLine:
                    return Execute_Filter(threshold[0], _vertical);
                case Process.Positive45DegreeLine:
                    return Execute_Filter(threshold[0], _pos45);
                case Process.Negative45DegreeLine:
                    return Execute_Filter(threshold[0], _neg45);
            }

            throw new Exception("Needs a process");
        }

        

        private Bitmap Calculate_GxGy(int[] threshold)
        {

            // compare gx and gy and if either is greater than the threshold then 255
            // else 0

            throw new NotImplementedException();

        }

        
    }
}
