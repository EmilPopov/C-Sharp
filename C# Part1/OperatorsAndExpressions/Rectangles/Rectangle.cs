//Write an expression that calculates rectangle’s perimeter and area by given width and height.
using System;


namespace Rectangles
{
    class Rectangle
    {
        static void Main()
        {
            Console.Write("Width : ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height : ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Press 1 for Perimeter or 2 for Area : ");
            int choice = int.Parse(Console.ReadLine());
            if (choice==1)
            {
                double perimeter = 2*(width + height);
                Console.WriteLine("Perimeter : "+ perimeter);
            }
            else if (choice==2)
            {
                double area = width * height;
                Console.WriteLine("Area : " + area);
            }
            else
            {
                Console.WriteLine("Invalid input !!!");
            }
        }
    }
}
