//Write a program that enters from the console a positive integer n and prints all the 
//numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.
using System;


namespace Numbers_Not_Divisible_by_3_and_7
{
    class NotDivisibleBy3And7
    {
        static void Main()
        {
            Console.Write("Enter N : ");
            int n = int.Parse(Console.ReadLine());
            bool isDivide = true;
            Console.WriteLine("The numbers is : ");
            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 == 0) && (i % 7 == 0))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(i + " ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    isDivide = false;
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
