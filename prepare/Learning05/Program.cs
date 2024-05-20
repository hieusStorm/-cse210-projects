using System;

class Program
{
    static void Main(string[] args)
    {
        Square testSquare = new Square("Red", 5);
        Console.WriteLine(testSquare.GetColor());
        Console.WriteLine(testSquare.GetArea());

        Rectangle testRectange = new Rectangle("rEd", 5, 10);
        Console.WriteLine(testRectange.GetColor());
        Console.WriteLine(testRectange.GetArea());

        Circle testCircle = new Circle("red", 5);
        Console.WriteLine(testCircle.GetColor());
        Console.WriteLine(testCircle.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(testSquare);
        shapes.Add(testRectange);
        shapes.Add(testCircle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}