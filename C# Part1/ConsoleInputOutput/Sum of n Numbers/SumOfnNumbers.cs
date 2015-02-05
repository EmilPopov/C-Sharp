//Write a program that enters a number n and after that enters more n numbers and calculates and prdoubles their sum
using System;


namespace Sum_of_n_Numbers
{
    class SumOfnNumbers
    {
        static void Main()
        {
            Console.Write("Enter N : ");
            int n = int.Parse(Console.ReadLine());
            double[] numbers = new double[n];
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                double.TryParse(Console.ReadLine(), out numbers[i]);
                sum += numbers[i];
            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
}
