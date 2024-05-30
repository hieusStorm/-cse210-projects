public class Activity
{
    private string _type;
    private string _date;
    private int _length;

    public Activity(string type, string date, int length)
    {
        _type = type;
        _date = date;
        _length = length;
    }

    public virtual int Distance()
    {
        return 0;
    }
    public virtual int Speed()
    {
        return 0;
    }

    public virtual int Pace()
    {
        return 0;
    }

    public virtual void GetSummary() { }
}