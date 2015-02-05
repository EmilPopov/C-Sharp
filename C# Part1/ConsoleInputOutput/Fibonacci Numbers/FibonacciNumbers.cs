//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) 
//: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …
using System;


namespace Fibonacci_Numbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter N : ");
            int n = int.Parse(Console.ReadLine());
            double a = 0;
            double b = 1;
            double c;
            Console.WriteLine(b);
            for (int i = 1; i <= n; i++)
            {
                c = a;
                a = b;
                b = c + a;
                Console.Write(b + " , ");
            }
        }
    }
}
