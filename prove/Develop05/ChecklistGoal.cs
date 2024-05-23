public class ChecklistGoal : Goal
{
    // attributes
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    //constructors
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public ChecklistGoal(string name, string description, int points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }
    // methods
    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted / _target == 0)
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points and a bonus {_bonus} points.");
            return GetPoints() + _bonus;
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points.");
            return GetPoints();
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} - Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()},{GetDescription()},{GetPoints()},{_amountCompleted},{_target},{_bonus}";
    }
}