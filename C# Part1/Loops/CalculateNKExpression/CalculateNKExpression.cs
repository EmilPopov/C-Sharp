//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
using System;

namespace CalculateNKExpression
{
    class CalculateNKExpression
    {
        static void Main()
        {
            Console.WriteLine("Enter value of N > 1");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of K<n<100");
            int k = int.Parse(Console.ReadLine());

            decimal result = 1;
            if (1 < k && n > k && n < 100)
            {
                for (int i = k + 1; i <= n; i++)
                {
                    result *= i;
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.WriteLine("N!/!K = {0}", result);
        }
    }
}
