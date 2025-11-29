using System;

namespace ExpenseTracker
{
    public class Transaction
    {
        public int ID { get; private set; }
        public string Title { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; } 
        public DateTime Date { get; set; }

        private static int nextID = 1;

        public Transaction(string title, decimal amount, string category, DateTime date)
        {
            ID = nextID++;
            Title = title;
            Amount = amount;
            Category = category;
            Date = date;
        }

        public override string ToString()
        {
            return $"ID: {ID} | {Date.ToShortDateString()} | {Title} | {Category} | Amount: {Amount:C}";
        }
    }
}
