using System;
using System.Collections.Generic;

namespace problemstatement2

{
    class Book
    {
        public string title;
        public string author;
        public int pages;
        public List<string> chapters; 
        public int bookMark;
        public int price;
        public bool isAvailable;
        public Book(string bTitle, string bAuthor, int bPages, List<string> bChapters, int bMark, int bPrice, bool bAvailable)
        {
            title = bTitle;
            author = bAuthor;
            pages = bPages;
            chapters = bChapters;
            bookMark = bMark;
            price = bPrice;
            isAvailable = bAvailable;
        }

        public bool isBookAvailable()
        {
            return isAvailable;
        }

        public string getChapter(int chapterNumber)
        {
            int index = chapterNumber - 1;
            if (index >= 0 && index < chapters.Count)
            {
                return chapters[index];
            }
            else
            {
                return "Error: Chapter number does not exist.";
            }
        }

        public int getBookMark()
        {
            return bookMark;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> oopChapters = new List<string>();
            oopChapters.Add("Introduction to OOP");
            oopChapters.Add("Classes and Objects");
            oopChapters.Add("Constructors");
            oopChapters.Add("Member Functions");

            Book myBook = new Book("C# Basics", "Ramsha", 300, oopChapters, 45, 1500, true);

            Console.WriteLine("--- Book Details ---");
            Console.WriteLine("Title: " + myBook.title);
            if (myBook.isBookAvailable() == true)
            {
                Console.WriteLine("Status: Available in Library.");
            }
            else
            {
                Console.WriteLine("Status: Currently Borrowed.");
            }
            Console.WriteLine("The bookmark is on page: " + myBook.getBookMark());
            Console.WriteLine("Name of Chapter 2: " + myBook.getChapter(2));

            Console.WriteLine("Name of Chapter 10: " + myBook.getChapter(10));
        }
    }
}