public class GoalManager
{
    // attributes
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    //methods
    public void Start()
    {
        string playerChoice;
        do
        {
            DisplayPlayerInfo();

            Console.WriteLine($"Menu Options");
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
        Console.WriteLine($"You have ${_score} points.");
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
        Console.Write("\n What is the name of your goal? ");
        goalName = Console.ReadLine();
        Console.WriteLine("Please provide a description of your goal?");
        goalDescription = Console.ReadLine();
        Console.Write("How many points is your goal worth? ");
        goalPoints = int.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            newGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
        }
        else if (goalType == "2")
        {
            newGoal = new EternalGoal(goalName, goalDescription, goalPoints);
        }
        else if (goalType == "3")
        {
            int goalTarget;
            int goalBonus;
            Console.Write("\n How many types do you want to complete this goal");
            goalTarget = int.Parse(Console.ReadLine());
            Console.Write($"\n What is the bonus for completing this goal {goalTarget} times? ");
            goalBonus = int.Parse(Console.ReadLine());

            newGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus);
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
    }
    public void SaveGoals()
    {
        string fileName;
        Console.WriteLine("Please provide a name for your goals: ");
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
    public void LoadGoals() { }
}