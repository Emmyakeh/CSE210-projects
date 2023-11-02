using System;
using System.Threading;

class Activity
{
    protected int duration;
    protected string description;

    public Activity(string description)
    {
        this.description = description;
    }

    public void SetDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        duration = int.Parse(Console.ReadLine());
    }

    public void StartActivity()
    {
        Console.WriteLine($"Starting {description} activity...");
        Console.WriteLine("Prepare to begin.");
        PauseWithAnimation(3);
    }

    public void EndActivity()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {description} activity in {duration} seconds.");
        PauseWithAnimation(3);
    }

    protected void PauseWithAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(">>>>");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}