

namespace Bank_Accounts
{
    using System;
    using System.Collections.Generic;
    public abstract class Account : IBank
    {
        private decimal balance;
        private decimal interestRate;
        private Costomer customer;
        public Account(decimal balance,decimal interestRate,Costomer costomer)
        {
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.Customer = customer;
        }

        public decimal Balance { get; set; }
        public decimal InterestRate { get; private set; }
        public Costomer Customer { get; private set; }

        public abstract Account MakeDeposit(decimal amount);
        public virtual Account Withdraw(decimal amount)
        {
            this.Balance -= amount;
            return this;
        }
        public virtual decimal CalculateInterest(decimal numberOfMonths)
        {
            if (numberOfMonths <= 0)
            {
                return 0;
            }
            else
            {
                return this.InterestRate * numberOfMonths;
            }
        }
        public string ToString(string type)
        {
            List<string> info = new List<string>();

            info.Add(String.Empty); 
            info.Add("Type: " + type);
            info.Add("Customer: ");
            //info.Add(this.Customer.ToString());
            info.Add("Balance: " + this.Balance);
            info.Add("Interest rate: " + this.InterestRate);

            return String.Join(Environment.NewLine, info);
        }
    }
}
