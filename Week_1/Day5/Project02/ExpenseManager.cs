using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpenseTracker
{
    public class ExpenseManager
    {
        private List<Transaction> transactions = new List<Transaction>();

        public void AddTransaction(Transaction t)
        {
            transactions.Add(t);
            Console.WriteLine("Transaction added successfully!");
        }

        public void ViewTransactions()
        {
            if (!transactions.Any())
            {
                Console.WriteLine("No transactions found.");
                return;
            }

            Console.WriteLine("\n--- Transactions ---");
            foreach (var t in transactions)
                Console.WriteLine(t);
        }

        public void UpdateTransaction(int id)
        {
            var transaction = transactions.FirstOrDefault(t => t.ID == id);
            if (transaction == null)
            {
                Console.WriteLine("Transaction not found.");
                return;
            }

            Console.Write("New Title: ");
            transaction.Title = Console.ReadLine();
            Console.Write("New Amount: ");
            transaction.Amount = Convert.ToDecimal(Console.ReadLine());
            Console.Write("New Category: ");
            transaction.Category = Console.ReadLine();
            Console.Write("New Date (yyyy-mm-dd): ");
            transaction.Date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Transaction updated successfully!");
        }

        public void DeleteTransaction(int id)
        {
            var transaction = transactions.FirstOrDefault(t => t.ID == id);
            if (transaction == null)
            {
                Console.WriteLine("Transaction not found.");
                return;
            }

            Console.WriteLine($"Are you sure you want to delete '{transaction.Title}'? (y/n)");
            if (Console.ReadLine().ToLower() == "y")
            {
                transactions.Remove(transaction);
                Console.WriteLine("Transaction deleted.");
            }
            else
            {
                Console.WriteLine("Deletion cancelled.");
            }
        }

        public void ViewSummary()
        {
            decimal totalIncome = transactions.Where(t => t.Amount > 0).Sum(t => t.Amount);
            decimal totalExpense = transactions.Where(t => t.Amount < 0).Sum(t => t.Amount);
            decimal balance = totalIncome + totalExpense;

            Console.WriteLine($"\nTotal Income: {totalIncome:C}");
            Console.WriteLine($"Total Expenses: {totalExpense:C}");
            Console.WriteLine($"Balance: {balance:C}");

            var categoryTotals = transactions
                .GroupBy(t => t.Category)
                .Select(g => new { Category = g.Key, Total = g.Sum(t => t.Amount) });

            Console.WriteLine("\n--- Total by Category ---");
            foreach (var c in categoryTotals)
            {
                Console.WriteLine($"{c.Category}: {c.Total:C}");
            }
        }

    }
}
