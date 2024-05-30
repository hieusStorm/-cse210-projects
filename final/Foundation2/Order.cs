public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private double _price;
    //constructor
    public Order(List<Product> products, Customer customer)
    {
        _products.AddRange(products);
        _customer = customer;
    }

    //methods
    public double CalculatePrice()
    {
        return 0.00;
    }
    public void ShippingLabel() { }
    public void PackingLabel() { }
}