class ChecklistGoal : Goal
{
    public ChecklistGoal(string name, string description, int points, int timesToComplete, int bonusPoints) : base(name, description, points)
    {
        _timesToComplete = timesToComplete;
        _bonusPoints = bonusPoints;
    }

    public override void DisplayProgress()
    {
        Console.WriteLine($"Completed {_timesCompleted}/{_timesToComplete} times");
    }
}