using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member testMember = new Member("Abdullah", 101, 500.0f); 

            int choice = 0;
            while (choice != 5)
            {
                Console.WriteLine("\n=== Member Management Menu ===");
                Console.WriteLine("1. Show Member Name");
                Console.WriteLine("2. Modify Member Name");
                Console.WriteLine("3. Buy a Book (Test)");
                Console.WriteLine("4. Show Member Stats");
                Console.WriteLine("5. Exit");
                Console.Write("Enter Option: ");

                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    testMember.ShowName();
                }
                else if (choice == 2)
                {
                    Console.Write("Enter new name: ");
                    string updatedName = Console.ReadLine();
                    testMember.SetName(updatedName);
                }
                else if (choice == 3)
                {
                    Console.Write("Enter the title of the book to buy: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter the cost of the book: ");
                    float cost = float.Parse(Console.ReadLine());
                    testMember.BuyBook(title, cost);
                }
                else if (choice == 4)
                {
                    testMember.ShowStats();
                }
            }
        }
    }
}