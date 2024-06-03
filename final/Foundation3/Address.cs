public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    //constructor
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    //methods
    public void Display()
    {
        Console.WriteLine($"{_streetAddress} {_city}, {_state} {_country}");
    }
}