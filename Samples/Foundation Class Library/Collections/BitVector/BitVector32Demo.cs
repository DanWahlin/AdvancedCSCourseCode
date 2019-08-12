using System;
using System.Collections.Specialized;

namespace Chapter2.BitVector
{
    public class BitVector32Demo
    {

        public static void Main()
        {
            BitVector32 BV = new BitVector32(0);

            // Creates five bit flags
            int bit1 = BitVector32.CreateMask();
            int bit2 = BitVector32.CreateMask(bit1);
            int bit3 = BitVector32.CreateMask(bit2);
            int bit4 = BitVector32.CreateMask(bit3);
            int bit5 = BitVector32.CreateMask(bit4);

            // Sets the alternating bits to TRUE.
            Console.WriteLine("Setting 1,3,5 bits to TRUE:");
            Console.WriteLine("   Initial:      {0}", BV.ToString());
            BV[bit1] = true;
            Console.WriteLine("   bit1 = " + BV[bit1] + "   {0}", BV.ToString());
            BV[bit3] = true;
            Console.WriteLine("   bit3 = " + BV[bit1] + "   {0}", BV.ToString());
            BV[bit5] = true;
            Console.WriteLine("   bit5 = " + BV[bit1] + "   {0}", BV.ToString());

            Console.WriteLine("Bit total: " + BV.Data.ToString());
            
            Console.Read();
        }

    }
}
