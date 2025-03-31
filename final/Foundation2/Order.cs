public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private double _shipping_cost;
    
    public Order(Customer customer, Product product)
    {
        _customer = customer;
        _products.Add(product);
    }
    public Order(Customer customer, Product product1, Product product2)
    {
        _customer = customer;
        _products.Add(product1);
        _products.Add(product2);
    }
    public Order(Customer customer, Product product1, Product product2, Product product3)
    {
        _customer = customer;
        _products.Add(product1);
        _products.Add(product2);
        _products.Add(product3);
    }

    public double CalculateOrderCost()
    {
        double product_cost = 0;
        double ordercost = 0;
        if (_customer.IsAmerican())
        {
            _shipping_cost = 5;
        }
        else
        {
            _shipping_cost = 35;
        }
        foreach (Product product in _products)
        {
            product_cost += product.ProductCost();
        }
        ordercost = product_cost + _shipping_cost;
        
        return ordercost;
    }
    public string GetPackingLabel()
    {
        string packinglabel = "";
        foreach (Product product in _products)
        {
            packinglabel += "\n" + product.GetNameAndID();
        }
        return packinglabel;
    }
    public string GetShippingLabel()
    {
        //string _address = _customer.GetAddress()
        return _customer.GetName() + "\n" + _customer.GetAddress();
    }
    public void DisplayOrder()
    {
        Console.WriteLine($"PACKING LABEL: {GetPackingLabel()}");
        Console.WriteLine("");
        Console.WriteLine($"SHIPPING LABEL: \n{GetShippingLabel()}");
        Console.WriteLine("");
        Console.WriteLine($"TOTAL: ${CalculateOrderCost()}");
        Console.WriteLine();
    }
}