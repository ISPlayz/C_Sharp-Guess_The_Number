using System;

namespace Guess_number
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Guess The Number!");
            Console.WriteLine("Made by ISPlayz");

            bool invalid = true;

            while (invalid)
            {
                Console.Write("Type yes to start the game and no to exit: ");
                string start = Console.ReadLine();
                if (start == "yes")
                {
                    Console.WriteLine("Let's start then!");
                    invalid = false;
                }
                else if (start == "no")
                {
                    Environment.Exit(0);
                    invalid = false;
                }
                else
                {
                    Console.WriteLine("Please type only yes or no");
                    invalid = true;
                }
            }
            Random random = new Random();
            int number = random.Next(1, 100);
            int tries = 0;
            int userguess = 0;
            Console.Write("Pick a number between 1 and 100: ");

            while (userguess != number)
            {
                try
                {
                    userguess = Convert.ToInt32(Console.ReadLine());
                    
                    if (userguess > number)
                {
                    Console.WriteLine("The number is lower");
                }
                else
                {
                    Console.WriteLine("The number is higher");
                }
            }
          catch
            {
                Console.WriteLine("Please type a number between 1 and 100: ");
                tries--;
            }

            tries++;
        }
            Console.WriteLine($"Well done! The number was {number} and it took you {tries} tries!");
        }
    }
}
