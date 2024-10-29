using System;
using System.Collections.Generic;
using DemoPrototype;

public class Program
{
    public static void Main(string[] args)
    {
        List<IPrototype> shapes = new List<IPrototype>();

        Circle circle = new Circle { X = 10, Y = 10, Radius = 20, Color = "Red" };
        shapes.Add(circle);

        Circle anotherCircle = (Circle)circle.Clone();
        shapes.Add(anotherCircle);

        Rectangle rectangle = new Rectangle { X = 5, Y = 5, Width = 10, Height = 20, Color = "Blue" };
        shapes.Add(rectangle);

        List<IPrototype> shapesCopy = new List<IPrototype>();

        foreach (var shape in shapes)
        {
            shapesCopy.Add(shape.Clone());
        }

        foreach (var shape in shapesCopy)
        {
            if (shape is Circle c)
            {
                Console.WriteLine($"Circle: X={c.X}, Y={c.Y}, Radius={c.Radius}, Color={c.Color}");
            }
            else if (shape is Rectangle r)
            {
                Console.WriteLine($"Rectangle: X={r.X}, Y={r.Y}, Width={r.Width}, Height={r.Height}, Color={r.Color}");
            }
        }
    }
}
