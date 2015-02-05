//Write an expression that checks if given positive integer number n 
//(n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
using System;


namespace Prime_Number_Check
{
    class PrimeNumber
    {
        static void Main()
        {
            for (int i = 2; i <= 100; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= (int)Math.Sqrt(i); j++)
                {
                    if (i % j == 0) isPrime = false;
                }
                if (isPrime)
                    Console.WriteLine("{0} is prime number.", i);
            }

        }
    }
}
