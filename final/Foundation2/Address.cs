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
    public bool IsUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string Display()
    {
        return $"{_streetAddress}, {_city}, {_state} {_country}";
    }
}