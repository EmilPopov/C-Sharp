
namespace Bank_Accounts
{
    class MortgageAccount : Account
    {
        public MortgageAccount(Costomer costomer,decimal balance, decimal interestRate) : base(balance, interestRate, costomer) { }
        public override Account MakeDeposit(decimal amount)
        {
            this.Balance += amount;
            return this;
        }
        public override decimal CalculateInterest(decimal numberOfMonths)
        {
            if ((numberOfMonths <= 12) && (this.Customer is CompanyCustomer))
            {
            return base.CalculateInterest(numberOfMonths) / 2;
            }
            else if ((numberOfMonths <= 6) && (this.Customer is IndividualCustomer))
            {
                return 0;
            }
            else
            {
                return base.CalculateInterest(numberOfMonths);
            }
        }
        public override string ToString()
        {
            return base.ToString("Mortgage Account");
        }
    }
}
