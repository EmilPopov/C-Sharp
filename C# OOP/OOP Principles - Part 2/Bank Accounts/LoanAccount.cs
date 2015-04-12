
namespace Bank_Accounts
{
    using System;
    public class LoanAccount : Account
    {
        public LoanAccount(Costomer costomer,decimal balance, decimal interestRate) : base(balance, interestRate, costomer) { }
        public override Account MakeDeposit(decimal amount)
        {
            this.Balance += amount;
            return this;
        }

        public override decimal CalculateInterest(decimal numberOfMonths)
        {
            if ((this.Customer is IndividualCustomer) && (numberOfMonths <= 3))
            {
                Console.WriteLine("Loan accounts have no interest for the first 3 months if are held by individuals");
                return 0;
            }
            else if ((this.Customer is CompanyCustomer) && (numberOfMonths <= 2))
            {
                Console.WriteLine("Loan accounts have no interest for the first 2 months if are held by company");
                return 0;
            }
            else
            {
                return base.CalculateInterest(numberOfMonths);
            }
        }
        public override string ToString()
        {
            return base.ToString("Loan Account");
        }
    }
}
