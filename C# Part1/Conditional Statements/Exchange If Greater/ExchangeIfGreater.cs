//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one.
//As a result print the values a and b, separated by a space.
using System;


namespace Exchange_If_Greater
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.Write("A = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B= ");
            int b = int.Parse(Console.ReadLine());
            int c;
            if (a > b)
            {
                c = a;
                a = b;
                b = c;
            }
            Console.WriteLine("A = " + a + " B =" + b);
        }
    }
}
