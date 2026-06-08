using System;

public class Member
{
    public string name;
    public int memberID;
    public int numberOfBooksBought;
    public float amountSpent;
    public float lastTenBooksTotal;

    public Member(string n, int id)
    {
        name = n;
        memberID = id;
        numberOfBooksBought = 0;
        amountSpent = 0.0f;
        lastTenBooksTotal = 0.0f;
    }

    public void ShowMemberDetails()
    {
        string status = (memberID == 0) ? "Non-Member" : "Official Member";
        Console.WriteLine($"Name: {name} | ID: {memberID} ({status}) | Books Bought: {numberOfBooksBought} | Total Spent: ${amountSpent}");
    }
}