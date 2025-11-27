using System;

class Exercise4
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
}
class Exercise5
{
    static void Main()
    {
        RandomNumberGuess(50);
    }

    static void RandomNumberGuess(int userGuess)
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(1, 101);
        Console.WriteLine(userGuess == randomNumber
            ? "You guessed right!"
            : $"Wrong guess! Your guess: {userGuess}. Correct number: {randomNumber}");
    }
}

class Exercise6
{
    static void Main()
    {
        MakeShirt();
        MakeShirt("Medium");
        MakeShirt("Small", "I'm a game developer");
        MakeShirt(size: "Extra Large", text: "I'm a developer");
        MakeShirt(text: "Coding is fun!");
        MakeShirt(size: "Medium");
    }

    static void MakeShirt(string size = "Large", string text = "I love C#")
    {
        Console.WriteLine($"The size of the shirt is {size} and the text is '{text}'.");
    }
}
class Exercise7
{
    static void Main()
    {
        Console.Write("Enter a season (winter, spring, summer, autumn): ");
        string season = Console.ReadLine().ToLower();
        int temperature = GetRandomTemp(season);
        Console.WriteLine($"The temperature in {season} is {temperature}°C.");

        if (temperature < 0) Console.WriteLine("It's freezing! Wear extra layers today.");
        else if (temperature < 16) Console.WriteLine("Quite chilly! Don't forget your coat.");
        else if (temperature < 23) Console.WriteLine("Nice weather! A light jacket should be fine.");
        else Console.WriteLine("It's warm outside! Perfect for shorts and a t-shirt.");
    }

    static int GetRandomTemp(string season)
    {
        Random rnd = new Random();
        return season switch
        {
            "winter" => rnd.Next(-10, 17),
            "spring" => rnd.Next(0, 24),
            "summer" => rnd.Next(16, 41),
            "autumn" => rnd.Next(0, 24),
            _ => 0
        };
    }
}
class Exercise8
{
    static void Main()
    {
        var data = new List<Dictionary<string, string>>
        {
            new Dictionary<string, string> { {"question", "What is Baby Yoda's real name?"}, {"answer", "Grogu"} },
            new Dictionary<string, string> { {"question", "Where did Obi-Wan take Luke after his birth?"}, {"answer", "Tatooine"} },
            new Dictionary<string, string> { {"question", "What year did the first Star Wars movie come out?"}, {"answer", "1977"} },
            new Dictionary<string, string> { {"question", "Who built C-3PO?"}, {"answer", "Anakin Skywalker"} },
            new Dictionary<string, string> { {"question", "Anakin Skywalker grew up to be who?"}, {"answer", "Darth Vader"} },
            new Dictionary<string, string> { {"question", "What species is Chewbacca?"}, {"answer", "Wookiee"} }
        };

        PlayQuiz(data);
    }

    static void PlayQuiz(List<Dictionary<string, string>> data)
    {
        int correct = 0;
        foreach (var item in data)
        {
            Console.WriteLine(item["question"]);
            Console.Write("Your answer: ");
            string userAnswer = Console.ReadLine();
            if (userAnswer.Trim().ToLower() == item["answer"].ToLower())
            {
                Console.WriteLine("✅ Correct!");
                correct++;
            }
            else
            {
                Console.WriteLine($"Wrong! Correct answer: {item["answer"]}");
            }
        }
        Console.WriteLine($"Correct answers: {correct}");
    }
}