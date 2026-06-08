using System;
using System.Collections.Generic;
class Shape
{
    public virtual double GetArea()
    {
        return 0;
    }

    public virtual string GetShapeType()
    {
        return "Shape";
    }
}


class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double GetArea()
    {
        return width * height;
    }

    public override string GetShapeType()
    {
        return "Rectangle";
    }
}
class Square : Shape
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public override double GetArea()
    {
        return side * side;
    }

    public override string GetShapeType()
    {
        return "Square";
    }
}
class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return 3.1416 * radius * radius;
    }

    public override string GetShapeType()
    {
        return "Circle";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Rectangle(4, 5));
        shapes.Add(new Square(3));
        shapes.Add(new Circle(2.5));
        shapes.Add(new Rectangle(2, 6));
        shapes.Add(new Square(5));
        foreach (Shape s in shapes)
        {
            Console.WriteLine("Type: " + s.GetShapeType());
            Console.WriteLine("Area: " + s.GetArea());
        }

        Console.ReadKey();
    }
}