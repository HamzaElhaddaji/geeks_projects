using System;
using System.Collections.Generic;

namespace Day4
{
    class ATM
    {
        
        public Account Authenticate(Dictionary<string, Account> accounts)
        {
            Console.WriteLine("Please enter your account number:");
            string enteredNumber = Console.ReadLine();

            if (!accounts.ContainsKey(enteredNumber))
            {
                Console.WriteLine("Account not found.");
                return null;
            }

            Console.WriteLine("Enter your PIN:");
            if (!int.TryParse(Console.ReadLine(), out int enteredPIN))
            {
                Console.WriteLine("Invalid PIN format.");
                return null;
            }

            Account acc = accounts[enteredNumber];

            if (acc.ValidatePIN(enteredPIN))
            {
                Console.WriteLine("Authentication successful!");
                return acc;
            }
            else
            {
                Console.WriteLine("Authentication failed. Incorrect PIN.");
                return null;
            }
        }

        // Show ATM menu and get choice
        public int ShowMenu()
        {
            Console.WriteLine("\nATM Menu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. View Transactions");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option (1-5): ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
                return 0; // invalid choice

            return choice;
        }

        // Perform action based on user choice
        public void PerformAction(int choice, Account account)
        {
            switch (choice)
            {
                case 1:
                    account.CheckBalance();
                    break;
                case 2:
                    Console.Write("Enter deposit amount: ");
                    if (double.TryParse(Console.ReadLine(), out double depositAmount))
                        account.Deposit(depositAmount);
                    else
                        Console.WriteLine("Invalid amount.");
                    break;
                case 3:
                    Console.Write("Enter withdrawal amount: ");
                    if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                        account.Withdraw(withdrawAmount);
                    else
                        Console.WriteLine("Invalid amount.");
                    break;
                case 4:
                    account.ViewTransactions();
                    break;
                case 5:
                    Console.WriteLine("Thank you for using our ATM!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1-5.");
                    break;
            }
        }
    }
}
