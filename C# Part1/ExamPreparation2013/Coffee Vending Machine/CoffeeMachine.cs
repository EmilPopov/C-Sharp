//The machine has five trays – for 0.05, 0.10, 0.20, 0.50, and 1.00 BGN respectively. We are given the number of coins available in each tray N1, N2, …, N5 inside the machine (N1 corresponds to 0.05, N2 corresponds to 0.10 and so on). We are also given the amount A of money the developer has put into the machine, and the price P of the drink.
//Write a program to calculate whether the machine can give change to the developer. There are three possible cases:
//•	The machine has enough coins in its trays to give the change.
//•	The machine waits for the developer to put more coins (in order to reach the amount A).
//•	The machine does not have enough coins to give the change.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Vending_Machine
{
    class CoffeeMachine
    {
        static void Main()
        {
            double[] trys = new double[5] { 0.05, 0.1, 0.2, 0.5, 1 };
            double sum = 0;
            for (int i = 0; i < trys.Length; i++)
            {
                sum += double.Parse(Console.ReadLine()) * trys[i];
            }
            double amount = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double change = amount - price;
            double moneyInMachine = sum - change;
            if ((change >= 0) && (moneyInMachine >= 0))
            {
                Console.WriteLine("Yes {0:F2}", moneyInMachine);
            }
            else if (change < 0)
            {
                Console.WriteLine("More {0:F2}", change * -1);
            }
            else if (moneyInMachine < 0)
            {
                Console.WriteLine("No {0:F2}",moneyInMachine * -1);
            }
        }
    }
}
