using System;

class Program
{
    static void Main(string[] args)
   {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Journal Program Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":                       
                    Console.Write("Do you want a prompt? (yes/no): ");
                    string wantPrompt = Console.ReadLine().ToLower();
                    string prompt = "";
                    
                    if (wantPrompt == "yes")
                    {
                        List<string> prompts = new List<string>
                        { 
                            "Who was the most interesting person I interacted with today? ",
                            "What was the best part of my day? ",
                            "How did I see the hand of the Lord in my life today? ",
                            "What was the strongest emotion I felt today? ",
                            "If I had one thing I could do over today, what would it be? ",
                            "What could you have done better today ?",
                            "What could make your day better? ",
                            "What is the favorite part of your day? "
                        };
                        
                        Random random = new Random();
                        int index = random.Next(prompts.Count);
                        prompt = prompts[index];
                        Console.WriteLine(prompt);
                    }
                    else if (wantPrompt == "no")
                    {
                        Console.Write("Enter your own prompt/Topic: ");
                        prompt = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter 'yes' or 'no'.");
                        continue; // Restart the loop
                    }

                    // Proceed with writing the response
                    Console.WriteLine(" Write your response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Enter the filename to save: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    Console.WriteLine("Journal saved to file.");
                    break;
                case "4":
                    Console.Write("Enter the filename to load: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    Console.WriteLine("Journal loaded from file.");
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}


