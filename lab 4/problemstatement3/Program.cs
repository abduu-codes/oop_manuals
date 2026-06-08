using System;
class Program
{
    static void Main(string[] args)
    {
        Customer cust1 = new Customer("Abdullah", "UET Hostels", "0300-1234567");
        Product p1 = new Product("Laptop", "Electronics", 50000f);
        Product p2 = new Product("Notebook", "Stationery", 500f);
        Product p3 = new Product("Mouse", "Electronics", 1500f);
        cust1.addProduct(p1);
        cust1.addProduct(p2);
        cust1.addProduct(p3);

        Console.WriteLine("Customer Name: " + cust1.customerName);
        Console.WriteLine("--- Items Purchased ---");
   
        foreach (Product item in cust1.getAllProducts())
        {
            Console.WriteLine("- " + item.name + " ($" + (item.price) + ")");
        }

        Console.WriteLine("-----------------------");
        Console.WriteLine("Total Tax Owed: $" + cust1.calculateTotalTax());
    }
}
