// Implement an extension method Substring(int index, int length) for the class StringBuilder 
//  that returns new StringBuilder and has the same functionality as Substring in the class String.

namespace StringBuilderSubstring
{
    using System;
    using System.Text;
    public static class SubstringTest
    {
        public static StringBuilder Substring(this StringBuilder original, int index, int length)
        {
            return new StringBuilder(original.ToString(index, length));
        }

        static void Main()
        {
            var builder = new StringBuilder("Telerik");
            var result = builder.Substring(2, 3);
            Console.WriteLine(result);
        }
    }
}