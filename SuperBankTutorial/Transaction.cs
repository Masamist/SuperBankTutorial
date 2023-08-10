using System;

namespace SuperBankTutorial
{
    public partial class Program
    {
        public class Transaction
        {

            public decimal Amount { get; }
            public DateTime Date { get; }
            public string Notes { get; }

            public Transaction(decimal amount, DateTime date, string note)
            {
                this.Amount = amount;
                this.Date = date;
                this.Notes = note;
            }
        }
    }
}
