class Program
{
    static void Main()
    {
        List<Goal> goals = new List<Goal>();
        int userPoints = 0;
        int userLevel = 1;
        int pointsToNextLevel = 500;

        while (true)
        {
            Console.WriteLine($"Your Current Points: {userPoints}");
            Console.WriteLine($"Your Current Level: {userLevel}");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(goals);
                    break;
                case "2":
                    ListGoals(goals);
                    break;
                case "3":
                    SaveGoals(goals);
                    break;
                case "4":
                    LoadGoals(goals);
                    break;
                case "5":
                    RecordEvent(goals, ref userPoints, ref userLevel, ref pointsToNextLevel);
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void SaveGoals(List<Goal> goals)
    {
        Console.Write("Enter the name of the file to save goals: ");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Goal goal in goals)
                {
                    writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Description},{goal.Points},{goal.TimesToComplete},{goal.BonusPoints},{goal.TimesCompleted}");
                }
            }

            Console.WriteLine($"Goals saved to {fileName}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    static void LoadGoals(List<Goal> goals)
    {
        Console.Write("Enter the name of the file to load goals: ");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                goals.Clear(); 

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    int timesToComplete = int.Parse(parts[4]);
                    int bonusPoints = int.Parse(parts[5]);
                    int timesCompleted = int.Parse(parts[6]);

                    switch (type)
                    {
                        case "SimpleGoal":
                            goals.Add(new SimpleGoal(name, description, points));
                            break;
                        case "EternalGoal":
                            goals.Add(new EternalGoal(name, description, points));
                            break;
                        case "ChecklistGoal":
                            goals.Add(new ChecklistGoal(name, description, points, timesToComplete, bonusPoints)
                            {
                                TimesCompleted = timesCompleted
                            });
                            break;
                    }
                }
            }

            Console.WriteLine($"Goals loaded from {fileName}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }

    static void CreateGoal(List<Goal> goals)
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Enter the type of goal (1-3): ");
        string typeChoice = Console.ReadLine();

        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter a short description of the goal: ");
        string description = Console.ReadLine();

        Console.Write("Enter the points for recording an event: ");
        int points = int.Parse(Console.ReadLine());

        switch (typeChoice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter the number of times to complete the goal for a bonus: ");
                int timesToComplete = int.Parse(Console.ReadLine());

                Console.Write("Enter the bonus points for completing the goal: ");
                int bonusPoints = int.Parse(Console.ReadLine());

                goals.Add(new ChecklistGoal(name, description, points, timesToComplete, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }

        Console.WriteLine("Goal created successfully.");
    }

    static void ListGoals(List<Goal> goals)
    {
        Console.WriteLine("Current Goals:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            goals[i].DisplayGoal();
            goals[i].DisplayProgress();
            Console.WriteLine();
        }
    }

    static void RecordEvent(List<Goal> goals, ref int userPoints, ref int userLevel, ref int pointsToNextLevel)
    {
        Console.WriteLine("Select the index of the goal to record an event:");

        ListGoals(goals);

        Console.Write("Enter the index: ");
        int index = int.Parse(Console.ReadLine());

        if (index >= 1 && index <= goals.Count)
        {
            Goal selectedGoal = goals[index - 1];

            int eventPoints = selectedGoal.RecordEvent();
            userPoints += eventPoints;

            int bonusPoints = selectedGoal.GetBonusPoints();
            userPoints += bonusPoints;

            Console.WriteLine($"Event recorded for {selectedGoal.Name}. You earned {eventPoints} points.");

            if (bonusPoints > 0)
            {
                Console.WriteLine($"Bonus points earned: {bonusPoints}");
            }

            
            if (userPoints >= pointsToNextLevel)
            {
                userLevel++;
                Console.WriteLine($"Congratulations! You've reached Level {userLevel}.");
                pointsToNextLevel *= 2;
                
            }
        }
        else
        {
            Console.WriteLine("Invalid index. Please try again.");
        }
    }

}