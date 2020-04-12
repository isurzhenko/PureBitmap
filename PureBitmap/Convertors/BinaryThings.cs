using System;
using System.Text;

namespace IvanSurzhenko.PureBitmap.Convertors
{
    public class BinaryThings
    {
        public static byte[] FromUintToBytes(uint val)
        {
            var result = BitConverter.GetBytes(val);
            return result;
        }

        public static byte[] FromUshortToBytes(ushort val)
        {
            var result = BitConverter.GetBytes(val);
            return result;
        }

        public static byte[] FromStringToBytes(String val)
        {
            return Encoding.ASCII.GetBytes(val);
        }

        public static void PutBytesIntoBytes(byte[] source, byte[] destination, uint index)
        {
            if (index + source.Length - 1 > destination.Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = 0; i < source.Length; i++)
            {
                destination[index + i] = source[i];
            }
        }

        public static byte[] SubArray(byte[] data, uint index, uint length)
        {
            var result = new byte[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }
    }
}
