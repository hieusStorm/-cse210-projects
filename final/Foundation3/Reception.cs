public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail) : base(title, description, date, time, address, "reception")
    {
        _rsvpEmail = rsvpEmail;
    }

    public override void FullDetails()
    {
        throw new NotImplementedException();
    }
}