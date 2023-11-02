class MeditationActivity : Activity
{
    public MeditationActivity() : base("Meditation") { }

    public void StartMeditationActivity()
    {
        SetDuration();
        StartActivity();
        Console.WriteLine("This activity will guide you through a short meditation to help you relax and clear your mind.");

        int elapsedTime = 0;

        while (elapsedTime < duration)
        {
            Console.WriteLine("Close your eyes and take a deep breath...");
            PauseWithAnimation(3);
            elapsedTime += 3;

            if (elapsedTime >= duration)
                break;

            Console.WriteLine("Focus on your breath and let go of any tension...");
            PauseWithAnimation(6);
            elapsedTime += 6;
        }

        EndActivity();
    }
}
