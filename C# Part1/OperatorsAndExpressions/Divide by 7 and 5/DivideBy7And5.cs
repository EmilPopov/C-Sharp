//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
using System;


namespace Divide_by_7_and_5
{
    class DivideBy7And5
    {
        static void Main()
        {
            Console.Write("Enter one number:");
            int num = int.Parse(Console.ReadLine());
            bool isDivide = num % 5 == 0 && num % 7 == 0; ;
            if (isDivide)
            {
                Console.WriteLine("The number is divide by 7 and 5.");
            }
            else
            {
                Console.WriteLine("The number is not divide by 7 and 5.");
            }
        }
    }
}
