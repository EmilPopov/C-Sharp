//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5)
//and out of the rectangle R(top=1, left=-1, width=6, height=2).
using System;


namespace Point_Inside_a_Circle__Outside_of_a_Rectangle
{
    class PointCircleRectangle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double radius = 1.5;

            bool isInCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= radius * radius;
            bool isInRectangle = ((x < -1 || x > 5) && (y < -1 || y > 1));
            
                                   


            Console.WriteLine(isInCircle && !isInRectangle);
        }
    }
}
