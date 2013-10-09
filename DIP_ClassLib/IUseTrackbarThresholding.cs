using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DIP_ClassLib
{
    public interface IUseTrackbarThresholding
    {
        Bitmap Execute(int[] threshold, Process process);
    }
}
