namespace BankAccounts.Models
{
    public class Individual : Customer
    {
        public Individual(string name, string Egn)
            : base(name)
        {
            this.ID = Egn;
        }
    }
}
