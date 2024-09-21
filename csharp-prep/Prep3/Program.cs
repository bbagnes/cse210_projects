using System;

class Program
{
    static void Main(string[] args)
    {
                
        string response = "yes";

        do 
        {
            Random randomGenerator = new Random();
            int magic = randomGenerator.Next(1, 101);

            Console.Write("What is your guess? ");
            string guessNumber = Console.ReadLine();
            int guess = int.Parse(guessNumber);
            int count = 1;

            while (guess != magic)
            {
                if (guess > magic)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magic)
                {
                    Console.WriteLine("Higher");
                }
                
                count ++;
                Console.Write("What is your guess? ");
                guessNumber = Console.ReadLine();
                guess = int.Parse(guessNumber);
                
            }
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {count} guesses.");
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } while (response == "yes");
        Console.WriteLine("");
        Console.WriteLine("Thank you for playing. Have a good day.");
    }
}