//Write a program that reads a string, reverses it and prints the result at the console.
using System;


namespace Reverse_String
{
    class ReverseString
    {
        static void Main()
        {
            string str = Console.ReadLine();
            char[] arrStr = str.ToCharArray();
            Array.Reverse(arrStr);
            Console.WriteLine(string.Join("",arrStr));
        }
    }
}
