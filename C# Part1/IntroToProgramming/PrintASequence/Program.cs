//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
using System;


namespace PrintASequence
{
    class PrintThisSequence
    {
        static void Main()
        {
            int oddNumber;
            for (int i = 2; i <=11; i++)
            {
                if (i % 2 != 0)
                {
                    oddNumber = i * -1;
                    Console.Write("{0} ,",oddNumber);
                }
                else
                {
                    Console.Write("{0} ,", i);                    
                }
            }
        }
    }
}
