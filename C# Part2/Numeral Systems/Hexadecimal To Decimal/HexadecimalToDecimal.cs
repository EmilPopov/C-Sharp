//Write a program to convert hexadecimal numbers to their decimal representation
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexadecimal_To_Decimal
{
    class HexadecimalToDecimal
    {
        static void Main()
        {
            string hex ="B76";
            int decNum = Convert.ToInt32(hex, 16);
            Console.WriteLine(decNum);
            // Or ----------------------------------------------
            int dec = 0;

            for (int i = hex.Length - 1, p = 1; i >= 0; i--, p *= 16)
            {
                if (hex[i] >= 'A')
                {
                    dec += (hex[i] - 'A' + 10) * p;
                }
                else
                {
                    dec += (hex[i] - '0') * p;
                }
            }
            Console.WriteLine(dec);
          
        }
    }
}
