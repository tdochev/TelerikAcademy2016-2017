namespace BankAccounts.Models
{
    using BankAccounts.Interfaces;

    public  class DepositAccount : Account, IWithdraw, IDeposit
    {
        public DepositAccount(Customer customer, decimal interestRate)
            : base(customer, interestRate)
        {
        }

        public string Withdraw(decimal amount)
        {
            if (this.Balance >= amount && amount > 0)
            {
                this.Balance -= amount;
                return Account.OK + $"Withdraw of {amount}. Current Balance: {this.Balance}";
            }
            else if (this.Balance < amount)
            {
                return Account.NoFunds;
            }
            else
            {
                return Account.Invalid;
            }
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance < 1000)
            {
                return 0m;
            }
            else
            {
                return base.CalculateInterest(months);
            }
        }
    }
}