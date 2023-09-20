using System;

class Program
{
    // Thought it looked boring so I added colors.
    static void Main(string[] args)
    {
        Random random = new Random();
        while (true)
        {
            // Sets up round
            int guesses = 0;
            int RandomNumber = random.Next(1, 100);
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("What is your guess?");
                // Ensures that the input is a number and parses into the guess variable
                Console.ForegroundColor = ConsoleColor.Blue;
                if (int.TryParse(Console.ReadLine(), out int guess))
                {
                    guesses++;
                    if (guess > RandomNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Lower");
                    }
                    else if (guess < RandomNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Higher");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You guessed it!");
                        break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please input a number from 1 to 100");
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"It only took you {guesses} guesses!");
            // Prompts user to play again
            Console.WriteLine("Do you want to play again?");
            Console.ForegroundColor = ConsoleColor.Blue;
            if (Console.ReadLine() != "yes")
            {
                return;
            }
        }
    }
}