using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bits_to_Bits
{
    class BitsBits
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long[] numbers = new long[n];
            int sequenceZero = 1;
            int sequenceOne = 0;
            int sequenceZeroMax = 0;
            int sequenceOneMax = 0;
            int totalSeqZero = 0;
            int totalSeqOne = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = long.Parse(Console.ReadLine());
            }
            List<string> binary = new List<string>();
            for (int i = 0; i < numbers.Length; i++)
            {
                binary.Add(Convert.ToString(numbers[i], 2).PadLeft(30, '0'));
            }
            List<char> digits = new List<char>();
            for (int i = 0; i < binary.Count; i++)
            {
                digits.Clear();             
                digits = binary[i].ToList<char>();   // Clear list 
                for (int j = 0; j < digits.Count; j++)
                {
                    for (int k = j; k < digits.Count - j - 1; k++)
                    {
                        if (digits[k] == digits[k + 1])
                        {
                            if (digits[k] == '0')
                            {
                                sequenceZero++;
                            }
                            else if (digits[k] == '1')
                            {
                                sequenceOne++;
                            }
                        }                     
                    }
                    if (sequenceZero > sequenceZeroMax)
                    {
                        sequenceZeroMax = sequenceZero;
                        sequenceZero = 1;
                    }
                    else
                    {
                        sequenceZero = 1;
                    }
                    if (sequenceOne > sequenceOneMax)
                    {
                        sequenceOneMax = sequenceOne;
                        sequenceOne = 1;
                    }
                    else
                    {
                        sequenceOne = 1;
                    }
                }
                if (sequenceZeroMax > totalSeqZero)
                {
                    totalSeqZero = sequenceZeroMax;
                }
                if (sequenceOneMax > totalSeqOne)
                {
                    totalSeqOne = sequenceOneMax;
                }
            }
            Console.WriteLine(totalSeqZero);
            Console.WriteLine(totalSeqOne);

        }
    }
}

