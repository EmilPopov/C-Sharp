//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
using System;


namespace Correct_Brackets
{
    class CorrectBrackets
    {
        static void Main()
        {
            string expression = Console.ReadLine();
            Console.WriteLine(CheckBrackets(expression));
        }
        static bool CheckBrackets(string expression)
        {
            int count = 0;

            for (int i = 0; i < expression.Length && count >= 0; i++)
            {
                if (expression[i] == '(') 
                {
                    count++;
                }
                else if (expression[i] == ')')
                {
                    count--; 
                }
            }

            return count == 0;
        }
    }
}
