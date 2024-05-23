public class EternalGoal : Goal
{
    // constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }
    // methods
    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points");
        return GetPoints();
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