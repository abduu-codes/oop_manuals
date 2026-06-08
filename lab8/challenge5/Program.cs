using System;

namespace challenge5
{
    public class Car
    {
        protected string model;
        protected string color;
        protected double price;

        public Car(string model, string color, double price)
        {
            this.model = model;
            this.color = color;
            this.price = price;
        }

        public void displayInfo()
        {
            Console.WriteLine("Model: " + model + " | Color: " + color + " | Price: " + price);
        }
    }

    public class BMW : Car
    {
        public BMW(string color, double price) : base("BMW", color, price)
        { }

        public double calculateBMWFuel(double distance)
        {
            return distance / 8.0; 
        }
    }

    public class Audi : Car
    {
        public Audi(string color, double price) : base("Audi", color, price)
        { }

        public double calculateAudiFuel(double distance)
        {
            return distance / 10.0; 
        }
    }

    public class GLI : Car
    {
        public GLI(string color, double price) : base("GLI", color, price)
        { }

        public double calculateGLIFuel(double distance)
        {
            return distance / 14.0; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BMW myBmw = new BMW("Black", 15000000);
            Audi myAudi = new Audi("Silver", 12000000);
            GLI myGli = new GLI("White", 6000000);

            myBmw.displayInfo();
            Console.WriteLine("Fuel needed for 100km: " + myBmw.calculateBMWFuel(100) + " liters\n");
            myAudi.displayInfo();
            Console.WriteLine("Fuel needed for 100km: " + myAudi.calculateAudiFuel(100) + " liters\n");
            myGli.displayInfo();
            Console.WriteLine("Fuel needed for 100km: " + myGli.calculateGLIFuel(100) + " liters\n");
            Console.ReadKey();
        }
    }
}