using System;
using System.Collections.Generic;

namespace challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] inventory = new Book[100];
            int totalBooks = 0;

            int choice = 0;

            while (choice != 6)
            {
                Console.WriteLine("\n=== Bookstore Inventory Menu ===");
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. Search Book by Title");
                Console.WriteLine("3. Search Book by ISBN");
                Console.WriteLine("4. Update Stock of a Book");
                Console.WriteLine("5. See All Books");
                Console.WriteLine("6. Exit");
                Console.Write("Enter Option: ");

                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    if (totalBooks < 100)
                    {
                        Console.Write("Enter Title: ");
                        string t = Console.ReadLine();
                        Console.Write("Enter Publisher: ");
                        string pub = Console.ReadLine();
                        Console.Write("Enter ISBN: ");
                        string isbn = Console.ReadLine();
                        Console.Write("Enter Price: ");
                        float p = float.Parse(Console.ReadLine());
                        Console.Write("Enter Stock: ");
                        int s = int.Parse(Console.ReadLine());
                        Console.Write("Enter Year of Publication: ");
                        int y = int.Parse(Console.ReadLine());

                        inventory[totalBooks] = new Book(t, pub, isbn, p, s, y);
                        Console.Write("How many authors does this book have? (Max 4): ");
                        int numAuthors = int.Parse(Console.ReadLine());
                        for (int i = 0; i < numAuthors && i < 4; i++)
                        {
                            Console.Write($"Enter Author {i + 1} Name: ");
                            inventory[totalBooks].AddAuthor(Console.ReadLine());
                        }
                    totalBooks++;
                    Console.WriteLine("Book added successfully!");
                    }
                else

                    {
                        Console.WriteLine("Inventory is full! Cannot add more books.");
                    }
                }



                else if (choice == 2)
                {
                    Console.Write("Enter Exact Title to Search: ");
                    string searchT = Console.ReadLine();
                    bool found = false;

                    for (int i = 0; i < totalBooks; i++)
                    {
                        if (inventory[i].CheckTitle(searchT) == true)
                        {
                            inventory[i].ShowAllDetails();
                            found = true;
                            break;
                        }
                    }
                    if (found == false)
                        Console.WriteLine("Book not found.");
                }
                else if (choice == 3)
                {
                    Console.Write("Enter ISBN to Search: ");
                    string searchIsbn = Console.ReadLine();
                    bool found = false;

                    for (int i = 0; i < totalBooks; i++)
                    {
                        if (inventory[i].CheckISBN(searchIsbn) == true)
                        {
                            inventory[i].ShowAllDetails();
                            found = true;
                            break;
                        }
                    }
                    if (found == false)
                        Console.WriteLine("Book not found.");
                }
                else if (choice == 4)
                {
                    Console.Write("Enter ISBN of the book to update: ");
                    string searchIsbn = Console.ReadLine();
                    bool found = false;

                    for (int i = 0; i < totalBooks; i++)
                    {
                        if (inventory[i].CheckISBN(searchIsbn) == true)
                        {
                            inventory[i].ShowStock();
                            Console.Write("Enter amount to add (use negative number to subtract): ");
                            int amount = int.Parse(Console.ReadLine());

                            inventory[i].UpdateStock(amount);
                            Console.WriteLine("Stock updated.");
                            inventory[i].ShowStock();

                            found = true;
                            break;
                        }
                    }
                    if (found == false)
                        Console.WriteLine("Book not found.");
                }
                else if (choice == 5)
                {
                    if (totalBooks == 0)
                    {
                        Console.WriteLine("No books in inventory.");
                    }
                    else
                    {
                        Console.WriteLine("\n--- All Books in Inventory ---");
                        for (int i = 0; i < totalBooks; i++)
                        {
                            inventory[i].ShowAllDetails();
                        }
                        Console.WriteLine("-------------------------------");
                    }
                }
            }
        }
    }
}