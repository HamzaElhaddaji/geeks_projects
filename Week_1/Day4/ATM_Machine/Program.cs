using System;
using System.Collections.Generic;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Account user1 = new Account("123456", 1516);
            Account user2 = new Account("678910", 1234);
            Account user3 = new Account("111222", 4321);

            
            Dictionary<string, Account> accounts = new Dictionary<string, Account>
            {
                { user1.AccountNumber, user1 },
                { user2.AccountNumber, user2 },
                { user3.AccountNumber, user3 }
            };

            ATM atm = new ATM();
            Account loggedInAccount = atm.Authenticate(accounts);

            if (loggedInAccount == null)
            {
                Console.WriteLine("Exiting program.");
                return;
            }

            int choice = 0;
            while (choice != 5)
            {
                choice = atm.ShowMenu();
                atm.PerformAction(choice, loggedInAccount);
            }

            Console.WriteLine("\nSession ended. Transaction summary:");
            loggedInAccount.ViewTransactions();
        }
    }
}
