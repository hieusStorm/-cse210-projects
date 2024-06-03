public class Cycling : Activity
{
    private double _speed;
    public Cycling(string date, double length, double speed) : base("cycling", date, length)
    {
        _speed = speed;
    }
    public override double Distance()
    {
        return (_speed/60) * GetLength();
    }
    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        return 60/_speed;
    }
}