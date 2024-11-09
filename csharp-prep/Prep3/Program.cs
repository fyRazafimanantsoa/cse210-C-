using System;

class Program
{

    static void Main(string[] args)
    {
        // Start the game loop
        bool playAgain = true;

        while (playAgain)
        {
            // Generate a random number from 1 to 100
            Random random = new Random();
            int number = random.Next(1, 101);
            int guessCount = 0;
            int guess = 0;

            Console.WriteLine("Welcome to the Guess My Number game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100. Try to guess it!");

            // Loop until the user guesses the number
            while (guess != number)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

            // Ask the user if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine();
            if (response != "yes")
            {
                playAgain = false;
                Console.WriteLine("Thank you for playing! Goodbye.");
            }
        }
    }
}

