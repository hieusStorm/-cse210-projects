public class GoalManager
{
    // attributes
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    //methods
    public void Start() { }
    public void DisplayPlayerInfo() { }
    public void ListGoalNames() { }
    public void CreateGoal() { }
    public void RecordEvent()
    {
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
    public void SaveGoals() { }
    public void LoadGoals() { }
}