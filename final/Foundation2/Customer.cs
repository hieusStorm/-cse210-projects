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
    public string Region()
    {
        return "";
    }
}