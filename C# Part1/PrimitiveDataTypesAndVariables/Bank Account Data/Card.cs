using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Data
{
    class Card
    {
        public int Number { get; set; }
        private string type;

        public string Type
        {
            get { return this.type; }
            set
            {
                if (value == "debit"||value=="credit")
                {
                    this.type = value;
                }
                else
                {
                    Console.WriteLine("Invalid card type");
                }
            }
        }
        public Card(string type, int number)
        {
            this.Type = type;
            this.Number = number;
        }
        
    }
}
