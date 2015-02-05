//The residents of Bitlandia are huge sports fans. The bits have played almost every single sport that they have learned from watching human TV i.e. EuroBitSport and BitTV. Today for the first time they watched Formula 1 and now they certainly want to build a local track and start practicing right away. Of course the bits don’t want to copy the humans. They want to be unique and therefore they’ve added some special rules:
//1.	The track must be built on a grid of 8x8 cells, containing only zeros and ones. 
//2.	The track itself must contain only zeros. The width of the track will be one cell.
//3.	The track must start from the upper right corner and end on the lower left corner.
//4.	The cars can move only in 3 directions – South (down), West (left) And North (up). 
//5.	The first direction must always be south.
//6.	The cars must move in the current direction, while it is possible i.e. the cars can turn only when it reaches the end of the grid or a cell, containing a bit with a value of one.
//7.	The cars can switch between directions only in the following order:
//South -> West -> North -> West (and then again South -> West and so on)
//You will receive information about the grid as a list of 8 bytes (positive integers in the range [0…255]) n0, n1, …, n7. The grid itself is represented by the bits of those bytes.
//Your task is to find whether a track can be built on the given grid. If the grid is appropriate, you should print the length of the track and the count of the turns in it (the switches between directions), otherwise you should print “No” and the length of the track until it was interrupted.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula_Bit_1
{
    class FormulaBit
    {
        static void Main()
        {
            int[] numbers = new int[8];
            List<string> binaryNum = new List<string>();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i]= int.Parse(Console.ReadLine());
                binaryNum.Add(Convert.ToString(numbers[i], 2).PadLeft(8, '0'));
            }
            char[,] track = new char[8, 8];
            for (int row = 0; row < track.GetLength(0); row++)
            {
                for (int col = 0; col < track.GetLength(1); col++)
                {
                    track[row, col] =binaryNum[row][col];
                  //  Console.Write(track[row, col]);
                }
               // Console.WriteLine();                
            }
            int turns = 0;// to emplementation !!!
            int lenght =0;
            string lastDirection = "south";
            string direction = "south";
            bool end = false;
           
            for (int row = 0; row < track.GetLength(0);)
            {
                for (int col = 7; col >=0;)
                {
                     // fall start 
                    if (direction == "south")   //SOUTH
                    {
                        if ((row + 1 <= 7) && (track[row + 1, col] == '0'))
                        {
                            row++;
                            lenght++;
                            lastDirection = "south";
                        }
                        else if (track[row, col - 1] == '0') // turn west
                        {
                            direction = "west";
                            turns++;
                        }
                        else
                        {
                            lenght++;
                            end = false;
                            row = 8;
                            break;
                        }
                    }
                    else if (direction == "west") // WEST
                    {
                        if ((col - 1 >= 0) && (track[row, col - 1] == '0'))
                        {                            
                                col--;
                                lenght++;                      
                        }                      
                        else if ((lastDirection=="south") && (track[row - 1, col] == '0')) // turn north
                        {
                            direction = "north";
                            turns++;
                        }
                        else if ((lastDirection == "north") && (track[row + 1, col] == '0')) // turn south
                        {
                            direction = "south";
                            turns++;
                        }
                        else
                        {
                            lenght++;
                            end = false;
                            row = 8;
                            break;
                        }
                    }
                    else if (direction == "north") //NORTH
                    {
                        
                        if ((row-1 >= 0) && (track[row - 1, col] == '0'))
                        {
                            row--;
                            lenght++;
                            lastDirection = "north";
                        }                           
                        
                         else if (track[row, col - 1] == '0')
                        {
                            direction = "west";
                            turns++;
                        }
                        else
                        {
                            lenght++;                             
                            end = false;
                            row = 8;
                            break;
                        }
                       
                    }
                    if(row == 7 && col== 0)
                    {
                        lenght++;
                        end = true;
                        row++;
                        break;
                    }
                }
            }
            if (end == false)
            {
                Console.WriteLine("No {0}",lenght);               
            }
            else
            {
                Console.WriteLine("{0} {1}",lenght,turns);
            }


        }
    }
}
