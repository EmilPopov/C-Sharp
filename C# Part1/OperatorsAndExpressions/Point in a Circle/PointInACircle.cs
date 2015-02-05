//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2)
using System;


namespace Point_in_a_Circle
{
    class PointInACircle
    {
        static void Main()
        {
            Console.WriteLine("Please enter the coordinates X & Y :");

            Console.Write("X:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Y:");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Circle radius: ");          
            double circleRadius = double.Parse(Console.ReadLine()); ;

            if ((x * x + y * y) <= (circleRadius * circleRadius))         
            {
                Console.WriteLine("The given point IS within a circle");
            }
            else
            {
                Console.WriteLine("The given point IS NOT within a circle");
            }
        }
    }
}
