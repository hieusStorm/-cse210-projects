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
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    public virtual string GetDetailsString()
    {
        string detailsString;
        if (IsComplete())
        {
            detailsString = $"[X] {_shortName} ({_description})";
        }
        else
        {
            detailsString = $"[] {_shortName} ({_description})";
        }
        return detailsString;
    }

    //getters
    protected string GetName() {
        return _shortName;
    }
    protected string GetDescription() {
        return _description;
    }
    protected int GetPoints() {
        return _points;
    }
}