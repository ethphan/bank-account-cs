using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Ethan", 11000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");


            account.MakeWithdrawal(1120, DateTime.Now, "buy hanmock");
            Console.WriteLine(account.Balance);

            //// Test that the initial balances must be positive.
            //try
            //{
            //    var invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //}

            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
