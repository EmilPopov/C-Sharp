//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
using System;


namespace Sum_of_5_Numbers
{
    class SumOfFiveNumbers
    {
        static void Main()
        {
            double[] numbers = new double[5];
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
                sum += numbers[i];
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    Console.Write(numbers[i] + " = "  + sum);
                }
                else
                {
                    Console.Write(numbers[i] + " + ");
                }
            }
        }
    }
}
