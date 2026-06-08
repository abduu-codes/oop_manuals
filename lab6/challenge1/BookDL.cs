using System.Collections.Generic;

namespace challenge1

{
    public class BookDL
    {
        public static List<Book> books = new List<Book>();

        public static void AddBook(Book b)
        {
            books.Add(b);
        }
    }
}