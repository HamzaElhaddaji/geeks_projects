using System;
using System.Collections.Generic;

namespace Day4
{
    class Account
    {
        public string AccountNumber { get; private set; }
        private int PIN;
        public double Balance { get; private set; }
        private List<string> Transactions;

        public Account(string accountNumber, int pin)
        {
            AccountNumber = accountNumber;
            PIN = pin;
            Balance = 0.0;
            Transactions = new List<string>();
        }

        // Check if the entered PIN is correct
        public bool ValidatePIN(int pin)
        {
            return PIN == pin;
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Your current balance is: ${Balance}");
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }

            Balance += amount;
            Transactions.Add($"Deposited: ${amount}");
            Console.WriteLine($"Deposit successful! New balance: ${Balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds.");
                return;
            }

            Balance -= amount;
            Transactions.Add($"Withdrew: ${amount}");
            Console.WriteLine($"Withdrawal successful! New balance: ${Balance}");
        }

        public void ViewTransactions()
        {
            Console.WriteLine("Transaction History:");
            if (Transactions.Count == 0)
            {
                Console.WriteLine("No transactions yet.");
            }
            else
            {
                foreach (var t in Transactions)
                {
                    Console.WriteLine(t);
                }
            }
        }
    }
}
