using System;
using System.Collections.Generic;

class product
{
    public int Id;
    public string Name;
    public int Price;
    public string Category;
    public string Brand;
    public string Country;
   
    public product(int id, string name, int price, string category, string brand, string country)
    {
        Id = id;
        Name = name;
        Price = price;
        Category = category;
        Brand = brand;
        Country = country;
    }
}

class Program
{
    static void Main()
    {
        List<product> products = new List<product>();
        while (true)
        {
            // Menu options
            Console.WriteLine("\n--- product management ---");
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. Show All products");
            Console.WriteLine("3. total worth");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("enter the product id , product name ,price , category, brand and country in which it is made");
                int pid = Convert.ToInt32(Console.ReadLine());
                string pname = Console.ReadLine();
                int pprice = Convert.ToInt32(Console.ReadLine());
                string pcat = Console.ReadLine();
                string pbrand = Console.ReadLine();
                string pcount = Console.ReadLine();
                product products1 = new product(pid, pname, pprice, pcat, pbrand, pcount);
                products.Add(products1);
            }
            else if (choice == "2")
            {
                Console.WriteLine("all products:\n");
                foreach (product p in products)
                {
                    Console.WriteLine("id= " + p.Id + " name: " + p.Name + " price= " + p.Price + " category= " + p.Category + " brand=" + p.Brand + " country=" + p.Country);
                }
            }
            else if (choice == "3") 
            {
                int tworth = 0;
                foreach (product p in products) 
                {
                    tworth = tworth + p.Price;
                }
                Console.WriteLine("total worth is : " + tworth);
            }

        }
    }
}