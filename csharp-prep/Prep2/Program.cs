using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        string result = "";

        if (number >= 90 )
        {  result = "A";
        }

        else if (number >= 80) 
        { 
            result = "B";

        }

         else if (number >= 70)
        { 
            result = "C";

        }

        else if (number > 60)
        { 
            result = "D";

        }

        else 

        {
            result = "F";
        }
            Console.WriteLine($"Your grade is: {result}");
        
        if (number >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

    }
}