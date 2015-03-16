namespace GSM_TestArea

{
    using System;
    using System.Collections.Generic;
    public class GSM
    {
        //fields holding information about a mobile phone device
        private const double baseNum=0;
        private const string  baseStr= null;
       
        private string manifacture;
        private string model;
        private double price;
        private string owner;
        private Battery battery = new Battery(baseStr, baseNum, baseNum,BatteryType.Null);
        private Display display = new Display(baseNum,baseNum);
        public static GSM iPhone4S = new GSM("iPhone4S","Apple");
        private List<Call> callHistory=new List<Call>();     
        //Constructors for the defined classes that take different sets of arguments
         public GSM(string model, string manifacture, double price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manifacture = manifacture;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }
         public GSM(string model, string manifacture, Battery battery, Display display):this(model,manifacture,baseNum,baseStr,battery,display)
         {

         }
         public GSM(string model, string manifacture):this(model,manifacture,baseNum,baseStr,null,null)
        {
           
        }
         public GSM(string model, string manifacture,double price)
             : this(model, manifacture, price, baseStr, null, null)
         {

         }

        // properties to encapsulate the data fields inside the GSM, Battery and Display classes
         public static GSM IPhone4S
         {
             get { return iPhone4S; }
         }
        
        public string Model
        {
            get { return model; }
            set { this.model = value; }
        }

        public string Manifacture
        {
            get { return manifacture; }
            set { this.manifacture = value; }
        }

        public double Price
        {
            get { return price; }
            set { this.price = value; }
        }
        
        public string Owner
        {
            get { return owner; }
            set { this.owner = value; }
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { callHistory = value; }
        }
        

        internal Battery Battery { get; set; }

        internal Display Display { get; set; }
        //Methods
        public override string ToString()
        {

            if (Display != null && Battery != null )
            {
                string batteryStr = string.Format("Battery - Model : {0} Type : {1} HoursIdle : {2} HoursTalk {3}",
                   Battery.Model,Battery.Type, Battery.HoursIdle, Battery.HoursTalk);
                string displayStr = string.Format("Dispaly - Size : {0}  Numbers Of Colors : {1}", Display.Size, Display.NumberOfColors);
                return string.Format("Gsm - Model : {0}  Manifacture : {1} Price : {2} \n{3}\n{4}",
                     this.Model, this.Manifacture, this.Price, batteryStr, displayStr);
            }
            else
            {
                return string.Format("Gsm - Model : {0}  Manifacture : {1} Price : {2}", this.Model, this.Manifacture, this.Price);
            }
        }
        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }
        public void DeleteCall(Call call)
        {
            for (int i = 0; i < CallHistory.Count; i++)
            {
                if (call.CallDateTime == CallHistory[i].CallDateTime)
                {
                    CallHistory.RemoveAt(i);
                    i--;
                }
            }
        }
        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }
        //Calculate price of all callls
        public  double CallsPrice(double minutePrice)
        {
            double sum = 0;
            for (int i = 0; i < this.CallHistory.Count; i++)
            {
                sum += this.CallHistory[i].CallDuration;
            }
            return (sum/60) * minutePrice;
        }
        //Print call history
        public  void ShowCallHistory()
        {
            for (int i = 0; i < this.CallHistory.Count; i++)
            {
                Console.WriteLine("CALL Date: {0}  Time: {1}  Number: {2}  Duration: {3}",
                    this.CallHistory[i].CallDateTime.ToString("yyyy/MM/dd"),
                    this.CallHistory[i].CallDateTime.ToString("HH:mm:dd"),
                    this.CallHistory[i].DialedNumber,
                    this.CallHistory[i].CallDuration);
            }
        }
        // return index of longest call
        public int LongestCall()
        {
            double longestDuration = 0;
            int index = 0;
            for (int i = 0; i < this.CallHistory.Count; i++)
            {
                if (longestDuration < this.CallHistory[i].CallDuration)
                {
                    index = i;
                }

            }
            return index;
        }
    }
}
