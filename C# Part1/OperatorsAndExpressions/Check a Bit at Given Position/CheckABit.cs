
using System;


namespace Check_a_Bit_at_Given_Position
{
    class CheckABit
    {
        static void Main()
        {
            Console.Write("Enter number:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter bit position:");
            int p = int.Parse(Console.ReadLine());
            int bitAtRight = n >> p;
            int bit = bitAtRight & 1;
            bool result;
            if (bit == 1)
            {
                result = true;
                Console.WriteLine(result);
            }
            else
            {
                result = false;
                Console.WriteLine(result);

            }
        }
    }
}
