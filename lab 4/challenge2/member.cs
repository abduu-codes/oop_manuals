using System;
using System.Collections.Generic;
public class Member
{
    public string name;
    public int memberID;
    public List<string> booksBought; 
    public int numberOfBooksBought;
    public float moneyInBank;
    public float amountSpent;

    public Member(string mName, int mID, float startingMoney)
    {
        name = mName;
        memberID = mID;
        moneyInBank = startingMoney;
        booksBought = new List<string>();
        numberOfBooksBought = 0;
        amountSpent = 0.0f;
    }
    public void ShowName()
    {
        Console.WriteLine("Member Name: " + name);
    }

    public void SetName(string newName)
    {
        name = newName;
        Console.WriteLine("Name updated successfully.");
    }
    public void ShowStats()
    {
        Console.WriteLine($"\n--- Stats for {name} (ID: {memberID}) ---");
        Console.WriteLine($"Total Books Bought: {numberOfBooksBought}");
        Console.WriteLine($"Total Amount Spent: ${amountSpent}");
        Console.WriteLine($"Remaining Money in Bank: ${moneyInBank}");

        Console.WriteLine("Books Owned:");
        if (numberOfBooksBought == 0)
        {
            Console.WriteLine("- None yet.");
        }
        else
        {
            for (int i = 0; i < booksBought.Count; i++)
            {
                Console.WriteLine("- " + booksBought[i]);
            }
        }
        Console.WriteLine("----------------------------------");
    }
    public void BuyBook(string bookTitle, float cost)
    {
        if (moneyInBank >= cost)
        {
            booksBought.Add(bookTitle);
            numberOfBooksBought++;
            amountSpent = amountSpent + cost;
            moneyInBank = moneyInBank - cost;

            Console.WriteLine($"Successfully purchased '{bookTitle}' for ${cost}.");
        }
        else
        {
            Console.WriteLine($"Transaction Failed: Not enough money in bank to buy '{bookTitle}'.");
        }
    }
}