using System;
using System.IO;
using IvanSurzhenko.PureBitmap;
using IvanSurzhenko.PureBitmap.Color;
using IvanSurzhenko.PureBitmap.Convertors;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var bmp = new ARGB32WinBitmap(2, 2);

            bmp.PutPixel(1, 1, ARGB32.Black);

            bmp.PutPixel(0, 0, ARGB32.Black);

            bmp.PutPixel(0, 1, ARGB32.White);

            bmp.PutPixel(1, 0, ARGB32.White);

            using (var stream = bmp.OutputStream())
            {
                var imageSnapshot = new byte[]
                {
                    0x42, 0x4D, 42, 0, 0,
                    0, 0, 0, 0, 0,
                    26, 0, 0, 0, 12,
                    0, 0, 0, 2, 0,
                    2, 0, 1, 0, 32,
                    0, 255, 0, 0, 0,
                    255, 255, 255, 255, 255,
                    255, 255, 255, 255, 0,
                    0, 0
                };
                var snapshotSize = imageSnapshot.Length;
                var buffer = new byte[snapshotSize];
                var r = stream.Read(buffer, 0, snapshotSize);
;
                Xunit.Assert.Equal(snapshotSize, r);

                Xunit.Assert.Equal(BinaryThings.SubArray(imageSnapshot, 0, 5), BinaryThings.SubArray(buffer, 0, 5));
                Xunit.Assert.Equal(BinaryThings.SubArray(imageSnapshot, 5, 5), BinaryThings.SubArray(buffer, 5, 5));
                Xunit.Assert.Equal(BinaryThings.SubArray(imageSnapshot, 10, 5), BinaryThings.SubArray(buffer, 10, 5));
                Xunit.Assert.Equal(BinaryThings.SubArray(imageSnapshot, 15, 5), BinaryThings.SubArray(buffer, 15, 5));
                Xunit.Assert.Equal(BinaryThings.SubArray(imageSnapshot, 20, 5), BinaryThings.SubArray(buffer, 20, 5));
                Xunit.Assert.Equal(BinaryThings.SubArray(imageSnapshot, 25, 5), BinaryThings.SubArray(buffer, 25, 5));
                Xunit.Assert.Equal(BinaryThings.SubArray(imageSnapshot, 30, 5), BinaryThings.SubArray(buffer, 30, 5));
                Xunit.Assert.Equal(BinaryThings.SubArray(imageSnapshot, 35, 5), BinaryThings.SubArray(buffer, 35, 5));
                Xunit.Assert.Equal(BinaryThings.SubArray(imageSnapshot, 40, 2), BinaryThings.SubArray(buffer, 40, 2));
            }
        }
    }
}
