using System.Drawing;
using System.Drawing.Imaging;
using DIP_ClassLib;
using NUnit.Framework;

namespace UnitTesting
{
    [TestFixture]
    public class FiltersUnitTests
    {

        [TestCase]
        public void NeighbourHoodAveraging_3by3BitmapImage_ExpectMiddleValueToBe10()
        {

            /* | 2| 4| 6|
             * | 8|10|12|
             * |14|16|18|
             *  
             */


            Bitmap testcase = new Bitmap(3, 3, PixelFormat.Format8bppIndexed);

            BitmapData data = testcase.LockBits(new Rectangle(0, 0, 3, 3), ImageLockMode.ReadWrite,
                PixelFormat.Format8bppIndexed);

            var Scan0 = data.Scan0;

            unsafe
            {
                var p = (byte*)(void*)Scan0;

                p[0] = 2;
                p[1] = 4;
                p[2] = 6;
                p[3] = 8;
                p[4] = 10;
                p[5] = 12;
                p[6] = 14;
                p[7] = 16;
                p[8] = 18;
            }

            testcase.UnlockBits(data);


            var filters = new SmoothingFilters(testcase);

            var result = filters.NeighbourhoodAveraging();

            byte middleValue;

            BitmapData filteredData = result.LockBits(new Rectangle(0, 0, 3, 3), ImageLockMode.ReadOnly,
                PixelFormat.Format8bppIndexed);

            Scan0 = filteredData.Scan0;

            unsafe
            {
                var o = (byte*)(void*)Scan0;

                middleValue = o[4];
            }

            result.UnlockBits(filteredData);

            Assert.AreEqual(middleValue, 10);


        }


    }

}
