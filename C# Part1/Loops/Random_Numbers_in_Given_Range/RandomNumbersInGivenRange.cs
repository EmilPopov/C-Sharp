//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
using System;


namespace Random_Numbers_in_Given_Range
{
    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            Console.WriteLine("N : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Min : ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Max : ");
            int max = int.Parse(Console.ReadLine());
            Random randomGenerator = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.Write(randomGenerator.Next( min, max+1 )+ " ");
            }
        }
    }
}
