public class Customer
{
    private string _name;
    private Address _address;

    //constructor 
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    //methods
    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address.Display();
    }
    public bool IsUSA()
    {
        if (_address.IsUSA())
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}