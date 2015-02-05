//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.
using System;


namespace Play_with_Int__Double_and_String
{
    class IntDoubleString
    {
        static void Main()
        {
            Console.WriteLine(@"Please choose a type:	
                    1 --> int	
                    2 --> double	
                    3 --> string");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.Write("Please enter a int: ");
                int numInt = int.Parse(Console.ReadLine());
                Console.WriteLine(numInt);
            }
            else if (choice == 2)
            {
                Console.Write("Please enter a double: ");
                double numDouble = double.Parse(Console.ReadLine());
                Console.WriteLine(numDouble);
            }
            else if (choice == 3)
            {
                Console.Write("Please enter a string: ");
                string str = Console.ReadLine();
                Console.WriteLine(str + "*");
            }
        }
    }
}
