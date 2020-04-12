using System;
using IvanSurzhenko.PureBitmap.Convertors;

namespace IvanSurzhenko.PureBitmap.Headers
{
    public class DIBHeader
    {
        // BITMAPCOREHEADER
        public uint SizeOfHeader { get; set; } = 12;
        public ushort Width { get; set; }
        public ushort Height { get; set; }
        public ushort Planes { get; set; } = 1;
        public ushort BitsPerPixel { get; set; }

        public DIBHeader()
        {
        }

        public byte[] GetBytes()
        {
            var result = new byte[SizeOfHeader];

            BinaryThings.PutBytesIntoBytes(BinaryThings.FromUintToBytes(SizeOfHeader), result, 0);
            BinaryThings.PutBytesIntoBytes(BinaryThings.FromUshortToBytes(Width), result, 4);
            BinaryThings.PutBytesIntoBytes(BinaryThings.FromUshortToBytes(Height), result, 6);
            BinaryThings.PutBytesIntoBytes(BinaryThings.FromUshortToBytes(Planes), result, 8);
            BinaryThings.PutBytesIntoBytes(BinaryThings.FromUshortToBytes(BitsPerPixel), result, 10);

            return result;
        }
    }
}
