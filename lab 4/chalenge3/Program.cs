using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chalenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] inventory = new Book[100];
            int totalBooks = 0;

            List<Member> members = new List<Member>();
            float totalStoreSales = 0.0f;
            float totalMembershipFees = 0.0f;
            int totalOfficialMembers = 0;

            int choice = 0;

            while (choice != 10)
            {
                Console.Clear();
                Console.WriteLine("\n=== THE COMPLETE BOOKSTORE SYSTEM ===");
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. Search Book by Title");
                Console.WriteLine("3. Search Book by ISBN");
                Console.WriteLine("4. Update Book Stock");
                Console.WriteLine("5. Add a Member");
                Console.WriteLine("6. Search for a Member");
                Console.WriteLine("7. Update Member Info");
                Console.WriteLine("8. Purchase a Book");
                Console.WriteLine("9. Display Store Stats");
                Console.WriteLine("10. Exit");
                Console.Write("Enter Option: ");

                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Clear();
                    if (totalBooks < 100)
                    {
                        Console.Write("Enter Title: "); string t = Console.ReadLine();
                        Console.Write("Enter ISBN: "); string i = Console.ReadLine();
                        Console.Write("Enter Price: "); float p = float.Parse(Console.ReadLine());
                        Console.Write("Enter Stock: "); int s = int.Parse(Console.ReadLine());

                        inventory[totalBooks] = new Book(t, "Pub", i, p, s, 2024);
                        totalBooks++;
                        Console.WriteLine("Book added.");
                    }
                    else Console.WriteLine("Inventory Full!");
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    Console.Write("Enter Exact Title: ");
                    string t = Console.ReadLine();
                    for (int i = 0; i < totalBooks; i++)
                    {
                        if (inventory[i].title == t)
                            inventory[i].ShowBookDetails();
                    }
                }
                else if (choice == 3)
                {
                    Console.Clear();
                    Console.Write("Enter Exact ISBN: ");
                    string isbn = Console.ReadLine();
                    for (int i = 0; i < totalBooks; i++)
                    {
                        if (inventory[i].ISBN == isbn)
                            inventory[i].ShowBookDetails();
                    }
                }
                else if (choice == 4)
                {
                    Console.Clear();
                    Console.Write("Enter ISBN to update stock: ");
                    string isbn = Console.ReadLine();
                    for (int i = 0; i < totalBooks; i++)
                    {
                        if (inventory[i].ISBN == isbn)
                        {
                            Console.Write("Enter amount to add/subtract: ");
                            inventory[i].stock += int.Parse(Console.ReadLine());
                            Console.WriteLine("Stock Updated.");
                        }
                    }
                }
                else if (choice == 5)
                {
                    Console.Clear();
                    Console.Write("Enter Name: ");
                    string n = Console.ReadLine();
                    Console.Write("Enter ID (0 for non-member buyer): ");
                    int id = int.Parse(Console.ReadLine());
                    members.Add(new Member(n, id));
                    if (id != 0)
                    {
                        totalMembershipFees += 10.0f;
                        totalOfficialMembers++;
                        Console.WriteLine("$10 Membership Fee Collected.");
                    }
                    else Console.WriteLine("Occasional Buyer added.");
                }
                else if (choice == 6)
                {
                    Console.Clear();
                    Console.Write("Enter Member ID to search (or 0 to skip to name search): ");
                    int searchID = int.Parse(Console.ReadLine());

                    foreach (Member m in members)
                    {
                        if (m.memberID == searchID && searchID != 0)
                            m.ShowMemberDetails();
                    }
                }

                else if (choice == 7) 
                {
                    Console.Clear();
                    Console.WriteLine("Enter member ID to update (0 for non-member): ");
                    int mid = int.Parse(Console.ReadLine());
                    Member targetMember = null;

                    if (mid != 0)
                    {
                      
                        foreach (Member m in members)
                        {
                            if (m.memberID == mid)
                            {
                                targetMember = m;
                                break; 
                            }
                        }
                    }
                    else
                    {
                      
                        Console.Write("Enter the exact name of the non-member: ");
                        string searchName = Console.ReadLine();

                        foreach (Member m in members)
                        {
                            if (m.memberID == 0 && m.name == searchName)
                            {
                                targetMember = m;
                                break;
                            }
                        }
                    }
                    if (targetMember != null) 
                    {
                        Console.WriteLine($"Found: {targetMember.name}. What would you like to update?");
                        Console.Write("Enter 1 for Name, 2 for ID, 3 for Both: ");
                        int mch = int.Parse(Console.ReadLine());

                        if (mch == 1)
                        {
                            Console.Write("Enter new name: ");
                            targetMember.name = Console.ReadLine();
                            Console.WriteLine("Name Updated.");
                        }
                        else if (mch == 2)
                        {
                            Console.Write("Enter new ID: ");
                            targetMember.memberID = int.Parse(Console.ReadLine());
                            Console.WriteLine("ID Updated.");
                        }
                        else if (mch == 3)
                        {
                            Console.Write("Enter new name: ");
                            targetMember.name = Console.ReadLine();
                            Console.Write("Enter new ID: ");
                            targetMember.memberID = int.Parse(Console.ReadLine());
                            Console.WriteLine("Name and ID Updated.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Member not found in the system.");
                    }
                }
               
                else if (choice == 8)
                    {
                        Console.Clear();
                        Console.Write("Enter Member ID (0 for occasional): ");
                        int mID = int.Parse(Console.ReadLine());
                        Console.Write("Enter Book ISBN to buy: "); 
                        string bISBN = Console.ReadLine();
                        Console.Write("Enter Quantity: "); 
                        int qty = int.Parse(Console.ReadLine());
                        Book selectedBook = null;
                        for (int i = 0; i < totalBooks; i++)
                        {
                            if (inventory[i].ISBN == bISBN) 
                            selectedBook = inventory[i];
                        }
                        Member activeMember = null;
                        foreach (Member m in members)
                        {
                            if (m.memberID == mID) 
                            activeMember = m;
                        }

                        if (selectedBook != null && activeMember != null && selectedBook.stock >= qty)
                        {
                            float costForOneBook = selectedBook.price;
                            if (activeMember.memberID != 0)
                            {
                                costForOneBook = costForOneBook * 0.95f;
                            }
                            float totalCostForThisTransaction = 0.0f;

                            for (int q = 0; q < qty; q++)
                            {
                                float finalPriceOfThisCopy = costForOneBook;
                                activeMember.numberOfBooksBought++; 

                                if (activeMember.memberID != 0 && activeMember.numberOfBooksBought % 11 == 0)
                                {
                                    float averageOfLast10 = activeMember.lastTenBooksTotal / 10.0f;
                                    finalPriceOfThisCopy = finalPriceOfThisCopy - averageOfLast10;

                                    if (finalPriceOfThisCopy < 0) 
                                    finalPriceOfThisCopy = 0; 

                                    Console.WriteLine($" 11th Book Bonus! Discount of $ {averageOfLast10} applied! ***");

                                    activeMember.lastTenBooksTotal = 0;
                                }
                                else if (activeMember.memberID != 0)
                                {
                                    activeMember.lastTenBooksTotal += finalPriceOfThisCopy;
                                }

                                totalCostForThisTransaction += finalPriceOfThisCopy;
                            }

                            selectedBook.stock -= qty;
                            activeMember.amountSpent += totalCostForThisTransaction;
                            totalStoreSales += totalCostForThisTransaction;

                            Console.WriteLine($"Purchase Successful! Total Paid: ${totalCostForThisTransaction}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Book not found, member not found, or insufficient stock.");
                        }
                    }
                    else if (choice == 9)
                    {
                        Console.Clear();
                        Console.WriteLine("\n--- Store Statistics ---");
                        Console.WriteLine($"Total Book Sales: ${totalStoreSales}");
                        Console.WriteLine($"Total Membership Fees: ${totalMembershipFees}");
                        Console.WriteLine($"Total Official Members: {totalOfficialMembers}");
                    }
                }
            }
        }
    }

