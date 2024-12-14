using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create individual shapes
        Square square = new Square("Red", 4);
        Rectangle rectangle = new Rectangle("Blue", 5, 3);
        Circle circle = new Circle("Green", 2.5);

        // Test individual shapes
        Console.WriteLine($"Square Color: {square.GetColor()}, Area: {square.GetArea()}");
        Console.WriteLine($"Rectangle Color: {rectangle.GetColor()}, Area: {rectangle.GetArea()}");
        Console.WriteLine($"Circle Color: {circle.GetColor()}, Area: {circle.GetArea()}");

        // Create a list of shapes
        List<Shape> shapes = new List<Shape> { square, rectangle, circle };

        Console.WriteLine("\nIterating through the list of shapes:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}
