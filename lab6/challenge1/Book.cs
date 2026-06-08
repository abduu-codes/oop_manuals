namespace challenge1
{
    
    public class Book
    {
        public string title;
        public int isbn;
        public Author bookAuthor;

        public Book(string title, int isbn, Author author)
        {
            this.title = title;
            this.isbn = isbn;
            this.bookAuthor = author;
        }
    }
}