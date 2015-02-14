//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.
using System;


namespace Say_Hello
{
    class SayHello
    {
        static void Main()
        {
            string name = Console.ReadLine();
            PrintHello(name);
        }

        static void PrintHello(string name)
        {
            Console.WriteLine("Hello,{0} !!!",name);
        }
    }
}
