using System;
class Astronaut
{
    public string Name;
    public int Oxygen;
    public int Stamina;
    public bool IsConscious;
    public Astronaut(string name)
    {
        Name = name;
        Oxygen = 100;
        Stamina = 60;
        IsConscious = true;
    }
}
class Program
{
    static void Main()
    {
        Astronaut[] team = new Astronaut[4];
        team[0] = new Astronaut("Ali");
        team[1] = new Astronaut("Sara");
        team[2] = new Astronaut("Ahmed");
        team[3] = new Astronaut("Zara");

        Random rng = new Random();

        Console.WriteLine("--- SPACE MISSION START ---");
        for (int cycle = 1; cycle <= 10; cycle++)
        {
            Console.WriteLine("\nCycle " + cycle);

            foreach (Astronaut a in team)
            {
               
                if (a.IsConscious == false) continue;
                int eventRoll = rng.Next(1, 6);

                if (eventRoll == 1) // Oxygen Refill
                {
                    a.Oxygen += 15;
                    Console.WriteLine(a.Name + " refilled oxygen (+15)");
                }
                else if (eventRoll == 2) // Meteor Hit
                {
                    a.Oxygen -= 25;
                    Console.WriteLine(a.Name + " hit by meteor! (-25 Oxy)");
                }
                else if (eventRoll == 3) // Short Break
                {
                    a.Stamina += 10;
                    Console.WriteLine(a.Name + " took a break (+10 Stamina)");
                }
                else if (eventRoll == 4) // Equipment Failure
                {
                    a.Stamina -= 15;
                    Console.WriteLine(a.Name + " equipment failed! (-15 Stamina)");
                }
                else // Smooth Cycle (eventRoll 5)
                {
                    Console.WriteLine(a.Name + " had a smooth cycle.");
                }

                if (a.Oxygen <= 0)
                {
                    a.Oxygen = 0;
                    a.IsConscious = false;
                    Console.WriteLine("!!! " + a.Name + " is now UNCONSCIOUS !!!");
                }
            }
        }
        Console.WriteLine("\n--- MISSION ENDED ---");
        Astronaut winner = team[0];
        foreach (Astronaut a in team)
        {
            string status = a.IsConscious ? "Conscious" : "Unconscious";
            Console.WriteLine(a.Name + " -> Oxygen: " + a.Oxygen + " | Status: " + status);
            if (a.Oxygen > winner.Oxygen)
            {
                winner = a;
            }
        }
        Console.WriteLine("\nWinner (Highest Oxygen): " + winner.Name);
    }
}