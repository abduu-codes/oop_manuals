using System;

namespace challenge1
{
    public class LibraryUI
    {
        public static Book TakeBookInput()
        {
            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter ISBN: ");
            int isbn = int.Parse(Console.ReadLine());
            Console.Write("Enter Author Name: "); 
            string aName = Console.ReadLine();
            Console.Write("Enter Author Email: "); 
            string aEmail = Console.ReadLine();

            Author a = new Author(aName, aEmail);
            return new Book(title, isbn, a);
        }

        public static void DisplayBooks()
        {
            foreach (var b in BookDL.books)
            {
                Console.WriteLine($"Book: {b.title} (ISBN: {b.isbn}) | Author: {b.bookAuthor.name}");

            }
        }
    }
}