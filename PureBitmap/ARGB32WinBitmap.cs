using System;
using IvanSurzhenko.PureBitmap.Color;
using IvanSurzhenko.PureBitmap.Convertors;

namespace IvanSurzhenko.PureBitmap
{
    public class ARGB32WinBitmap : GenericBitmap
    {
        public ARGB32WinBitmap(ushort width, ushort height) : base()
        {
            DIBH.Width = width;
            DIBH.Height = height;
            DIBH.BitsPerPixel = 32;

            BFH.HeaderField = "BM";
            BFH.PixelArrayAddress = (uint)DIBH.GetBytes().Length + (uint)BFH.GetBytes().Length;

            PixelMap = new byte[width * height * 4];

            BFH.Size = (uint)BFH.GetBytes().Length + (uint)DIBH.GetBytes().Length + (uint)PixelMap.Length;
        }

        public void PutPixel(uint x, uint y, byte a, byte r, byte g, byte b)
        {
            if (x >= DIBH.Width)
            {
                throw new IndexOutOfRangeException(String.Format("x should be between {0} and {1}. Received: {2}", 0, DIBH.Width-1, x));
            }

            if (y >= DIBH.Height)
            {
                throw new IndexOutOfRangeException(String.Format("y should be between {0} and {1}. Received: {2}", 0, DIBH.Height-1, y));
            }

            BinaryThings.PutBytesIntoBytes(new byte[] { a, r, g, b }, PixelMap, (y * DIBH.Width + x) * 4);
        }

        public void PutPixel(uint x, uint y, ARGB32 color)
        {
            PutPixel(x, y, color.A, color.R, color.G, color.B);
        }
    }
}
