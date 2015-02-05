//Declare a character variable and assign it with the symbol that has Unicode code 42 
//(decimal) using the \u00XX syntax, and then print it.
using System;


namespace Unicode_Character
{
    class Program
    {
        static void Main()
        {
            char myChar = '\u002A';
            Console.WriteLine(myChar);
        }
    }
}
