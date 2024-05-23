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
        throw new NotImplementedException();
    }
    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}