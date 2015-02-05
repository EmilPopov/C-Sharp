//You all know the Fibonacci sequence. Well, the Tribonacci sequence is almost the same, but it uses the last 
//three numbers (instead of the last two) to calculate the next number in the sequence. So, we can define each element in the sequence as:
//T n = T n-1 + T n-2 + T n-3
//where T n is the current Tribonacci number (n is the index of the current Tribonacci number).
//The Tribonacci sequence can begin with any three integer numbers – positive or negative – and continue as described by the 
//formula above.
//Now, a Tribonacci triangle is a triangle of numbers from the Tribonacci sequence. The first line of the triangle 
//contains only the first number of the Tribonacci sequence. The second line contains the second and third numbers of the 
//Tribonacci sequence, separated by a single whitespace (" ").
//The third line contains the next three numbers of the Tribonacci sequence (again, separated by whitespaces). The fourth 
//line contains the next four numbers and so on. Basically, every line contains one more number than the previous.
//Your task is to write a program, which prints to the console a Tribonacci triangle by given the first three numbers of the 
//Tribonacci sequence, and the number of lines in the triangle.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tribonacci_Triangle
{
    class TribonacciTriangle
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int n = 3;
            for (int i = 4; i <=l; i++)
            {
                n += i;
            }
            List<int> numbers = new List<int> {a,b,c};
            for (int i = 0; i < n; i++)
            {
                numbers.Add(numbers[numbers.Count-1] + numbers[numbers.Count-2] + numbers[numbers.Count-3]);
            }
            int counter = 0;
            int index = 0;
            for (int row = 0; row < l; row++)
            {
                for (int col = 0; col <=row; col++)
                {
                    if (col < l)
                    {
                        Console.Write(numbers[col + index] + " ");
                        counter++;
                    }
                }
                index = counter;
                Console.WriteLine();
            }
        }
    }
}
