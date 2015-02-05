//Write an expression that checks for given integer if its third digit from right-to-left is 7
using System;


namespace Third_Digit_is_7
{
    class ThirdDigitIs7
    {
        static void Main()
        {
            Console.Write("Please enter a number:");
            int num = int.Parse(Console.ReadLine());
            int thirdDigit = (num / 100) % 10; 
            if (thirdDigit == 7)               
            {                                  
                Console.WriteLine("The third digits IS seven!");
            }
            else
            {
                Console.WriteLine("The third digit IS NOT seven.");
            }

        }
    }
}
