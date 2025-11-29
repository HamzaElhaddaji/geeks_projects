using System;

namespace ExpenseTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            ExpenseManager manager = new ExpenseManager();
            int choice = 0;

            while (choice != 6)
            {
                Console.WriteLine("\n--- Personal Expense Tracker ---");
                Console.WriteLine("1. Add Transaction");
                Console.WriteLine("2. View Transactions");
                Console.WriteLine("3. Update Transaction");
                Console.WriteLine("4. Delete Transaction");
                Console.WriteLine("5. View Summary");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Amount (negative for expense): ");
                        decimal amount = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Category: ");
                        string category = Console.ReadLine();
                        Console.Write("Date (yyyy-mm-dd): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        manager.AddTransaction(new Transaction(title, amount, category, date));
                        break;

                    case 2:
                        manager.ViewTransactions();
                        break;

                    case 3:
                        manager.ViewTransactions();
                        Console.Write("Enter Transaction ID to update: ");
                        int updateId = Convert.ToInt32(Console.ReadLine());
                        manager.UpdateTransaction(updateId);
                        break;

                    case 4:
                        manager.ViewTransactions();
                        Console.Write("Enter Transaction ID to delete: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());
                        manager.DeleteTransaction(deleteId);
                        break;

                    case 5:
                        manager.ViewSummary();
                        break;

                    case 6:
                        Console.WriteLine("Exiting... Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option, try again.");
                        break;
                }
            }
        }
    }
}

