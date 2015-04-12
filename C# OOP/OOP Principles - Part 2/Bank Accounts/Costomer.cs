
namespace Bank_Accounts
{
    using System;
    public class Costomer
    {
        private string name;
        public Costomer(string name) 
        {
            this.Name = name;
        }
        public string Name { get; private set; }
        public override string ToString()
        {
            return String.Format("Type: {0}; Name: {1}", this.GetType(), this.Name);
        }
    }
}
