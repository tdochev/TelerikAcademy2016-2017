namespace BankAccounts.Models
{
    public class Company : Customer
    {
        public Company(string name, string Eik) : base (name)
        {
            this.ID = Eik;
        }
    }
}
