//Write a program that gets two numbers from the console and prdoubles the greater of them.
using System;


namespace Number_Comparer
{
    class NumberComparer
    {
        static void Main()
        {
            Console.Write("First Number:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Secound Number:");
            double b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("The bigger number is {0}", a);
            }
            else if (a < b)
            {
                Console.WriteLine("The bigger number is {0}", b);
            }
            else
            {
                Console.WriteLine("The numbers is equal");
            }
        }
    }
}
