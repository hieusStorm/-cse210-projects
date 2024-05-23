public class GoalManager
{
    // attributes
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _level = 1;
    //methods
    public void Start()
    {
        string playerChoice;
        do
        {
            Console.WriteLine();
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a Menu Option: ");
            playerChoice = Console.ReadLine();

            if (playerChoice == "1")
            {
                CreateGoal();
            }
            else if (playerChoice == "2")
            {
                ListGoalNames();
            }
            else if (playerChoice == "3")
            {
                SaveGoals();
            }
            else if (playerChoice == "4")
            {
                LoadGoals();
            }
            else if (playerChoice == "5")
            {
                RecordEvent();
            }
        } while (playerChoice != "6");
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You are level {_level}.");
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
    }
    public void ListGoalNames()
    {
        int i = 0;

        Console.Clear();
        Console.WriteLine("The Goals are:");

        foreach (Goal goal in _goals)
        {
            i++;
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
        }
    }
    public void CreateGoal()
    {
        Console.Clear();

        string goalType;
        string goalName;
        string goalDescription;
        int goalPoints;
        Goal newGoal;

        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("What type of goal would you like to make? ");
        goalType = Console.ReadLine();
        Console.WriteLine();
        Console.Write("What is the name of your goal? ");
        goalName = Console.ReadLine();
        Console.WriteLine("Please provide a description of your goal?");
        goalDescription = Console.ReadLine();
        Console.Write("How many points is your goal worth? ");
        goalPoints = int.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            newGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
            _goals.Add(newGoal);
        }
        else if (goalType == "2")
        {
            newGoal = new EternalGoal(goalName, goalDescription, goalPoints);
            _goals.Add(newGoal);
        }
        else if (goalType == "3")
        {
            int goalTarget;
            int goalBonus;
            Console.Write("How many times do you want to complete this goal? ");
            goalTarget = int.Parse(Console.ReadLine());
            Console.Write($"What is the bonus for completing this goal {goalTarget} times? ");
            goalBonus = int.Parse(Console.ReadLine());

            newGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus);
            _goals.Add(newGoal);
        }

    }
    public void RecordEvent()
    {
        Console.Clear();

        int i = 0;
        Console.WriteLine("The Goals are: ");
        foreach (Goal goal in _goals)
        {
            i++;
            Console.WriteLine($"{i}. {goal.GetName()}");
        }

        Console.Write("Which Goal have you accomplished? ");

        int goalAccomplished = int.Parse(Console.ReadLine());
        int pointsGained = _goals[goalAccomplished - 1].RecordEvent();
        _score = _score + pointsGained;

        if (_score / _level >= 100)
        {
            _level++;
            Console.WriteLine($"Congratulations! You leveled up! You are now level {_level}");
        }
    }
    public void SaveGoals()
    {
        Console.Clear();

        string fileName;
        Console.Write("Please provide a name for your goals: ");
        fileName = $"{Console.ReadLine()}.txt";

        using (StreamWriter goalFile = new StreamWriter(fileName))
        {
            goalFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                goalFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Clear();
        string fileName;

        Console.Write("What is the name of your goals file(exclude the file type)? ");
        fileName = $"{Console.ReadLine()}.txt";

        string[] goals = System.IO.File.ReadAllLines(fileName);

        _score = int.Parse(goals[0]);

        for (int i = 1; i < goals.Length; i++)
        {
            string[] goal = goals[i].Split(":");
            string goalType = goal[0];
            string[] goalInfo = goal[1].Split(",");
            if (goalType == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(goalInfo[0], goalInfo[1], int.Parse(goalInfo[2]), bool.Parse(goalInfo[3])));
            }
            else if (goalType == "EternalGoal")
            {
                _goals.Add(new EternalGoal(goalInfo[0], goalInfo[1], int.Parse(goalInfo[2])));
            }
            else if (goalType == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(goalInfo[0], goalInfo[1], int.Parse(goalInfo[2]), int.Parse(goalInfo[3]), int.Parse(goalInfo[4]), int.Parse(goalInfo[5])));
            }
        }

    }
}