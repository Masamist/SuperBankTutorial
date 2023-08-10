using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBankTutorial
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Masmai", 50000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");

            account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");

            Console.WriteLine(account.GetAccountHistory());



            //// Test that the initial balance must be positive

            //try
            //{
            //    var invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch(ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught create account with negative balance");
            //    Console.WriteLine(e.ToString());
            //}
            //account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");
            //Console.WriteLine(account.Balance);


            Console.ReadLine();

        }
    }
}
