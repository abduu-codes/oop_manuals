
using System;
namespace challenge3
{
    public class DegreeProgramUI
    {
        public static DegreeProgram takeDegreeInput()
        {
            Console.Write("Enter Degree Name: "); string dName = Console.ReadLine();
            Console.Write("Enter Duration: "); string dur = Console.ReadLine();
            Console.Write("Enter Seats: "); int seats = int.Parse(Console.ReadLine());

            DegreeProgram dp = new DegreeProgram(dName, dur, seats);

            Console.Write("How many subjects to add to this degree? ");
            int sCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < sCount; i++)
            {
                Console.Write("Enter Subject Code: "); 
                string code = Console.ReadLine();
                Console.Write("Enter Credit Hours: "); 
                int ch = int.Parse(Console.ReadLine());
                Console.Write("Enter Type: "); 
                string type = Console.ReadLine();
                Console.Write("Enter Fees: "); 
                int fee = int.Parse(Console.ReadLine());

                dp.addSubject(new Subject(code, ch, type, fee));
            }
            return dp;
        }
    }
}