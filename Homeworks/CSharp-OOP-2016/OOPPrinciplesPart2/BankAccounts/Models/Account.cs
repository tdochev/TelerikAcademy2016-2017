namespace BankAccounts.Models
{
    using BankAccounts.Interfaces;

    public abstract class Account : IDeposit
    {
        public const string NoFunds = "Insufficient funds to make withdrawal!";
        public const string OK = "Transaction successful!";
        public const string Invalid = "Invalid transaction!";

        public Account(Customer customer, decimal interestRate)
        {
            this.Customer = customer;
            this.InterestRate = interestRate;
        }

        public decimal Balance { get;  protected set; }

        public decimal InterestRate { get; set; }

        public Customer Customer { get; set; }

        public virtual string Deposit(decimal amount)
        {
            if (amount > 0)
            {
                this.Balance += amount;
                return OK + $" Deposit of {amount}. Current balance: {this.Balance}";
            }
            return Invalid;
        }

        public virtual decimal CalculateInterest(int months)
        {
            return months * this.InterestRate;
        }

        public override string ToString()
        {
            return $"{this.Customer}, Current balance: {this.Balance}, Interest Rate: {this.InterestRate}";
        }
    }
}