using System;

public class Book
{
    public string title;
    public string publisher;
    public string ISBN;
    public float price;
    public int stock;
    public int yearOfPublication;

    public Book(string t, string pub, string isbn, float p, int s, int y)
    {
        title = t;
        publisher = pub;
        ISBN = isbn;
        price = p;
        stock = s;
        yearOfPublication = y;
    }

    public void ShowBookDetails()
    {
        Console.WriteLine($"Title: {title} | ISBN: {ISBN} | Stock: {stock} | Price: ${price}");
    }
}