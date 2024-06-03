public class Swim : Activity
{
    private double _laps;
    public Swim(string date, double length, double laps) : base("swim", date, length)
    {
        _laps = laps;
    }
    public override double Distance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    public override double Speed()
    {
        return Distance() / GetLength();
    }

    public override double Pace()
    {
        return GetLength() / Distance();
    }
}