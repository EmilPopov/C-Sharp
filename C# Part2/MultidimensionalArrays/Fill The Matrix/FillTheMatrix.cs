//Write a program that fills and prints a matrix of size (n, n) as shown below:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fill_The_Matrix
{
    class FillTheMatrix
    {
        static void Main()
        {
            //----------------------------------------------------- A ---------------------------------------------------------------
            //           1 5 9  13
            //           2 6 10 14
            //           3 7 11 15
            //           4 8 12 16

            int[,] matrix = new int[4, 4];
            int maxRowIndex = 4 - 1;
            int maxColIndex = 4 - 1;
            int counter = 1;
            for (int col = 0; col <= maxColIndex; col++)
            {
                for (int row = 0; row <= maxRowIndex; row++)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write(matrix[rows, cols] + " ");
                }
                Console.WriteLine();
            }


            //--------------------------------------------------- B ----------------------------------------------------------------
            //          1 8 9  16
            //          2 7 10 15
            //          3 6 11 14
            //          4 5 12 13
            //int[,] matrix = new int[4, 4];
            //int colIndex = 0;
            //int rowIndex = 0;
            //int maxRowIndex = 4 - 1;
            //int maxColIndex = 4 - 1;
            //int counter = 1;

            //for (int i = 0; i <= maxColIndex; i++)
            //{
            //    colIndex = i;
            //    if (colIndex % 2 == 0)
            //    {
            //        for (int j = rowIndex; j <= maxRowIndex; j++)
            //        {
            //            matrix[j, colIndex] = counter;
            //            counter++;
            //        }
            //    }
            //    else if (colIndex % 2 != 0)
            //    {
            //        for (int j = maxRowIndex; j >= rowIndex; j--)
            //        {
            //            matrix[j, colIndex] = counter;
            //            counter++;
            //        }
            //    }
            //}

            //for (int rows = 0; rows < matrix.GetLength(0); rows++)
            //{
            //    for (int cols = 0; cols < matrix.GetLength(1); cols++)
            //    {
            //        Console.Write(matrix[rows, cols] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //---------------------------------------------------------------- C ----------------------------------------------------
            //       7 11 14 16
            //       4 8  12 15
            //       2 5  9  13
            //       1 3 6   10

            //int[,] matrix = new int[4, 4];
            //int colIndex = 0;
            //int rowIndex = 3;
            //int maxRowIndex = 4 - 1;
            //int maxColIndex = 4 - 1;
            //int counter = 1;
            //for (int i = 0; i <= maxRowIndex; i++)
            //{
            //    colIndex = 0;
            //    rowIndex -= i;
            //    matrix[rowIndex, colIndex] = counter;
            //    counter++;
            //    for (int j = 0; j < i; j++)
            //    {
            //        rowIndex++;
            //        colIndex++;
            //        matrix[rowIndex, colIndex] = counter;
            //        counter++;
            //    }
            //}
            //for (int i = 1; i <= maxColIndex; i++)
            //{
            //    rowIndex = 0;
            //    colIndex = i;
            //    matrix[rowIndex, colIndex] = counter;
            //    counter++;
            //    for (int j = maxColIndex; j > i; j--)
            //    {
            //        rowIndex++;
            //        colIndex++;
            //        matrix[rowIndex, colIndex] = counter;
            //        counter++;
            //    }
            //}
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        Console.Write(matrix[row, col] + " ");
            //    }
            //    Console.WriteLine();
            //}
            // ------------------------------------------------------ D -----------------------------------------------------------  
            //      1 12 11 10
            //      2 13 16  9
            //      3 14 15  8
            //      4  5  6  7 
            //Console.WriteLine("Enter N : ");
            //int n = int.Parse(Console.ReadLine());
            //int[,] matrix = new int[n, n];
            //int rowIndex = 0;
            //int colIndex = 0;
            //int maxRowIndex = matrix.GetLength(0) - 1;
            //int maxColIndex = matrix.GetLength(1) - 1;
            //int counter = 1;
            //do
            //{
            //    // DOWN
            //    for (int row = rowIndex; row <= maxRowIndex; row++)
            //    {
            //        matrix[row, colIndex] = counter;
            //        counter++;
            //    }
            //    // RIGHT                         
            //    colIndex++;
            //    for (int col = colIndex; col <= maxColIndex; col++)
            //    {
            //        matrix[maxRowIndex, col] = counter;
            //        counter++;
            //    }
            //    // UP
            //    maxRowIndex--;
            //    for (int row = maxRowIndex; row >= rowIndex; row--)
            //    {
            //        matrix[row, maxColIndex] = counter;
            //        counter++;
            //    }
            //    // LEFT
            //    maxColIndex--;
            //    for (int col = maxColIndex; col >= colIndex; col--)
            //    {
            //        matrix[rowIndex, col] = counter;
            //        counter++;
            //    }
            //    rowIndex++;
            //}
            //while (counter <= n * n);
            //{
            //    for (int rows = 0; rows < matrix.GetLength(0); rows++)
            //    {
            //        for (int cols = 0; cols < matrix.GetLength(1); cols++)
            //        {
            //            Console.Write(matrix[rows, cols] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
        }
    }
}
