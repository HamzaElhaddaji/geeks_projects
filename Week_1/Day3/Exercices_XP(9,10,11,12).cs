using System;
using System.Collections.Generic;
using System.Linq;

class Exercise9
{
    static void Main()
    {
        var cats = new List<Cat>
        {
            new Cat("Mimi", 3),
            new Cat("Tiger", 7),
            new Cat("Snow", 5)
        };
        Cat oldest = cats.OrderByDescending(c => c.Age).First();
        Console.WriteLine($"The oldest cat is {oldest.Name}, and is {oldest.Age} years old.");
    }
}

class Cat
{
    public string Name { get; }
    public int Age { get; }
    public Cat(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Exercise10
{
    static void Main()
    {
        var dog1 = new Dog("Rex", 50);
        var dog2 = new Dog("Teacup", 20);

        dog1.Bark(); dog1.Jump();
        dog2.Bark(); dog2.Jump();

        Console.WriteLine(dog1.Height > dog2.Height
            ? $"{dog1.Name} is taller."
            : dog1.Height < dog2.Height
                ? $"{dog2.Name} is taller."
                : "Both dogs have the same height.");
    }
}

class Dog
{
    public string Name { get; }
    public int Height { get; }
    public Dog(string name, int height) { Name = name; Height = height; }
    public void Bark() => Console.WriteLine($"{Name} goes woof!");
    public void Jump() => Console.WriteLine($"{Name} jumps {Height * 2} cm high!");
}

class Exercise11
{
    static void Main()
    {
        var stairway = new Song(new List<string>
        {
            "There’s a lady who's sure",
            "all that glitters is gold",
            "and she’s buying a stairway to heaven"
        });
        stairway.SingMeASong();
    }
}

class Song
{
    private List<string> Lyrics { get; }
    public Song(List<string> lyrics) { Lyrics = lyrics; }
    public void SingMeASong()
    {
        foreach (var line in Lyrics)
            Console.WriteLine(line);
    }
}

class Exercise12
{
    static void Main()
    {
        var zoo = new Zoo("New York Zoo");
        zoo.AddAnimal("Elephant");
        zoo.AddAnimal("Ape");
        zoo.AddAnimal("Bear");
        zoo.GetAnimals();
        zoo.SortAnimals();
        zoo.GetGroups();
    }
}

class Zoo
{
    private string Name { get; }
    private List<string> Animals { get; }
    private Dictionary<char, List<string>> Groups { get; }

    public Zoo(string name)
    {
        Name = name;
        Animals = new List<string>();
        Groups = new Dictionary<char, List<string>>();
    }

    public void AddAnimal(string animal)
    {
        if (!Animals.Contains(animal)) { Animals.Add(animal); Console.WriteLine($"{animal} added to the zoo."); }
        else { Console.WriteLine($"{animal} is already in the zoo."); }
    }

    public void GetAnimals() => Console.WriteLine($"Animals in {Name}: {string.Join(", ", Animals)}");

    public void SortAnimals()
    {
        Groups.Clear();
        foreach (var animal in Animals.OrderBy(a => a))
        {
            char group = char.ToUpper(animal[0]);
            if (!Groups.ContainsKey(group)) Groups[group] = new List<string>();
            Groups[group].Add(animal);
        }
    }

    public void GetGroups()
    {
        foreach (var group in Groups)
            Console.WriteLine($"{group.Key}: {string.Join(", ", group.Value)}");
    }
}
