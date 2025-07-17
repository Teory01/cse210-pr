using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            // Generate a random number between 1 and 100
            Random rand = new Random();
            int magicNum = rand.Next(1, 101); // 101 is exclusive, so this includes 100

            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("I've picked a magic number between 1 and 100!");

            // Guessing loop
            while (guess != magicNum)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNum)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNum)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it correctly!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
            Console.WriteLine(); // blank line for separation
        }

        Console.WriteLine("Thanks for playing!");
    }
}
