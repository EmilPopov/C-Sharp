using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpets
{
    class Carpets
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 != 0)
            {
                Console.WriteLine("Enter Even Number");
            }
            for (int row = 1; row <= n/2 ; row++)
            {
                for (int col = 1; col <= n ;)
                {
                    if ((col <= n / 2 - row) || (col > n / 2 + row))
                    {
                        Console.Write(".");
                        col++;
                    }
                    else
                    {
                        for (int k = 0; k < row; k++)
                        {
                            if (k % 2 == 0)
                            {
                                Console.Write("/");
                                col++;
                            }
                            else
                            {
                                Console.Write(" ");
                                col++;
                            }
                        }
                        for (int k = row; k > 0; k--)
                        {
                            if (k % 2 != 0)
                            {
                                Console.Write("\\");
                                col++;
                            }
                            else
                            {
                                Console.Write(" ");
                                col++;
                            }
                            
                        }
                    }
                   
                }
                Console.WriteLine();
            }
            for (int row = n/2; row >= 1; row--)
            {
                for (int col = 1; col <= n;)
                {
                    if ((col <= n / 2 - row) || (col > n / 2 + row))
                    {
                        Console.Write(".");
                        col++;
                    }
                    else
                    {
                        for (int k = 0; k < row; k++)
                        {
                            if (k % 2 == 0)
                            {
                                Console.Write("\\");
                                col++;
                            }
                            else
                            {
                                Console.Write(" ");
                                col++;
                            }
                        }
                        for (int k = row; k > 0; k--)
                        {
                            if (k % 2 != 0)
                            {
                                Console.Write("/");
                                col++;
                            }
                            else
                            {
                                Console.Write(" ");
                                col++;
                            }

                        }
                    }
                   
                }
                Console.WriteLine();
            }
        }
    }
}
