﻿//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.
using System;

namespace String_Length
{
    class StringLength
    {
        static void Main()
        {
            string str = Console.ReadLine();
            if (str.Length < 20)
            {
                Console.WriteLine(str.PadRight(20, '*'));
            }
        }
    }
}
