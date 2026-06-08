using System;

namespace challenge3
{
    public class UI
        
    {
        public static int Menu()
        {
            Console.WriteLine("\n--- UAMS Menu ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate Merit");
            Console.WriteLine("4. View Registered Students");
            Console.WriteLine("5. View Students of a Specific Program");
            Console.WriteLine("6. Register Subjects for a Student");
            Console.WriteLine("7. Calculate Fees for all Registered Students");
            Console.WriteLine("8. Exit");
            Console.Write("Enter Option: ");
            return int.Parse(Console.ReadLine());
        }
    }
}