
namespace Bank_Accounts
{
    public class DepositAccount : Account
    {
        public DepositAccount(Costomer costomer,decimal balance, decimal interestRate ) : base(balance, interestRate, costomer) { }
        public override Account MakeDeposit(decimal amount)
        {
            this.Balance += amount;
            return this;
        }
        public override Account Withdraw(decimal amount)
        {
            base.Withdraw(amount);
            return this;
        }
        public override decimal CalculateInterest(decimal numberOfMonths)
        {
            if ((this.Balance > 0) && (this.Balance < 1000))
            {
                System.Console.WriteLine("Deposit accounts have no interest if their balance is positive and less than 1000");
                return 0;
            }
            else
            {
                return base.CalculateInterest(numberOfMonths);
            }
        }
        public override string ToString()
        {
            return base.ToString("Deposit Account");
        }
    }
}
