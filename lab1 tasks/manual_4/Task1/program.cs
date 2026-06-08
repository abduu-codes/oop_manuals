using System;
class Program {
    static int C(int a, int b) { return a + b; }
    static void Main() {
        Console.WriteLine("enter first number");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter second number");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("the sum is " + C(a, b));
    }
}