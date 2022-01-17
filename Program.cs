using System;

namespace Guess_number
{
    class Program
    {
        static void Main(string[] args)
        {

            string welcome = ("Welcome to Guess The Number!");
            Console.SetCursorPosition((Console.WindowWidth - welcome.Length) / 2, Console.CursorTop);
            Console.WriteLine(welcome);
            string creator = ("Made by ISPlayz");
            Console.SetCursorPosition((Console.WindowWidth - creator.Length) / 2, Console.CursorTop);
            Console.WriteLine(creator);

            Random random = new Random();
            int number = random.Next(1, 100);
            int tries = 0;
            int userguess = 0;
            Console.Write("\nPick a number between 1 and 100: ");

            while (userguess != number)
            {
                try
                {
                    userguess = Convert.ToInt32(Console.ReadLine());
                    
                    if (userguess > number)
                {
                    Console.WriteLine($"The number is lower than {userguess}");
                    Console.Write("\nPick another number between 1 and 100: ");
                }
                else 
                {
                    Console.WriteLine($"The number is higher than {userguess}");
                    Console.Write("\nPick another number between 1 and 100: ");
                }
            }
          catch
            {
                Console.WriteLine("\nPlease type a number between 1 and 100: ");
                tries--;
            }

            tries++;
        }
            Console.Clear();
            Console.WriteLine($"\nWell done! The number was {number} and it took you {tries} tries!");
        }
    }
}
