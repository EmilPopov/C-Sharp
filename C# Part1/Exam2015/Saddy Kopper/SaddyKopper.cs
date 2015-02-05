using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saddy_Kopper
{
    class SaddyKopper
    {
        static void Main()
        {
            long product = 1;
            long result = 1;
            long sum = 0;
            int transformation = 0;
            string number = Console.ReadLine();
            if (number.Length < 8)
            {
                number = Console.ReadLine(); 
            }
            while ((transformation < 10) && (number.Length > 1))
            {
                List<int> digits = new List<int>();
                for (int i = 0; i < number.Length; i++)
                {
                    digits.Add(number[i] - '0');
                }
                for (int i = digits.Count - 1; i > 0; i--)
                {
                    digits.RemoveAt(digits.Count-1);
                    if (i > 0)
                    {
                        for (int j = 0; j < digits.Count; j++)
                        {
                            if (j % 2 == 0)
                            {
                                sum += digits[j];
                            }
                        }
                    }
                    product *= sum;
                    sum = 0;
                }
                transformation++;
                result = product;
                number = product.ToString();
                product = 1;
                digits.Clear();
                if ((transformation < 10) && (number.Length == 1))
                {
                    Console.WriteLine(transformation);
                    Console.WriteLine(result);
                } 
                else if (transformation == 10)
	            {
		            Console.WriteLine(result);
	            }
            }           
        }      
    }
}
