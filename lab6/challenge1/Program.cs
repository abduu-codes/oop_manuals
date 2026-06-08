using System;

namespace challenge1

{


    //This is an Association. A Book is associated with an Author.
    //While a book has an author, the author exists independently of any single book they wrote.


    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            while (choice != 3)
            {
                Console.WriteLine("\n--- Library Menu ---");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. View All Books");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Book newBook = LibraryUI.TakeBookInput();
                    BookDL.AddBook(newBook);
                }
                else if (choice == 2)
                {
                    LibraryUI.DisplayBooks();
                }
            }
        }
    }
}