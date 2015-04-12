//Write a program to convert hexadecimal numbers to binary numbers (directly).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexadecimal_To_Binary
{
    class HexadecimalToBinary
    {
        static void Main()
        {
            string hex = "B76";
            string binarystring = String.Join(String.Empty, 
                hex.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
            Console.WriteLine(binarystring);
            // Or -------------------------------------------------------------------------------------------
            string bin = String.Empty;

            // Get each hex digit in base 2
            for (int i = hex.Length - 1; i >= 0; i--)
                for (int j = 0, d = GetNumber(hex, i); j < 4; j++, d /= 2) // 2 ^ 4 = 16
                {
                    bin = d % 2 + bin;
                }
            Console.WriteLine(bin);

        }
        static int GetNumber(string hex, int i)
        {
            if (hex[i] >= 'A')
            {
                return hex[i] - 'A' + 10;
            }
            else
            {
                return hex[i] - '0';
            }
        }
    }
}
