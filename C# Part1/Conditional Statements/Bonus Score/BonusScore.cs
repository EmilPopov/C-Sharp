//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”
using System;


namespace Bonus_Score
{
    class BonusScore
    {
        static void Main()
        {
            Console.Write("Score : ");
            int score = int.Parse(Console.ReadLine());
            if (1 <= score && score <= 3)
            {
                Console.WriteLine("BonusScore : " + score * 10);
            }
            else if (4 <= score && score <= 6)
            {
                Console.WriteLine("BonusScore : " + score * 100);                
            }
            else if (7 <= score && score <= 9)
            {
                Console.WriteLine("BonusScore : " + score * 1000);                                
            }
            else if(score <= 0 || score > 9)
            {
                Console.WriteLine("Invalid score !!!");
            }
        }
    }
}
