using System;

namespace IvanSurzhenko.PureBitmap.Color
{
    public class ARGB32
    {
        public byte A { get; set; }
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }

        public ARGB32(byte a, byte r, byte g, byte b)
        {
            A = a;
            R = r;
            G = g;
            B = b;
        }

        static public ARGB32 Black { get; } = new ARGB32(255, 0, 0, 0);
        static public ARGB32 White { get; } = new ARGB32(255, 255, 255, 255);
    }
}
