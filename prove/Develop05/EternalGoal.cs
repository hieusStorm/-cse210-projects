public class EternalGoal : Goal
{
    // constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }
    // methods
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints}";
    }
}