using System;

namespace Greeting
{
    class HelloWorld
    {
        static void Main()
        {
            //exercice 1
            Console.WriteLine("Welcome to C# Programming!");

            //exercice 2
            string Name = "Hamza";
            int Age = 20;
            Console.WriteLine("My name is " + Name + " and my age is " + Age);

            //exercice 3 
            int num1 = 5, num2 = 6, sum;
            sum = num1 + num2;
            Console.WriteLine("the sum = " + sum);

            //excercice 4
            int userAge = 15;
            if (userAge > 18)
            {
                Console.WriteLine("Access Granted");
            }
            else
            {
                Console.WriteLine("Access Denied");
            }

            //excercice 5
            int i = 10;

            while (i >= 1)
            {
                Console.WriteLine(i);
                i--;
            }

            //excercice declaration         
            SayHello("Hamza");
            SayHello("ismail");
            SayHello("Zouhair");

            //excercice 7
            for (int j2 = 1; j2 <= 10; j2++)
            {
                if (j2 % 2 == 0)
                {
                    Console.WriteLine(j2 + " is even");
                }
                else
                {
                    Console.WriteLine(j2 + " is odd");
                }
            }

            //excercice 8
            Console.WriteLine("enter the temperature");
            int C = Convert.ToInt32(Console.ReadLine());
            float F = C * (9f / 5f) + 32;
            Console.WriteLine(F);

            //excercice 9
            int a = 4;
            int b = 3;
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a = " + a + "  b = " + b);

            //excercice 10 
            Console.WriteLine("enter a value");
            int j = Convert.ToInt32(Console.ReadLine());

            for (int k = 1; k <= 10; k++)
            {
                Console.WriteLine(j + " x " + k + " = " + (j * k));
            }
        }

        // excercice 6
        public static void SayHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
