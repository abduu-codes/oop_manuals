using System;

namespace challenge2

{
    public class SystemUI
    {
        public static MUser TakeUserInput()
        {
            Console.Write("Enter Username: ");
            string name = Console.ReadLine();
            Console.Write("Enter Password: ");
            string pass = Console.ReadLine();
            Console.Write("Enter Role (Admin/Customer): ");
            string role = Console.ReadLine();
            return new MUser(name, pass, role);
        }

        public static MUser TakeLoginInput()
        {
            Console.Write("Enter Username: ");
            string name = Console.ReadLine();
            Console.Write("Enter Password: ");
            string pass = Console.ReadLine();
            return new MUser(name, pass, "");
        }
        public static Product TakeProductInput()
        {
            Console.Write("Name of Product: "); 
            string n = Console.ReadLine();
            Console.Write("Category (Grocery/Fruit/Other): "); 
            string c = Console.ReadLine();
            Console.Write("Price: "); 
            float p = float.Parse(Console.ReadLine());
            Console.Write("Available Stock: "); 
            int s = int.Parse(Console.ReadLine());
            Console.Write("Minimum Threshold: ");
            int t = int.Parse(Console.ReadLine());
            return new Product(n, c, p, s, t);
        }

        public static void ViewAllProducts()
        {
            Console.WriteLine("\nName\tCategory\tPrice\tStock");
            foreach (Product p in ProductDL.products)
            {
                Console.WriteLine($"{p.name}\t{p.category}\t\t${p.price}\t{p.stock}");
            }
        }

        public static void ViewTaxes()
        {
            Console.WriteLine("\nName\tBase Price\tSales Tax");
            foreach (Product p in ProductDL.products)
            {
                Console.WriteLine($"{p.name}\t${p.price}\t\t${p.CalculateTax()}");
            }
        }

        public static void ViewProductsToOrder()
        {
            Console.WriteLine("\n--- Products Below Threshold ---");
            foreach (Product p in ProductDL.products)
            {
                if (p.stock < p.minStock)
                {
                    Console.WriteLine($"{p.name} (Stock: {p.stock} | Threshold: {p.minStock})");
                }
            }
        }
        public static void BuyProduct(Customer currentCustomer)
        {
            Console.Write("Enter Product Name to Buy: ");
            string name = Console.ReadLine();

            Product p = ProductDL.FindProduct(name);
            if (p != null)
            {
                Console.Write("Enter Quantity: ");
                int qty = int.Parse(Console.ReadLine());

                if (p.stock >= qty)
                {
                    p.stock -= qty; 
                    currentCustomer.AddToCart(p, qty); 
                    Console.WriteLine("Successfully added to cart!");
                }
                else
                {
                    Console.WriteLine("Error: Not enough stock available.");
                }
            }
            else
            {
                Console.WriteLine("Error: Product not found.");
            }
        }

        public static void GenerateInvoice(Customer currentCustomer)
        {
            Console.WriteLine("\n--- INVOICE ---");
            float grandTotal = 0;

            for (int i = 0; i < currentCustomer.cartProducts.Count; i++)
            {
                Product p = currentCustomer.cartProducts[i];
                int qty = currentCustomer.cartQuantities[i];

                float itemTotal = (p.price + p.CalculateTax()) * qty;
                grandTotal += itemTotal;

                Console.WriteLine($"{p.name} x{qty} \t Price: ${p.price} \t Tax: ${p.CalculateTax()} \t Subtotal: ${itemTotal}");
            }

            Console.WriteLine($"\nGRAND TOTAL TO PAY: ${grandTotal}");
        }
    }
}