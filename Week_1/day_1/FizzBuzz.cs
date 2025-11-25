using system;
namespace FizzBuzz
{
    class FizzBuzzProgram
    {
        static void Main(string[] args)
        {
            //FizzBuzz exercise
            Console.WriteLine("enter a number between 1 and 100:");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number+" is neither Fizz nor Buzz");
            }
            //Build a Triangle Pattern exercise
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //Reverse a Word exercise
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();

            Console.Write("Reversed word: ");

            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }


        }
    }
}