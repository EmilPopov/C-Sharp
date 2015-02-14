//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.
//ha	fifi	ho	hi
//fo	 ha	    hi	xx   ==> ha ha ha
//xxx	 ho	    ha	xx
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence_N_Matrix
{
    class SequenceNMatrix
    {
        static void Main()
        {
            string[,] matrix = new string[3, 4]{
                {"ha","fifi","ho","hi"},
                {"fo","ha","hi","xx"},
                {"xxx","ho","ha","xx"},
            };
            int counter = 1;
            int maxCounter = 0;
            string element = String.Empty;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    // RIGHT
                    counter = 1;
                    for (int i = col + 1; i < matrix.GetLength(1); i++)
                    {
                        if (matrix[row, col] == matrix[row, i])
                        {
                            counter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        element = matrix[row, col];
                    }
                    // DOWN
                    counter = 1;
                    for (int i = row + 1; i < matrix.GetLength(0); i++)
                    {
                        if (matrix[row, col] == matrix[i, col])
                        {
                            counter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        element = matrix[row, col];
                    }
                    // DIAGONAL
                    counter = 1;
                    for (int i = row + 1; i < matrix.GetLength(0); i++)
                    {
                        if (matrix[row, col] == matrix[i, i])
                        {
                            counter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        element = matrix[row, col];
                    }
                }
            }
            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
