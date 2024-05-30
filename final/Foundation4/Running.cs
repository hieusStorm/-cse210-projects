public class Running : Activity
{
    private int _distance;

    public Running(string date, int length, int distance) : base("running", date, length)
    {
        _distance = distance;
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