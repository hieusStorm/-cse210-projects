using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order([new Product("Computer", 0159, 149.99), new Product("Bananas", 02, 0.75, 5)], new Customer("computer boy", new Address("3144  W Computer Dr.", "Phoenix", "Az", "USA")));
        Order order2 = new Order([new Product("Computer", 0159, 149.99), new Product("Bananas", 02, 0.75, 5), new Product("keyboard", 0158, 24.99)], new Customer("computer man", new Address("3144  W Computer Dr.", "Phoenix", "Hampton", "CND")));

        string order1PackingLabel = order1.PackingLabel();
        string order1ShippingLabel = order1.ShippingLabel();
        double order1Price = order1.CalculatePrice();

        string order2PackingLabel = order2.PackingLabel();
        string order2ShippingLabel = order2.ShippingLabel();
        double order2Price = order2.CalculatePrice();

        Console.WriteLine($"Order 1 Price: ${order1Price}");
        Console.WriteLine($"Order 1 Packing Label:");
        Console.WriteLine(order1PackingLabel);
        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1ShippingLabel);

        Console.WriteLine();

        Console.WriteLine($"Order 2 Price: ${order2Price}");
        Console.WriteLine("Order 2 Packing Label");
        Console.WriteLine(order2PackingLabel);
        Console.WriteLine("Oder 2 Shipping Label");
        Console.WriteLine(order2ShippingLabel);
    }
}