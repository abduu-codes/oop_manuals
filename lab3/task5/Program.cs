using System;
using System.Collections.Generic;

class Book
{
    public string Title;
    public string Author;
    public string Genre;
    public float Rating;
    public Book(string t, string a, string g, float r)
    {
        Title = t;
        Author = a;
        Genre = g;
        Rating = r;
    }
    public Book(Book otherBook)
    {
        this.Title = otherBook.Title;
        this.Author = otherBook.Author;
        this.Genre = otherBook.Genre;
        this.Rating = otherBook.Rating;
    }

    public void Display()
    {
        Console.WriteLine($"{Title} (Rating: {Rating})");
    }
}

class Program
{
    static void Main()
    {
        List<Book> library = new List<Book>();
        library.Add(new Book("Atomic Habits", "James Clear", "Self Help", 4.8f));
        library.Add(new Book("Deep Work", "Cal Newport", "Self Help", 4.7f));
        library.Add(new Book("C# Basics", "John Doe", "Education", 4.2f));
        library.Add(new Book("Mindset", "Carol Dweck", "Self Help", 4.6f));
        library.Add(new Book("Mystery of UET", "Ali Khan", "Mystery", 3.8f));

        Console.WriteLine("--- LIBRARY SYSTEM STARTED ---");
        Console.WriteLine("\nTop Rated Books:");
        Book highestRated = library[0]; 
        foreach (Book b in library) 
        {
            if (b.Rating > 4.5f)
            {
                b.Display();
            }
            if (b.Rating > highestRated.Rating)
            {
                highestRated = b;
            }
        }

        Console.WriteLine("\nSearch Genre: ");
        string searchGenre = Console.ReadLine();
        Console.WriteLine("Results:");

        foreach (Book b in library)
        {
            if (b.Genre == searchGenre)
            {
                Console.WriteLine(b.Title);
            }
        }
        List<Book> recommendedList = new List<Book>();

        Book clonedBook = new Book(highestRated);
        recommendedList.Add(clonedBook);
        Console.WriteLine("\nRecommended Book Added:");
        foreach (Book b in recommendedList)
        {
            Console.WriteLine(b.Title);
        }
        Console.WriteLine("\n--- LIBRARY REPORT COMPLETE ---");
    }
}