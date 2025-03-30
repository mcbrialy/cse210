public class Product
{
    private string _name;
    private string _id;
    private double _price_per_unit;
    private int _quantity;

    public Product(string name, string id, double price_per_unit, int quantity)
    {
        _name = name;
        _id = id;
        _price_per_unit = price_per_unit;
        _quantity = quantity;
    }
    public double ProductCost()
    {
        return _price_per_unit * _quantity;
    }
    public string GetID()
    {
        return _id;
    }
}