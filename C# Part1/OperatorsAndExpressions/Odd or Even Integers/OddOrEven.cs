//Write an expression that checks if given integer is odd or even.
using System;


namespace Odd_or_Even_Integers
{
    class OddOrEven
    {
        static void Main()
        {
            Console.Write("Enter one number:");
            int num = int.Parse(Console.ReadLine());
            bool isEven = num % 2 == 0;
            if (isEven)
            {
                Console.WriteLine("The number is Even");
            }
            else
            {
                Console.WriteLine("The number is Odd");
            }
        }
    }
}
