public abstract class Goal
{
    // attributes
    private string _shortName;
    private string _description;
    private int _points;
    //constructors
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    //methods
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    public virtual string GetDetailsString()
    {
        return "hi";
    }

}