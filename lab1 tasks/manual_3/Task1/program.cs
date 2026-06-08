using System;
class Program {
    static void Main() {
        int marks;
        Console.WriteLine("enter marks");
        marks = Convert.ToInt32(Console.ReadLine());
        if (marks >= 50) Console.WriteLine("pass");
        else Console.WriteLine("fail");
        Console.ReadKey();
    }
}