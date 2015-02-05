//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.
using System;


namespace Null_Values_Arithmetic
{
    class NullValues
    {
        static void Main()
        {
            int? a = null;
            double? b = null;
            Console.WriteLine(a+" "+b);
            Console.WriteLine((a + 5) + " " + (b+5));
            a = 7;
            b = 8;
            Console.WriteLine(a + " " + b);
        }
    }
}
