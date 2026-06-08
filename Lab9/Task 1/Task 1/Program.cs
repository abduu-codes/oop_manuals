
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{

    class Circle
    {
        private double radius = 1.0;
        private string color = "red";
        public Circle()
        {

        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public double getRadius()

        {
            return radius;
        }
        public void setradius(double radius)
        {
            this.radius = radius;
        }
        public string getColor(string color)
        {
            return color;
        }
        public void setcolor(string color)
        {
            this.color = color;
        }
        public virtual double getarea()
        {
            return 3.14 * radius * radius;
        }
        public virtual string tostring()
        {
            return $"Color = radius ={radius}color = {color}";
        }
    }
    class clyinder : Circle
    {
        private double height = 1.0;
        public clyinder() : base()
        {

        }
        public clyinder(double radius) : base(radius)
        {

        }
        public clyinder(double radius, double height) : base(radius)
        {
            this.height = height;
        }
        public clyinder(double radius, string color, double height) : base(radius, color)
        {
            this.height = height;
        }
        public double getheight()
        {
            return height;
        }
        public void setheight(double height)
        {
            this.height = height;
        }
        public double getvloume()
        {
            return getarea() * height;
        }
        public override string tostring()
        {
            return "Cylinder: " + base.tostring() + "Height = "+ height;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(22, "red");
            Console.WriteLine(c1.getarea());
            Console.WriteLine(c1.tostring());
            Console.WriteLine("Circle class object created");
            clyinder c2 = new clyinder(22, "pink", 22);
            Console.WriteLine(c2.getheight());
            Console.WriteLine(c2.getvloume());
            Console.WriteLine(c2.tostring());
            Console.ReadKey();

        }
    }
}
