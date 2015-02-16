//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.
using System;
using System.Text;


namespace Unicode_Characters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            string str = "Hi!";
            StringBuilder utf = new StringBuilder();
            foreach (char ch in str)
            {
                utf.AppendFormat("\\u{0:X4}", (int)ch);
            }
        }
    }
}
