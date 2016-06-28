namespace BankAccounts
{
    using System;

    using BankAccounts.Interfaces;
    using BankAccounts.Models;

    public class Start
    {
        public static void Main()
        {
            var testAcount = new DepositAccount(new Company("Abc", "040304123"), 3.47m);
            Console.WriteLine(testAcount);
            Console.WriteLine(testAcount.Deposit(1200m));
            Console.WriteLine(testAcount.Withdraw(101m));
            Console.WriteLine("Interest: " + testAcount.CalculateInterest(10));
            Console.WriteLine(testAcount);
            Console.WriteLine(new string('-', 60));
            var anotherTestAccount = new MortgageAccount(new Company("Apple", "040304123"), 5);
            Console.WriteLine(anotherTestAccount);
            Console.WriteLine(anotherTestAccount.Deposit(120m));
            Console.WriteLine("Interest:" + anotherTestAccount.CalculateInterest(13));
            Console.WriteLine(anotherTestAccount);
            Console.WriteLine(new string('-', 60));
            var yetAnotherTestAccount = new LoanAccount(new Individual("Gosho","8010271234"),4.2m);
            Console.WriteLine(yetAnotherTestAccount);
            Console.WriteLine(yetAnotherTestAccount.Deposit(180m));
            Console.WriteLine("Interest: " + yetAnotherTestAccount.CalculateInterest(3));
            Console.WriteLine(yetAnotherTestAccount);
            Console.WriteLine(new string('-', 60));
        }
    }
}
