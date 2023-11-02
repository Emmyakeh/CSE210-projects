
class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing") { }

    public void StartBreathingActivity()
    {
        SetDuration();
        StartActivity();
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        int elapsedTime = 0;

        while (elapsedTime < duration)
        {
            Console.WriteLine("Breathe in...");
            PauseWithCountdown(3); 
            elapsedTime += 3;

            if (elapsedTime >= duration)
                break;

            Console.WriteLine("Breathe out...");
            PauseWithCountdown(3); 
            elapsedTime += 3;
        }

        EndActivity();
    }

    private void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            System.Threading.Thread.Sleep(1000); 
            Console.Write("\b \b");
        }
    }
}


