namespace BankAccounts.Interfaces
{
    public interface IWithdraw : IDeposit
    {
        string Withdraw(decimal amount);
    }
}