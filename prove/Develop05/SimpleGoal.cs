public class SimpleGoal : Goal
{
    //attributes
    private bool _isComplete;
    //constructors
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    //methods
    public override int RecordEvent()
    {
        _isComplete = true;
        return GetPoints();
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal: {GetName()},{GetDescription()},{GetPoints()},{_isComplete}";   
    }
}