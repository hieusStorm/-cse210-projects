using System.Net.Sockets;

public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _type;

    public Event(string title, string description, string date, string time, Address address, string type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }

    public void StandardDetails() { 
        Console.WriteLine($"{_title}, {_description}, {_date}, {_time}");
        _address.Display();
    }
    public abstract void FullDetails();

    public void ShortDescription() { 
        Console.WriteLine($"{_type}: {_title}, {_date}");
    }
}