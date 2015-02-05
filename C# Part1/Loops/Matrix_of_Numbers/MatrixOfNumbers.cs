//Write a program that reads from the console a positive integer number n (1 = n = 20) 
//and prints a matrix like in the examples below. Use two nested loops.
using System;


namespace Matrix_of_Numbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("Enter N < 20 : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= i + n - 1; j++)
                {
                    Console.Write(" {0} ", j);
                }
                Console.WriteLine();
            }
        }
    }
}
