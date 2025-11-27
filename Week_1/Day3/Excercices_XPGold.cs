using System;
using System.Collections.Generic;
using System.Linq;

namespace Excercices_XPGold
{
    class Excercices_XPGold
    {
        static void Main(string[] args)
        {
         // Exercise 1: Birthday Look-up
            BirthdayLookup();

            // Exercise 2: Birthdays Advanced
            BirthdayLookupAdvanced();

            // Exercise 3: Sum Sequence
            Console.Write("Enter a number for the Sum Sequence: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"The result of the sequence is: {SumSequence(x)}");

           // Exercise 4: Double Dice
            MainSimulation();
        }

       // Exercise 1: Birthday Look-up
        static void BirthdayLookup()
        {
            Dictionary<string, string> birthdays = new Dictionary<string, string>
            {
                { "Alice", "1990/05/12" },
                { "Bob", "1985/11/23" },
                { "Charlie", "2000/07/15" },
                { "Diana", "1995/03/30" },
                { "Eve", "1988/09/10" }
            };

            Console.WriteLine("Welcome! You can look up birthdays.");
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();

            if (birthdays.ContainsKey(name))
            {
                Console.WriteLine($"{name}'s birthday is {birthdays[name]}.");
            }
            else
            {
                Console.WriteLine($"Sorry, we don’t have the birthday information for {name}.");
            }
        }

        // Exercise 2: Birthdays Advanced
        static void BirthdayLookupAdvanced()
        {
            Dictionary<string, string> birthdays = new Dictionary<string, string>
            {
                { "Alice", "1990/05/12" },
                { "Bob", "1985/11/23" },
                { "Charlie", "2000/07/15" },
                { "Diana", "1995/03/30" },
                { "Eve", "1988/09/10" }
            };

            Console.WriteLine("Here are the names you can look up:");
            foreach (var name in birthdays.Keys)
            {
                Console.WriteLine(name);
            }

            Console.Write("Enter a name: ");
            string nameInput = Console.ReadLine();

            if (birthdays.ContainsKey(nameInput))
            {
                Console.WriteLine($"{nameInput}'s birthday is {birthdays[nameInput]}.");
            }
            else
            {
                Console.WriteLine($"Sorry, we don’t have the birthday information for {nameInput}.");
            }
        }
            
        // Exercise 3: Sum Sequence
        static int SumSequence(int x)
        {
            string xStr = x.ToString();
            int result = 0;

            for (int i = 1; i <= 4; i++)
            {
                string repeated = string.Concat(Enumerable.Repeat(xStr, i));
                result += int.Parse(repeated);
            }

            return result;
        }

        // Exercise 4: Double Dice
        static Random random = new Random();

        static int ThrowDice()
        {
            return random.Next(1, 7); 
        }

        static int ThrowUntilDoubles()
        {
            int rolls = 0;
            int die1, die2;

            do
            {
                die1 = ThrowDice();
                die2 = ThrowDice();
                rolls++;
            } while (die1 != die2);

            return rolls;
        }

        static void MainSimulation()
        {
            List<int> results = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                results.Add(ThrowUntilDoubles());
            }

            int totalRolls = results.Sum();
            double averageRolls = results.Average();

            Console.WriteLine($"Total number of rolls: {totalRolls}");
            Console.WriteLine($"Average number of rolls to reach doubles: {Math.Round(averageRolls, 2)}");
        }
    }
}