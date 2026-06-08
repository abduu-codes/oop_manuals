using System;

namespace challenge1
{
    public class LineUI
    {
        public static int Menu()
        {
            Console.WriteLine("\n=== Line and Point Menu ===");
            Console.WriteLine("1. Make a Line");
            Console.WriteLine("2. Update the begin point");
            Console.WriteLine("3. Update the end point");
            Console.WriteLine("4. Show the begin point");
            Console.WriteLine("5. Show the end point");
            Console.WriteLine("6. Get the Length of the line");
            Console.WriteLine("7. Get the Gradient of the Line");
            Console.WriteLine("8. Find the distance of begin point from zero coordinates");
            Console.WriteLine("9. Find the distance of end point from zero coordinates");
            Console.WriteLine("10. Exit");
            Console.Write("Enter choice: ");
            return int.Parse(Console.ReadLine());
        }

        public static MyPoint TakePointInput(string pointType)
        {
            Console.Write($"Enter {pointType} point x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write($"Enter {pointType} point y: ");
            int y = int.Parse(Console.ReadLine());
            return new MyPoint(x, y);
        }

        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void DisplayPoint(string pointType, MyPoint p)
        {
            Console.WriteLine($"{pointType} Point: ({p.getX()}, {p.getY()})");
        }

        public static void DisplayResult(string metric, double result)
        {
            Console.WriteLine($"{metric}: {result:F2}");
        }
    }
}