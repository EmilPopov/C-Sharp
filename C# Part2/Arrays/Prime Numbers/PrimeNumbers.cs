//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Numbers
{
    class PrimeNumbers
    {
        static void Main()
        {
            for (int i = 1; i < 10001; i++)
            {
                bool prime = PrimeTool.IsPrime(i);
                if (prime)
                {
                    Console.Write(i + " ");
                }
            }       
        }
        public static class PrimeTool
        {
            public static bool IsPrime(int number)
            {
                if ((number & 1) == 0)
                {
                    if (number == 2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                for (int i = 3; (i * i) <= number; i += 2)
                {
                    if ((number % i) == 0)
                    {
                        return false;
                    }
                }
                return number != 1;
            }
        }

    }
}
