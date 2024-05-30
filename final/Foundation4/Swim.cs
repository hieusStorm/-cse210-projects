public class Swim : Activity
{
    private int _laps;
    public Swim(string date, int length, int laps) : base("swim", date, length)
    {
        _laps = laps;
    }
    public override int Distance()
    {
        return base.Distance();
    }
    public override int Speed()
    {
        return base.Speed();
    }

    public override int Pace()
    {
        return base.Pace();
    }
    public override void GetSummary()
    {
        base.GetSummary();
    }
}