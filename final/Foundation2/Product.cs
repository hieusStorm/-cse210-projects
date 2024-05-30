using System.Dynamic;

public class Product
{
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    //Constructors
    public Product(string name, int id, double price)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = 1;
    }
    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    //methods
    public double TotalCost()
    {
        return 0;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetId()
    {
        return _id;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
}