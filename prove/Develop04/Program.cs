class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Meditation Activity");
            Console.WriteLine("5. Quit");

            int choice = int.Parse(Console.ReadLine());

            Activity activity = null;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    ((BreathingActivity)activity).StartBreathingActivity();
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    ((ReflectionActivity)activity).StartReflectionActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    ((ListingActivity)activity).StartListingActivity();
                    break;
                case 4:
                    activity = new MeditationActivity();
                    ((MeditationActivity)activity).StartMeditationActivity();
                    break;
                case 5:
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}