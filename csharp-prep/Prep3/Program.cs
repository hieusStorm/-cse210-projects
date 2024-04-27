using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumberGenerator = new Random();
        int magicNumber = randomNumberGenerator.Next(1, 100);
        string question = "What is your guess for the magic number? ";

        Console.Write(question);
        string userGuess = Console.ReadLine();
        int numberGuess = int.Parse(userGuess);

        while (numberGuess != magicNumber)
        {
            if (numberGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }

            Console.Write(question);
            userGuess = Console.ReadLine();
            numberGuess = int.Parse(userGuess);
        }

        Console.WriteLine($"You guessed it the magic number is {magicNumber}");
    }
}