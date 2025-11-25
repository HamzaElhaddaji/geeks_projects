using system;
using System.Collections.Generic;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //challenge 1
         int number,length;
            Console.WriteLine("Enter the length of the list:");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the numbers:");
            number=Convert.ToInt32(Console.ReadLine());
        List<int>numbers=new List<int>(length);
        for(int i = 1; i <= length; i++)
            {
                numbers.Add(number*i);
            }
        
        Console.WriteLine("The generated list is:");
        foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }

            //challenge 2
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            string result = "";
            result += input[0];//because we gonna always take the first character
           for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    result += input[i];
                }
            }
            Console.WriteLine("Resulting string: " + result);
        }

    }
}