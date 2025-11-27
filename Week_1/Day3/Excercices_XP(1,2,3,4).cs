using System;
using System.Collections.Generic;

class Exercise1
{
    static void Main()
    {
        List<string> keys = new List<string> { "Ten", "Twenty", "Thirty" };
        List<int> values = new List<int> { 10, 20, 30 };
        Dictionary<string, int> dict = new Dictionary<string, int>();
        for (int i = 0; i < keys.Count; i++)
        {
            dict[keys[i]] = values[i];
        }

        foreach (var kvp in dict)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}

class Exercise2
{
    static void Main()
    {
        Dictionary<string, int> family = new Dictionary<string, int>
        {
            {"rick", 43},
            {"beth", 13},
            {"morty", 5},
            {"summer", 8}
        };

        int totalCost = 0;
        foreach (var member in family)
        {
            int age = member.Value;
            int price = age < 3 ? 0 : (age <= 12 ? 10 : 15);
            Console.WriteLine($"{member.Key} ({age} years old) pays: ${price}");
            totalCost += price;
        }
        Console.WriteLine($"\nTotal family cost: ${totalCost}");
    }
}

class Exercise3
{
    static void Main()
    {
        var brand = new Dictionary<string, object>
        {
            {"name", "Zara"},
            {"creation_date", 1975},
            {"creator_name", "Amancio Ortega Gaona"},
            {"type_of_clothes", new List<string>{"men", "women", "children", "home"}},
            {"international_competitors", new List<string>{"Gap", "H&M", "Benetton"}},
            {"number_stores", 7000},
            {"major_color", new Dictionary<string, List<string>>
                {
                    {"France", new List<string>{"blue"}},
                    {"Spain", new List<string>{"red"}},
                    {"US", new List<string>{"pink", "green"}}
                }
            }
        };

        brand["number_stores"] = 2;
        var clothes = (List<string>)brand["type_of_clothes"];
        Console.WriteLine($"Zara's clients are: {string.Join(", ", clothes)}");
        brand["country_creation"] = "Spain";

        var competitors = (List<string>)brand["international_competitors"];
        competitors.Add("Desigual");

        brand.Remove("creation_date");
        Console.WriteLine($"Last competitor: {competitors[competitors.Count - 1]}");

        var majorColors = (Dictionary<string, List<string>>)brand["major_color"];
        Console.WriteLine("Major colors in the US: " + string.Join(", ", majorColors["US"]));

        Console.WriteLine($"Number of key-value pairs: {brand.Count}");
        Console.WriteLine("All keys:");
        foreach (var key in brand.Keys)
        {
            Console.WriteLine(key);
        }

        var more_on_zara = new Dictionary<string, object>
        {
            {"creation_date", 1975},
            {"number_stores", 10000}
        };

        foreach (var item in more_on_zara)
            brand[item.Key] = item.Value;

        Console.WriteLine($"\nAfter merging, number_stores = {brand["number_stores"]}");
        Console.WriteLine("Explanation: The new dictionary overwrote the old value.");
    }
}

/*class Exercise4
{
    static void Main()
    {
        DescribeCity("Casablanca", "Morocco");
        DescribeCity("Reykjavik");
    }

    static void DescribeCity(string city, string country = "Iceland")
    {
        Console.WriteLine($"{city} is in {country}.");
    }
}*/