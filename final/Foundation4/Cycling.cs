public class Cycling : Activity
{
    private int _speed;
    public Cycling(string date, int length, int speed) : base("cycling", date, length)
    {
        _speed = speed;
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