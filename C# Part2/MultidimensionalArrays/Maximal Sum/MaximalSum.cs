//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximal_Sum
{
    class MaximalSum
    {
        static void Main()
        {
            Console.Write("Enter N : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter M : ");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            // For test 
                //    int[,] matrix = {
                //{ 0, 2, 4, 0, 9, 5 },
                //{ 7, 1, 3, 3, 2, 1 },
                //{ 1, 3, 9, 8, 5, 6 },
                //{ 4, 6, 7, 9, 1, 0 }
                //    };
            int currentSum = 0;
            int rowIndex = 0;
            int colIndex = 0;
            int sum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {

                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                 matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                                 matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currentSum > sum)
                    {
                        sum = currentSum;
                        currentSum = 0;
                        rowIndex = row;
                        colIndex = col;
                    }
                    else
                    {
                        currentSum = 0;
                    }
                }

            }
            Console.Write("The matrix[3,3] with Max Sum is : ");
            Console.WriteLine(sum);
            Console.WriteLine("{0} {1} {2}", matrix[rowIndex, colIndex], matrix[rowIndex, colIndex + 1],
                                             matrix[rowIndex, colIndex + 2]);
            Console.WriteLine("{0} {1} {2}", matrix[rowIndex + 1, colIndex], matrix[rowIndex + 1, colIndex + 1],
                                             matrix[rowIndex + 1, colIndex + 2]);
            Console.WriteLine("{0} {1} {2}", matrix[rowIndex + 2, colIndex], matrix[rowIndex + 2, colIndex + 1],
                                             matrix[rowIndex + 2, colIndex + 2]);
        }
    }
}
