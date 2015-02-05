//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and 
//solves it (prints its real roots).
using System;


namespace Quadratic_Equation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("A :");
            double a = double.Parse(Console.ReadLine());
            Console.Write("B :");
            double b = double.Parse(Console.ReadLine());
            Console.Write("C :");
            double c = double.Parse(Console.ReadLine());
            double discrim = (b * b) - 4 * a * c;

            if (discrim < 0)
            {
                Console.WriteLine("There are no real roots");
            }
            else
            {
                double discriminantRoot = Math.Sqrt(discrim);
                double x1 = (-b + discriminantRoot) / (2 * a);
                double x2 = (-b - discriminantRoot) / (2 * a);
                Console.WriteLine(x1 == x2 ? "One real root {0}": "Two real roots {0} {1}", x1, x2);
            }
        }
    }
}
