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
            Console.Clear();
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
            else if (playerChoice == "2") {
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
    public void DisplayPlayerInfo() { 
        Console.WriteLine($"You have ${_score} points.");
        Console.WriteLine();
    }
    public void ListGoalNames()
    {
        int i = 0;
        Console.WriteLine("The Goals are: ");
        foreach (Goal goal in _goals)
        {
            i++;
            Console.WriteLine($"{i}. {goal.GetName()}");
        }
    }
    public void CreateGoal() { }
    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which Goal have you accomplished? ");

        int goalAccomplished = int.Parse(Console.ReadLine());
        int pointsGained = _goals[goalAccomplished - 1].RecordEvent();
        _score = _score + pointsGained;
    }
    public void SaveGoals() { }
    public void LoadGoals() { }
}