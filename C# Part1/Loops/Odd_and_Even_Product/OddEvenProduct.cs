//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
using System;



namespace Odd_and_Even_Product
{
    class OddEvenProduct
    {
        static void Main()
        {
            Console.Write("N : ");
            int n = int.Parse(Console.ReadLine());
            double[] numbers = new double[n];
            double oddProduct = 1;
            double evenProduct = 1;
            for (int i = 0; i < numbers.Length; i++)
			{
			 numbers[i] = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
	                {
		                 evenProduct *= numbers[i];
	                }
                else
	                {
		                 oddProduct *= numbers[i];
	                }
			}
            if (oddProduct == evenProduct)
            {
                Console.WriteLine("Yes => Product : " + oddProduct);
            }
            else
            {
                Console.WriteLine(@"No => Odd Product : {0}
Even Product : {1}",oddProduct,evenProduct );
            }
        }
    }
}