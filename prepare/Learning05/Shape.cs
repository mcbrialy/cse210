public class Shape
{
    string _color;
    public Shape(string color)
    {
        _color = color;
    }
    public virtual double GetArea()
    {
        return -1;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
}