
//Write a program that reads the radius r of a 
//circle and prints its perimeter and area formatted with 2 digits after the decimal point.
using System;


namespace Circle_Perimeter_and_Area
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("R : ");
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Area : " + String.Format("{0:0.00}", area));            
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine("Perimeter : " + String.Format("{0:0.00}", perimeter));
        }
    }
}
