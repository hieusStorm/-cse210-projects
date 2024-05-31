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
        double totalPrice = 0;

        foreach (Product product in _products)
        {
            totalPrice = totalPrice + product.TotalCost();
        }

        if (_customer.IsUSA())
        {
            totalPrice = totalPrice + 5;
        }
        else
        {
            totalPrice = totalPrice + 35;
        }
        return totalPrice;
    }
    public string ShippingLabel()
    {
        return $"{_customer.GetName()}, \n {_customer.GetAddress()}";
    }
    public string PackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel = packingLabel + $"Product Name: {product.GetName()} \n Product ID: {product.GetId()} \n";
        }
        return packingLabel;
    }
}