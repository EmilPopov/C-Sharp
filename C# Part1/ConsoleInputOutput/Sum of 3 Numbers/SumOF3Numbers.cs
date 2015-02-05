//Write a program that reads 3 real numbers from the console and prints their sum.
using System;


namespace Sum_of_3_Numbers
{
    class SumOF3Numbers
    {
        static void Main()
        {
            double[] numbers = new double[3];
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
                sum += numbers[i];
            }
            Console.WriteLine("The sum is : " + sum);
        }
    }
}
