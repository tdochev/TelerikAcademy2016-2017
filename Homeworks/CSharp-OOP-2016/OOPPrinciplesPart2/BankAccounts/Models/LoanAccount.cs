namespace BankAccounts.Models
{
    using BankAccounts.Interfaces;

    class LoanAccount : Account, IDeposit
    {
        public LoanAccount(Customer customer, decimal interestRate)
            : base(customer, interestRate)
        {
        }
        public override decimal CalculateInterest(int months)
        {
            if (this.Customer is Company)
            {
                if (months <= 2)
                {
                    return 0m;
                }
                else
                {
                    return base.CalculateInterest(months - 2);
                }
            }
            else
            {
                if (months <= 3)
                {
                    return 0m;
                }
                else
                {
                    return base.CalculateInterest(months - 3);
                }
            }
        }
    }
}
