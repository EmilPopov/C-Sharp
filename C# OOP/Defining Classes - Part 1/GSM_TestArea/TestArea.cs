using System;
using System.Collections.Generic;

namespace GSM_TestArea
{
    class TestArea
    {
        static void Main()
        {
            Battery firstBattery = new Battery("Model1", 150, 40, BatteryType.Li_Ion);
            Battery secondBattery = new Battery("Model2", 200, 45, BatteryType.LiPol);
            Battery thirdBattery = new Battery("Model3", 180, 42, BatteryType.NiMH);
            Display firstDisplay = new Display(4, 15000);
            Display secondDisplay = new Display(4.5, 5000);
            Display thirdDisplay = new Display(4.8, 85000);
            //Create an array of few instances of the GSM class
            GSM[] gsms =new GSM[4];
            gsms[0] = new GSM("Galacsy 2", "Samsubg", firstBattery, firstDisplay);
            gsms[1] = new GSM("Galacsy 3", "Samsubg", secondBattery,secondDisplay);
            gsms[2] = new GSM("Galacsy 4", "Samsubg", thirdBattery, thirdDisplay);
            gsms[3] = GSM.IPhone4S;
            //Display the information about the GSMs
            foreach (var gsm in gsms)
            {
                Console.WriteLine(gsm.ToString());
                Console.WriteLine(new string('-', 80));
               
            }
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('-', 80));
            Console.BackgroundColor = ConsoleColor.Black;
            //----------------------------------------------------------------------------------------
            GSM myGsm = new GSM("GALAXY 5S", "Samsung");
            Call firstCall = new Call(new DateTime(2014,7,23,10,24,02),"+3598953526381",84);
            Call secondCall = new Call(new DateTime(2014,7,23,16,33,43),"+3598957956384",33);
            Call thirdCall = new Call(new DateTime(2014,7,23,14,56,59),"+3598689352639",12);
            Call fourthCall = new Call(new DateTime(2014,7,23,16,23,33),"+3598953526889",184);
            myGsm.AddCall(firstCall);
            myGsm.AddCall(secondCall);
            myGsm.AddCall(thirdCall);
            myGsm.AddCall(fourthCall);
            //print call history
            myGsm.ShowCallHistory();
            Console.WriteLine(new string('-', 80));
            //print price of all calls
            Console.WriteLine("CAllS PRICE: " + myGsm.CallsPrice(0.37) + " $");
            //remove longest call
            myGsm.CallHistory.RemoveAt(myGsm.LongestCall());
           //print agin price 
            Console.WriteLine("NEW CAllS PRICE: " + myGsm.CallsPrice(0.37) + " $");
            //clear call hostory
            myGsm.ClearCallHistory();
            myGsm.ShowCallHistory();
        }
      }
}












