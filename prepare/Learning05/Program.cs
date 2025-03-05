using System;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square("red", 3);
        // Console.WriteLine(s1.GetColor());
        // Console.WriteLine(s1.GetArea());

        Rectangle r1 = new Rectangle("blue", 3, 7);
        // Console.WriteLine(r1.GetColor());
        // Console.WriteLine(r1.GetArea());

        Circle c1 = new Circle("purple", 7);
        // Console.WriteLine(c1.GetColor());
        // Console.WriteLine(c1.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s1);
        shapes.Add(r1);
        shapes.Add(c1);

        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }
    }
}