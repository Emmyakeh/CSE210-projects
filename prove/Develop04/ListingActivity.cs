class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing") { }

    public void StartListingActivity()
    {
        SetDuration();
        StartActivity();
        Console.WriteLine("This activity will help you reflect on the good things in your life by listing as many items as you can in a certain area.");
        Random random = new Random();
        
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);

        int itemsCount = 0;

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Enter an item (or press Enter to skip):");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                itemsCount++;
            }
        }

        Console.WriteLine($"You entered {itemsCount} items.");
        EndActivity();
    }
}