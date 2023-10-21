
class Program
{
    static void Main(string[] args)
    {
        var scriptureLibrary = new ScriptureLibrary();

        Console.WriteLine("Welcome to the Scripture Hiding Program!");

        var sampleScripture = scriptureLibrary.GetRandomScripture();

        while (!sampleScripture.AllWordsHidden())
        {
            Console.Clear(); // Clear the console

            // Display the scripture with hidden words
            Console.WriteLine(sampleScripture.GetCurrentOutput());

            if (!sampleScripture.AllWordsHidden())
            {
                Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

                // Read user input
                string userInput = Console.ReadLine();

                // Check if the user wants to quit
                if (userInput.ToLower() == "quit")
                    break;

                // Hide a random word
                sampleScripture.HideRandomWord();
            }
        }

        Console.WriteLine("Program ended");
    }
}