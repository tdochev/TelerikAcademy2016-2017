namespace BankAccounts.Models
{
    using BankAccounts.Interfaces;

    class MortgageAccount : Account, IDeposit
    {
        public MortgageAccount(Customer customer, decimal interestRate)
            : base(customer, interestRate)
        {
        }
        public override decimal CalculateInterest(int months)
        {
            if (this.Customer is Company)
            {
                if (months <= 12)
                {
                    return base.CalculateInterest(months) / 2;
                }
                else
                {
                    return base.CalculateInterest(12) / 2 + base.CalculateInterest(months - 12);
                }
            }
            else
            {
                if (months <= 6)
                {
                    return 0m;
                }
                else
                {
                    return base.CalculateInterest(months - 6);
                }
            }
        }
    }
}