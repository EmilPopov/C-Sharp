//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0
using System;


namespace Solve_Tasks
{
    class SolveTasks
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("For Reverse Number                    Pres 1");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("For Calculate the avarege of sequence  Pres 2");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("For Linear Equation a * x + b = 0      Pres 3");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.Write("Your choice is : ");
            int choice = int.Parse(Console.ReadLine());
            while (choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid Input !!!");
                Console.Write("Your choice is : ");
                choice = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            UserChoice(choice);
        }

        private static void UserChoice(int choice)
        {
            if (choice == 1)
            {
                Reverse();
            }
            if (choice == 2)
            {
                CalcTheAavaregeOfSequence();
            }
            if (choice == 3)
            {
                LinearEquation();
            }
        }

        private static void LinearEquation()
        {
            Console.Write("Enter  a : ");
            int a = int.Parse(Console.ReadLine());
            while (a == 0)
            {
                Console.Write("Invalid !!! Enter a : ");
                a = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter b : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("X = {0}", (-b / (double)a));

        }

        private static void CalcTheAavaregeOfSequence()
        {
            Console.Write("Sequence Length : ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Number {0} : ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine("Sum is : " + sum);
            Console.WriteLine("Average is : " + sum / (double)n);
        }

        static void Reverse()
        {
            Console.Write("Enter number : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Reverse number : " + ReverseNum(num));
        }

        private static int ReverseNum(int num)
        {
            int count = DigitsCount(num);
            int reverseNum = 0;
            int digit = 0;
            for (int i = count - 1; i >= 0; i--)
            {
                digit = num % 10;
                num /= 10;
                reverseNum += digit * (int)Math.Pow(10, i);
            }
            return reverseNum;
        }

        private static int DigitsCount(int num)
        {
            int count = 0;
            while (num > 0)
            {
                num /= 10;
                count++;
            }
            return count;
        }
    }
}
