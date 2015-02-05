//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
using System;


namespace Numbers_from_1_to_n
{
    class NumbersFrom1toN
    {
        static void Main()
        {
            Console.Write("N : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
