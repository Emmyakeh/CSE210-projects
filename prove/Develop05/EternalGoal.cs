class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void DisplayProgress()
    {
        Console.WriteLine("Eternal goal - No completion progress");
    }
}