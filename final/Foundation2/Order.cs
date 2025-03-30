public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private double _shipping_cost;

    public double OrderCost()
    {
        double product_cost = 0;
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
        return product_cost + _shipping_cost;
    }
    public string GetPackingLabel()
    {
        string packinglabel = "";
        foreach (Product product in _products)
        {
            packinglabel += product.GetID();
        }
        return _customer.GetName();
    }
    public string GetShippingLabel()
    {
        return _customer.GetName() + _customer.GetAddress();
    }
}