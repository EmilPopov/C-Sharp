//Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that
//enters a string and prints “yes” if it is a valid card sign or “no” otherwise. 
using System;


namespace Check_for_a_Play_Card
{
    class CheckPlayCard
    {
        static void Main()
        {
            Console.Write("Enter sign : ");
            string sign = Console.ReadLine();
            string[] cardSigns = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "J", "Q", "K" };
            string answer = string.Empty;
            for (int i = 0; i < cardSigns.Length; i++)
            {
                if (cardSigns[i] == sign)
                {
                    answer = "yes";
                    break;
                }
                else
                {
                    answer = "no";
                }
            }
            Console.WriteLine(answer);
        }
       
    }
}
