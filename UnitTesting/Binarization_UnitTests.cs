using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using DIP_ClassLib;
using NUnit.Framework;

namespace UnitTesting
{
    [TestFixture]
    internal class Binarization_UnitTests
    {

        [TestCase]
        public void Binarize_4by4Bitmap_ExpectBelowThresholdTurnBlackandAboveToWhite()
        {

            Bitmap testcase = new Bitmap(4, 4, PixelFormat.Format8bppIndexed);

            BitmapData data = testcase.LockBits(new Rectangle(0, 0, 4, 4), ImageLockMode.ReadWrite,
                PixelFormat.Format8bppIndexed);

            var Scan0 = data.Scan0;

            unsafe
            {
                var p = (byte*)(void*)Scan0;

                p[0] = 10;
                p[1] = 128;
                p[2] = 250;
                p[3] = 50;
                p[4] = 66;
                p[5] = 100;
                p[6] = 255;
                p[7] = 10;
                p[8] = 190;
                p[9] = 50;
                p[10] = 200;
                p[11] = 80;
            }

            testcase.UnlockBits(data);

            Binarization b = new Binarization(testcase);

            var binarized = b.Binarize(127);

            BitmapData bData = binarized.LockBits(new Rectangle(0, 0, 4, 4), ImageLockMode.ReadOnly,
                PixelFormat.Format8bppIndexed);

            Scan0 = bData.Scan0;

            List<byte> store = new List<byte>();

            unsafe
            {
                var o = (byte*)(void*)Scan0;

                for (int i = 0; i < 16; i++)
                {
                    store.Add(o[0]);
                    o++;
                }
            }

            binarized.UnlockBits(bData);

            Assert.AreEqual(store[0], 0);
            Assert.AreEqual(store[1], 255);
            Assert.AreEqual(store[10], 255);

        }

        [TestCase]
        public void Binarize_4by4BitmapANDthreshold255_ExpectAllBlack()
        {
            // If threshold is 255 then bitmap should go completely to black

            Bitmap testcase = new Bitmap(4, 4, PixelFormat.Format8bppIndexed);

            BitmapData data = testcase.LockBits(new Rectangle(0, 0, 4, 4), ImageLockMode.ReadWrite,
                PixelFormat.Format8bppIndexed);

            var Scan0 = data.Scan0;

            unsafe
            {
                var p = (byte*)(void*)Scan0;

                p[0] = 10;
                p[1] = 128;
                p[2] = 250;
                p[3] = 50;
                p[4] = 66;
                p[5] = 100;
                p[6] = 255;
                p[7] = 10;
                p[8] = 190;
                p[9] = 50;
                p[10] = 255;
                p[11] = 80;
            }

            testcase.UnlockBits(data);

            Binarization b = new Binarization(testcase);

            var binarized = b.Binarize(255); // Maximum threshold

            BitmapData bData = binarized.LockBits(new Rectangle(0, 0, 4, 4), ImageLockMode.ReadOnly,
                PixelFormat.Format8bppIndexed);

            Scan0 = bData.Scan0;

            List<byte> store = new List<byte>();

            unsafe
            {
                var o = (byte*)(void*)Scan0;

                for (int i = 0; i < 16; i++)
                {
                    store.Add(o[0]);
                    o++;
                }
            }

            binarized.UnlockBits(bData);

            foreach (var b1 in store)
            {
                Assert.IsTrue(b1.Equals(0));
            }
        }

        [TestCase]
        public void Binarize_4by4BitmapANDthreshold0_ExpectAllWhite()
        {
            // If threshold is 255 then bitmap should go completely to black

            Bitmap testcase = new Bitmap(4, 4, PixelFormat.Format8bppIndexed);

            BitmapData data = testcase.LockBits(new Rectangle(0, 0, 4, 4), ImageLockMode.ReadWrite,
                PixelFormat.Format8bppIndexed);

            var Scan0 = data.Scan0;

            unsafe
            {
                var p = (byte*)(void*)Scan0;

                p[0] = 10;
                p[1] = 128;
                p[2] = 250;
                p[3] = 50;
                p[4] = 66;
                p[5] = 100;
                p[6] = 255;
                p[7] = 10;
                p[8] = 190;
                p[9] = 50;
                p[10] = 255;
                p[11] = 80;
            }

            testcase.UnlockBits(data);

            Binarization b = new Binarization(testcase);

            var binarized = b.Binarize(0); // Minimum threshold

            BitmapData bData = binarized.LockBits(new Rectangle(0, 0, 4, 4), ImageLockMode.ReadOnly,
                PixelFormat.Format8bppIndexed);

            Scan0 = bData.Scan0;

            List<byte> store = new List<byte>();

            unsafe
            {
                var o = (byte*)(void*)Scan0;

                for (int i = 0; i < 16; i++)
                {
                    store.Add(o[0]);
                    o++;
                }
            }

            binarized.UnlockBits(bData);

            foreach (var b1 in store)
            {
                Assert.IsTrue(b1.Equals(255));
            }
        }
    }
}
