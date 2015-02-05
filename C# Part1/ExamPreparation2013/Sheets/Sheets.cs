//Asya loves confetti. One day she decided to create exactly N small pieces of sheets with paper size A10.
//A10 is a standard for paper sizes. A9 is another standard that is twice as bigger as A10, so A9 can be cut into 2 
//pieces of size A10. A8 is twice as bigger as A9 and so on. A0 is twice as bigger as A1. See the picture on the left.
//Asya has only one sheet of each type (totally 11 sheets). She wants to have exactly N pieces of size A10 by cutting 
//as few sheets as possible.
//Asya should not have any wasted sheets.
//Write a program for her.
//For example if we want to cut sheets into 9 pieces with the size of A10, we will use the only A7 sheet 
//(cut into 8 pieces of size A10) and the only sheet with size A10. Then we will use 2 sheets. All other 9 
//sheets will not be used.

using System;

class Sheets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n,2).PadLeft(32,'0'));
        for (int i = 0; i < 11; i++)
        {
            int mask = 1;
            mask <<= i;

            if ((n & mask) == 0)
            {
                Console.WriteLine("A{0}", 10 - i);
            }
        }
    }
}