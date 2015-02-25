using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypothenuseOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b : ");
            double b = double.Parse(Console.ReadLine());
            double hipothenuse = Math.Sqrt(a * a + b * b);
            Console.WriteLine("Hypothenuse is : {0}",hipothenuse);

        }
    }
}
