//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
using System;

namespace Print_Long_Sequence
{
    class Program
    {
        static void Main()
        {
            for (int i = 2; i < 1002; i++)
            {
                if (i % 2 != 0)
                {
                    int n = i * -1;
                    Console.Write("{0} , ", n);
                }
                else
                {
                    Console.Write("{0} , ", i);

                }
            }
        }
    }
}
