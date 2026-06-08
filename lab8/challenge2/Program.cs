using System;

namespace challenge2

{
    public class Circle
    {
        protected double radius;
        protected string color;
        public Circle()
        {
            this.radius = 1.0;
            this.color = "red";
        }

        public Circle(double radius)
        {
            this.radius = radius;
            this.color = "red";
        }
        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public double getRadius()
        { return radius; }
        public void setRadius(double radius) 
        { 
            this.radius = radius; 
        }
        public string getColor() 
        { 
            return color; 
        }
        public void setColor(string color) 
        { 
            this.color = color; 
        }

        public double getArea() 
        { 
            return Math.PI * radius * radius; 
        }

        public string toString()
        {
            return "Circle[radius=" + radius + ",color=" + color + "]";
        }
    }

    public class Cylinder : Circle
    {
        protected double height;

        public Cylinder() : base()
        {
            this.height = 1.0;
        }

        public Cylinder(double radius) : base(radius)
        {
            this.height = 1.0;
        }

        public Cylinder(double radius, double height) : base(radius)
        {
            this.height = height;
        }

        public Cylinder(double radius, double height, string color) : base(radius, color)
        {
            this.height = height;
        }

        public double getHeight() 
        {
            return height; 
        }
        public void setHeight(double height)
        {
            this.height = height;
        }

        public double getVolume() 
        {
            return getArea() * height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle defaultCircle = new Circle();
            Circle customCircle = new Circle(5.5, "blue");

            Cylinder myCylinder = new Cylinder(3.0, 10.0, "green");

            Console.WriteLine("Default Circle: " + defaultCircle.toString() + " | Area: " + defaultCircle.getArea());
            Console.WriteLine("Custom Circle: " + customCircle.toString() + " | Area: " + customCircle.getArea());

            Console.WriteLine("\nCylinder Base Area: " + myCylinder.getArea());
            Console.WriteLine("Cylinder Volume: " + myCylinder.getVolume());

            Console.ReadKey();
        }
    }
}