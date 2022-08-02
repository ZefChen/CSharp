using System;
namespace Assignment1
{
    public class UnderstandingTypes
    {
        public static void ByteMaxMin()
        {
            Console.WriteLine("Number of bytes in memory for sbyte is " + sizeof(sbyte)
                + ", its maximum and minimum are " + sbyte.MaxValue + " and " + sbyte.MinValue);
            Console.WriteLine("Number of bytes in memory for sbyte is " + sizeof(byte)
                + ", its maximum and minimum are " + byte.MaxValue + " and " + byte.MinValue);
            Console.WriteLine("Number of bytes in memory for sbyte is " + sizeof(short)
                + ", its maximum and minimum are " + short.MaxValue + " and " + short.MinValue);
            Console.WriteLine("Number of bytes in memory for sbyte is " + sizeof(ushort)
                + ", its maximum and minimum are " + ushort.MaxValue + " and " + ushort.MinValue);
            Console.WriteLine("Number of bytes in memory for sbyte is " + sizeof(int)
                + ", its maximum and minimum are " + Int32.MaxValue + " and " + Int32.MinValue);
            Console.WriteLine("Number of bytes in memory for sbyte is " + sizeof(uint)
                + ", its maximum and minimum are " + UInt32.MaxValue + " and " + UInt32.MinValue);
            Console.WriteLine("Number of bytes in memory for sbyte is " + sizeof(long)
                + ", its maximum and minimum are " + long.MaxValue + " and " + long.MinValue);
            Console.WriteLine("Number of bytes in memory for sbyte is " + sizeof(ulong)
                + ", its maximum and minimum are " + ulong.MaxValue + " and " + ulong.MinValue);
            Console.WriteLine("Number of bytes in memory for sbyte is " + sizeof(float)
                + ", its maximum and minimum are " + float.MaxValue + " and " + float.MinValue);
            Console.WriteLine("Number of bytes in memory for sbyte is " + sizeof(double)
                + ", its maximum and minimum are " + double.MaxValue + " and " + double.MinValue);
            Console.WriteLine("Number of bytes in memory for sbyte is " + sizeof(decimal)
                + ", its maximum and minimum are " + decimal.MaxValue + " and " + decimal.MinValue);
        }
    }
}

