using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaring variables
        Random randomGenerator = new Random();
        int number;
        int guess;
        int counter;
        string playAgain;

        // playAgain loop
        do
        {
            number = randomGenerator.Next(1, 11);
            counter = 0;
            // Game loop
            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if(guess < number)
                {
                    Console.WriteLine("Higher");
                }
                counter ++;
            } while (guess != number);
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {counter} guesses");
            Console.WriteLine("Would you like to play again? ");
            playAgain = Console.ReadLine();
        } while (playAgain.Equals("yes", StringComparison.CurrentCultureIgnoreCase));
    }
}