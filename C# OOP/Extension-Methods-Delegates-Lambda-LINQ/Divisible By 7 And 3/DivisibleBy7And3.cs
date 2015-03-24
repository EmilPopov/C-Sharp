//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace Divisible_By_7_And_3
{
    using System.Collections.Generic;
    using System.Linq;
    class DivisibleBy7And3
    {
        static void Main()
        {
            var numbers = Enumerable.Range(1, 100);
            var list = numbers.Where(n => (n % 3 == 0) && (n % 7 == 0));
            foreach (var n in list)
            {
                System.Console.Write(n + " ,");
            }
        }
    }
}
