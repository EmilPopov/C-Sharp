//write a program to calculate n! for each n in the range [1..100].
using System;
using System.Numerics;

namespace N_Factorial
{
    class NFactorial
    {
        static void Main()
        {
            int number = 100;
            Console.WriteLine(CalcNFactoral(number)); ;
        }

        private static BigInteger CalcNFactoral(int number)
        {
            BigInteger facturel = 1;
            for (int i = 1; i < number; i++)
            {
                facturel *= i;
            }

            return facturel;
        }
    }
}
