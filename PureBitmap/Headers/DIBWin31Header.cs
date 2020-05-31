using System;
using IvanSurzhenko.PureBitmap.Convertors;

namespace IvanSurzhenko.PureBitmap.Headers
{
    public class DIBWin31Header
    {
        public uint SizeOfHeader { get; set; } = 40;
        public uint Width { get; set; }
        public uint Height { get; set; }
        public ushort Planes { get; set; } = 1;
        public ushort BitsPerPixel { get; set; }
        public uint Compression { get; set; } = 0;
        public uint ImageSize { get; set; } = 0;
        public uint HorResolution { get; set; } = 72;
        public uint VerResolution { get; set; } = 72;
        public uint NumberOfPalleteColors { get; set; } = 0;
        public uint NumberOfImportantColors { get; set; } = 0;

        public DIBWin31Header()
        {
        }

        public byte[] GetBytes()
        {
            var result = new byte[SizeOfHeader];

            BinaryThings.PutBytesIntoBytes(BinaryThings.FromUintToBytes(SizeOfHeader), result, 0);
            BinaryThings.PutBytesIntoBytes(BinaryThings.FromUintToBytes(Width), result, 4);
            BinaryThings.PutBytesIntoBytes(BinaryThings.FromUintToBytes(Height), result, 8);
            BinaryThings.PutBytesIntoBytes(BinaryThings.FromUshortToBytes(Planes), result, 12);
            BinaryThings.PutBytesIntoBytes(BinaryThings.FromUshortToBytes(BitsPerPixel), result, 14);
            BinaryThings.PutBytesIntoBytes(BinaryThings.FromUintToBytes(Compression), result, 16);
            BinaryThings.PutBytesIntoBytes(BinaryThings.FromUintToBytes(ImageSize), result, 20);
            BinaryThings.PutBytesIntoBytes(BinaryThings.FromUintToBytes(HorResolution), result, 24);
            BinaryThings.PutBytesIntoBytes(BinaryThings.FromUintToBytes(VerResolution), result, 28);
            BinaryThings.PutBytesIntoBytes(BinaryThings.FromUintToBytes(NumberOfPalleteColors), result, 32);
            BinaryThings.PutBytesIntoBytes(BinaryThings.FromUintToBytes(NumberOfImportantColors), result, 36);

            return result;
        }
    }
}
