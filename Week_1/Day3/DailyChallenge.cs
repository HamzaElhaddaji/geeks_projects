using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        Dictionary<char, List<int>> letterPositions = new Dictionary<char, List<int>>();

        
        for (int i = 0; i < word.Length; i++)
        {
            char currentChar = word[i];

            if (!letterPositions.ContainsKey(currentChar))
            {
                letterPositions[currentChar] = new List<int>();
            }

            letterPositions[currentChar].Add(i);
        }

        Console.WriteLine("\nLetter positions:");
        Console.WriteLine("{");

        foreach (var pair in letterPositions)
        {
            Console.Write($"  '{pair.Key}': [");

            Console.Write(string.Join(", ", pair.Value));

            Console.WriteLine("]");
        }

        Console.WriteLine("}");
    }
}
