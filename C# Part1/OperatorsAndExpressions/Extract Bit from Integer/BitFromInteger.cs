//write an expression that extracts from given integer n the value of given bit at index p.
using System;


namespace Extract_Bit_from_Integer
{
    class BitFromInteger
    {
        static void Main()
        {
            Console.Write("Enter N:");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter P : ");
            int position = int.Parse(Console.ReadLine());
            int bitAtRight = num >> position;
            int bit = bitAtRight & 1;
            Console.WriteLine(bit);
        }
    }
}
