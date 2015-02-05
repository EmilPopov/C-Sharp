//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
using System;


namespace Modify_a_Bit_at_Given_Position
{
    class ModifyBit
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter V: ");
            int v = int.Parse(Console.ReadLine());
            Console.Write("Enter P: ");
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            int newValue;
            int bitAtRight;
            if (v == 1)
            {
                bitAtRight = 1 << p;
                newValue = n | bitAtRight;
                Console.WriteLine(Convert.ToString(newValue, 2).PadLeft(32, '0'));
                Console.WriteLine("Result = {0}" ,newValue);
            }
            else if (v == 0)
            {
                bitAtRight = ~(1 << p);
                newValue = n & bitAtRight;
                Console.WriteLine(Convert.ToString(newValue, 2).PadLeft(32, '0'));
                Console.WriteLine("Result = {0}" , newValue);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
