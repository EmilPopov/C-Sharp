//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;


namespace Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            Console.WriteLine("A : ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("B : ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("H : ");
            double h = double.Parse(Console.ReadLine());
            
            double s = (a + b) / 2 * h;
            Console.WriteLine("Area : " + s);
        }
    }
}
