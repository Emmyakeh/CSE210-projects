using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Number Guess Game!");

        //Console.Write("What is your magic number?");
        //int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        bool guessedCorrectly = false;

        while (!guessedCorrectly)
        {
            Console.WriteLine("What is your guess?");
            int guess = int.Parse(Console.ReadLine());  

             if (magicNumber == guess)
            {
                Console.WriteLine("You guessed it!");
                guessedCorrectly = true;
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Guess Higher");
            }
            else
            {
                Console.WriteLine("Guess Lower");
            }
        }

    
         

           

        }
    
}