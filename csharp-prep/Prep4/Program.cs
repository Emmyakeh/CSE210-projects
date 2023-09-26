using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

                List<int> numbers = new List<int>();

                while(true)

                 {
            Console.Write("Enter a number (0 to stop): ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 0)
            {
                break; 
            }

            numbers.Add(input);
                         }

                
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers entered.");
        }
        else
        {
            double sum = 0;
            double max = numbers[0];

            foreach (double number in numbers)
            {
                sum += number;

                if (number > max)
                {
                    max = number;
                }
            }

            double average = sum / numbers.Count;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Largest number: {max}");
        }
    }
}

       

    
