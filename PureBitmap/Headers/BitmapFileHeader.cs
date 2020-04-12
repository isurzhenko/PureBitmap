using System;
using IvanSurzhenko.PureBitmap.Convertors;

namespace IvanSurzhenko.PureBitmap.Headers
{
    public class BitmapFileHeader
    {
        public String HeaderField { get; set; }
        public uint Size { get; set; } = 12;
        public uint Reserved { get; set; } = 0;
        public uint PixelArrayAddress { get; set; } = 0;

        public BitmapFileHeader()
        {
        }

        public byte[] GetBytes()
        {
            var result = new byte[14];

            BinaryThings.PutBytesIntoBytes(BinaryThings.FromStringToBytes(HeaderField), result, 0);
            BinaryThings.PutBytesIntoBytes(BinaryThings.FromUintToBytes(Size), result, 2);
            BinaryThings.PutBytesIntoBytes(BinaryThings.FromUintToBytes(Reserved), result, 6);
            BinaryThings.PutBytesIntoBytes(BinaryThings.FromUintToBytes(PixelArrayAddress), result, 10);

            return result;
        }
    }
}
