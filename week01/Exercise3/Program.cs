using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string playAgain = "yes";

        // Allow the user to play multiple games
        while (playAgain.ToLower() == "yes")
        {
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1;
            int attempts = 0;

            Console.WriteLine("Welcome to Guess My Number!");

            // Keep asking until the number is guessed
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine() ?? "0");

                attempts++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // Stretch: Display the number of attempts
            Console.WriteLine($"You made {attempts} guesses.");

            // Stretch: Play another game
            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine() ?? "no";

            Console.WriteLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}