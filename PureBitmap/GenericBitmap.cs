using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using IvanSurzhenko.PureBitmap.Headers;

namespace IvanSurzhenko.PureBitmap
{
    public abstract class GenericBitmap
    {
        protected BitmapFileHeader BFH { get; set; } = new BitmapFileHeader();

        protected DIBHeader DIBH { get; set; } = new DIBHeader();

        protected byte[] PixelMap { get; set; } = new byte[0];

        public Stream OutputStream()
        {
            var result = new MemoryStream();

            result.Write(BFH.GetBytes());
            result.Write(DIBH.GetBytes());
            result.Write(PixelMap);
            result.Position = 0;

            return result;
        }
    }
}
