//Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
//Use Windows Calculator to find its hexadecimal representation.
//Print the variable and ensure that the result is 254.
using System;


namespace Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main()
        {
            int myInt = 254;
            string myHex = myInt.ToString("X");
            int myNewInt = Convert.ToInt32(myHex, 16);
            Console.WriteLine(myNewInt);
        }
    }
}
