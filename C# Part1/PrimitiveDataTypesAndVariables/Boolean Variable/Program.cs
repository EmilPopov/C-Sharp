//Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
//Print it on the console.
using System;


namespace Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Are you male(Yes/No):");
            string result = Console.ReadLine();
            bool isMale = true;
            if (result == "Yes")
            {
                Console.WriteLine(isMale);
            }
            else if (result == "No")
            {
                isMale = false;
                Console.WriteLine(isMale);
            }
            else
            {
                Console.WriteLine("Invalid input !");
            }
        }
    }
}
