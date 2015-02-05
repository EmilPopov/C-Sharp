//A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a 
//single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
using System;


namespace Employee_Data
{
    class Program
    {
        static void Main()
        {
            Console.Write("First name : ");
            string firstName = Console.ReadLine();
            Console.Write("Last name : ");
            string lastName = Console.ReadLine();
            Console.Write("Genger(m or f) : ");
            char genger = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Write("Age : ");
            byte age = byte.Parse(Console.ReadLine());
            Console.Write("Personal ID number : ");
            long id = long.Parse(Console.ReadLine());
            Console.Write("Unique employee number : ");
            long uniqueNum = long.Parse(Console.ReadLine());
            Console.WriteLine(@"Employee:           {0} {1}
                                Gender:             {2}
                                Age                 {3}
                                ID                  {4}
                                Employee Number:    {5}",firstName,lastName,genger,age,id,uniqueNum);
        }
    }
}
