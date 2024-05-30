public class Lecture : Event
{
    private string _speaker;
    private int _maxCapacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int maxCapacity) : base(title, description, date, time, address, "lecture")
    {
        _speaker = speaker;
        _maxCapacity = maxCapacity;
    }

    public override void FullDetails()
    {
        throw new NotImplementedException();
    }
}