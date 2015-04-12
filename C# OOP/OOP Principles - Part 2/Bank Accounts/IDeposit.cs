
namespace Bank_Accounts
{
    interface IBank
    {
        Account MakeDeposit(decimal amount);
        decimal CalculateInterest(decimal numberOfMonths);
    }
}
