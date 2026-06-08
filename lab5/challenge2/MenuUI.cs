using System;

namespace challenge2
{
    public class MenuUI
    {
        public static string MainMenu()
        {
            Console.WriteLine("\n=== Store System ===");
            Console.WriteLine("1. Sign In");
            Console.WriteLine("2. Sign Up");
            Console.WriteLine("3. Exit");
            Console.Write("Enter Option: ");
            return Console.ReadLine();
        }

        public static string AdminMenu()
        {
            Console.WriteLine("\n--- Admin Menu ---");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View All Products");
            Console.WriteLine("3. Find Product with Highest Unit Price");
            Console.WriteLine("4. View Sales Tax of All Products");
            Console.WriteLine("5. Products to be Ordered");
            Console.WriteLine("6. Logout");
            Console.Write("Enter Option: ");
            return Console.ReadLine();
        }

        public static string CustomerMenu()
        {
            Console.WriteLine("\n--- Customer Menu ---");
            Console.WriteLine("1. View All Products");
            Console.WriteLine("2. Buy Product");
            Console.WriteLine("3. Generate Invoice");
            Console.WriteLine("4. Logout");
            Console.Write("Enter Option: ");
            return Console.ReadLine();
        }
    }
}