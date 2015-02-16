//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:
//The target sub-string is in
//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. 
//We will move out of it in 5 days.
//The result is: 9
using System;


namespace Sub_string_in_text
{
    class SubStringInText
    {
        static void Main()
        {
            int counter = 0;
            int lastIndex = 0;
            string str = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            for (int i = 0; i < str.Length; i++)
            {
                i = str.IndexOf("in",i);
                if (lastIndex <= i)
                {
                    counter++;
                    lastIndex = i;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("in => {0}",counter);
        }
    }
}
