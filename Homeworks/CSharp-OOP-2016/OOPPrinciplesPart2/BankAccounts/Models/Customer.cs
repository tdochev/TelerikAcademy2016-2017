namespace BankAccounts.Models
{
    public abstract class Customer
    {
        public Customer(string name)
        {
            this.Name = name;
        }
        public string ID { get; protected set; }

        public string Name { get; private set; }

        public override string ToString()
        {
            return string.Format("Account Holder: {0}, ID: {1}", this.Name, this.ID);
        }
    }
}
