class Program
{
    static void Main(string[] args)
    {
        var scriptureLibrary = new ScriptureLibrary();

        Console.WriteLine("Welcome to the Scripture Hiding Program!");

        var sampleScripture = scriptureLibrary.GetRandomScripture();

        while (!sampleScripture.AllWordsHidden())
        {
            Console.Clear();

            Console.WriteLine(sampleScripture.GetCurrentOutput());

            if (!sampleScripture.AllWordsHidden())
            {
                Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "quit")
                    break;

                sampleScripture.HideRandomWord();
            }
        }

        Console.WriteLine("Program ended");
    }
}