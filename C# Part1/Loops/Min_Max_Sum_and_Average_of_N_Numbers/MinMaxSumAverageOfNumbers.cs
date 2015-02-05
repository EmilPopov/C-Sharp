//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.
using System;


namespace Min_Max_Sum_and_Average_of_N_Numbers
{
    class MinMaxSumAverageOfNumbers
    {
        static void Main()
        {
            Console.Write("Enter N : ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out numbers[i]);
                sum += numbers[i];
            }
            Array.Sort(numbers);
            Console.WriteLine("BIggest : {0}", numbers[n - 1]);
            Console.WriteLine("Smalest : {0}", numbers[0]);
            Console.WriteLine("Sum : " + sum);
            Console.WriteLine("Average : {0:F2}", sum/n);
        }
    }
}
