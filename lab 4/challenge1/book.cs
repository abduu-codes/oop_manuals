using System;

public class Book
{
    public string title;
    public string[] authors = new string[4]; 
    public int authorCount;                  
    public string publisher;
    public string ISBN;
    public float price;
    public int stock;
    public int yearOfPublication;
    public Book(string bTitle, string bPublisher, string bISBN, float bPrice, int bStock, int bYear)
    {
        title = bTitle;
        publisher = bPublisher;
        ISBN = bISBN;
        price = bPrice;
        stock = bStock;
        yearOfPublication = bYear;
        authorCount = 0;
    }

    public void ShowTitle()
    {
        Console.WriteLine("Title: " + title);
    }

    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }

    public bool CheckTitle(string searchTitle)
    {
        return title == searchTitle;
    }
    public void ShowISBN()
    {
        Console.WriteLine("ISBN: " + ISBN);
    }

    public bool CheckISBN(string searchISBN)
    {
        return ISBN == searchISBN;
    }
    public void ShowStock()
    {
        Console.WriteLine("Current Stock: " + stock);
    }

    public void SetStock(int newStock)
    {
        stock = newStock;
    }

    public void UpdateStock(int amountToAddOrSubtract)
    {
        stock = stock + amountToAddOrSubtract;
    }

    public int GetStock()
    {
        return stock;
    }

    public void AddAuthor(string authorName)
    {
        if (authorCount < 4)
        {
            authors[authorCount] = authorName;
            authorCount++;
        }
        else
        {
            Console.WriteLine("Cannot add more authors. Maximum of 4 reached.");
        }
    }

    public void ShowAllDetails()
    {
        Console.WriteLine($"\n--- Book Details ---");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Publisher: {publisher} ({yearOfPublication})");
        Console.WriteLine($"Price: ${price}");
        Console.WriteLine($"Stock: {stock}");
        Console.Write("Authors: ");
        for (int i = 0; i < authorCount; i++)
        {
            Console.Write(authors[i] + (i < authorCount - 1 ? ", " : ""));
        }
        Console.WriteLine("\n--------------------");
    }
}