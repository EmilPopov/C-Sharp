//Write a program that prints an isosceles triangle of 9 copyright spaceInShapes ©, something like this:
//   ©

//  © ©

// ©   ©

//© © © ©
using System;


namespace Isosceles_Triangle
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char copy = '\u00a9';
            int width = 11;
            string space = new String(' ', (width - 1) / 2);
            Console.WriteLine(space + copy + space);

            string spaceInShape;
            for (int i = 0, j = 4; j > 0; i++, j--)
            {
                space = new String(' ', j);
                spaceInShape = new String(' ', i * 2 + 1);

                Console.WriteLine(space + copy + spaceInShape + copy);
            }

            for (int i = 0; i < width; i++)
            {
                if (i % 2 == 1) Console.Write(' ');
                else Console.Write(copy);
            }

            Console.WriteLine();
        }
    }
}
