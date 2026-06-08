using System;
class Program {
    static void Main() {
        float area, side;
        Console.WriteLine("Enter the side of the square:");
        side = float.Parse(Console.ReadLine());
        area = side * side;
        Console.WriteLine(area);
        Console.ReadKey();
    }
}