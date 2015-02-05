//ing bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.
using System;


namespace BitwiseExtractBit
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number:");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter position : ");
            int position = int.Parse(Console.ReadLine());
            int bitAtRight = num >> position;
            int bit = bitAtRight & 1;
            Console.WriteLine(bit);
        }
    }
}
