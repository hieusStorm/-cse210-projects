public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address, "outdoor")
    {
        _weather = weather;
    }

    public override void FullDetails()
    {
        StandardDetails();
        Console.WriteLine($"Expected Weather: {_weather}");
    }
}