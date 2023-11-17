abstract class Goal
{
    private string _name;
    private string _description;
    protected int _points;
    protected int _bonusPoints;
    protected int _timesToComplete;
    protected int _timesCompleted;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public int Points
    {
        get { return _points; }
        protected set { _points = value; }
    }

    public int BonusPoints
    {
        get { return _bonusPoints; }
        protected set { _bonusPoints = value; }
    }

    public int TimesToComplete
    {
        get { return _timesToComplete; }
        protected set { _timesToComplete = value; }
    }

    public int TimesCompleted
    {
        get { return _timesCompleted; }
        set { _timesCompleted = value; }
    }

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public int Level { get; set; } = 1;
    public int Experience { get; set; } = 0;
    public int ExperienceToLevelUp { get; set; } = 1000;

  
    public void AwardExperience(int points)
    {
        Experience += points;
        CheckLevelUp();
    }

    private void CheckLevelUp()
    {
        if (Experience >= ExperienceToLevelUp)
        {
            LevelUp();
        }
    }


    private void LevelUp()
    {
        Level++;
        Console.WriteLine($"Congratulations! You've reached Level {Level}.");
        Experience -= ExperienceToLevelUp;
        ExperienceToLevelUp = (int)(ExperienceToLevelUp * 1.5); 
    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"{_name}: {_description}");
    }

    public virtual void DisplayProgress()
    {
        Console.WriteLine($"Completed {_timesCompleted}/{_timesToComplete} times");
    }

    public virtual int RecordEvent()
    {
        _timesCompleted++;
        return _points;
    }

    public virtual int GetBonusPoints()
    {
        if (_timesCompleted >= _timesToComplete)
        {
            return _bonusPoints;
        }
        return 0;
    }

    
}