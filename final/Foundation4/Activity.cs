public class Activity
{
    private string _type;
    private string _date;
    private double _length;

    public Activity(string type, string date, double length)
    {
        _type = type;
        _date = date;
        _length = length;
    }

    public virtual double Distance()
    {
        return 0;
    }
    public virtual double Speed()
    {
        return 0;
    }

    public virtual double Pace()
    {
        return 0;
    }

    public string GetSummary() { 
        return $"{_date}({_length}min) - Distance {Distance()} Miles, Speed {Speed()} MPH, Pace: {Pace()} min per mile";
    }

    //protected methods
    protected double GetLength() {
        return _length;
    }
}