//Write a program to convert binary numbers to their decimal representation
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_To_Decimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            string binNum = "1111010110011110";
            int decNum = 0;
            for (int i = binNum.Length - 1, p = 1; i >= 0; i--, p *= 2)
            {
                decNum += (binNum[i] - '0') * p;
            }
            Console.WriteLine(decNum);
            // Or ----------------------------------------------------------------------------
            Console.WriteLine(Convert.ToInt32(binNum, 2).ToString());
        }
    }
}
