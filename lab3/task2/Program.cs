using System;

class Product
{
    public string Name;
    public double Price;
    public int Stock;
    public double TaxRate;

    // Constructor to set up each product easily
    public Product(string n, double p, int s, double tr)
    {
        Name = n;
        Price = p;
        Stock = s;
        TaxRate = tr;
    }
}

class Program
{
    static void Main()
    {

        Product[] store = new Product[5];

        store[0] = new Product("Laptop", 120000, 15, 0.10);
        store[1] = new Product("Milk", 250, 5, 0.05);    
        store[2] = new Product("Bread", 100, 8, 0.05);   
        store[3] = new Product("Phone", 50000, 0, 0.10); 
        store[4] = new Product("Headphones", 5000, 20, 0.08);

        double totalTax = 0;
        Product expensive = store[0];

        Console.WriteLine("--- STORE SYSTEM STARTED ---");
        Console.WriteLine("\nLow Stock Products:");
        foreach (Product p in store)
        {
            if (p.Stock == 0)
            {
                continue; 
            }
            double productTax = p.Price * p.TaxRate;
            totalTax = totalTax + productTax;
            if (p.Stock < 10)
            {
                Console.WriteLine(p.Name + " (Stock: " + p.Stock + ")");
            }

            if (p.Price > expensive.Price)
            {
                expensive = p;
            }
        }
        Console.WriteLine("\nTotal Store Tax: " + totalTax);
        Console.WriteLine("\nMost Expensive Product:");
        Console.WriteLine(expensive.Name + " -> Price: " + expensive.Price);
        Console.WriteLine("\n--- STORE REPORT GENERATED ---");
    }
}