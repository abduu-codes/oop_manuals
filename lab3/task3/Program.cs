using System;

class ClockType
{
    public int Hours;
    public int Minutes;
    public int Seconds;
    public ClockType(int h, int m, int s)
    {
        Hours = h;
        Minutes = m;
        Seconds = s;
    }
    public void DisplayTime()
    {
        Console.WriteLine(Hours.ToString("D2") + ":" +
                          Minutes.ToString("D2") + ":" +
                          Seconds.ToString("D2"));
    }

    public int CalculateElapsedSeconds()
    {
        return (Hours * 3600) + (Minutes * 60) + Seconds;
    }    
    public int CalculateRemainingSeconds()
    {
        int totalInDay = 86400; 
        return totalInDay - CalculateElapsedSeconds();
    }
    public int GetDifference(ClockType otherClock)
    {
        int seconds1 = this.CalculateElapsedSeconds();
        int seconds2 = otherClock.CalculateElapsedSeconds();
        return Math.Abs(seconds1 - seconds2);
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("--- CLOCK ANALYZER STARTED ---");
        ClockType clock1 = new ClockType(9, 15, 20);
        ClockType clock2 = new ClockType(14, 40, 10);
        ClockType clock3 = new ClockType(22, 10, 5);
        Console.Write("Clock 1 -> ");
        clock1.DisplayTime();
        Console.WriteLine("Elapsed Seconds: " + clock1.CalculateElapsedSeconds());
        Console.WriteLine("Remaining Seconds: " + clock1.CalculateRemainingSeconds());
        Console.Write("\nClock 2 -> ");
        clock2.DisplayTime();
        Console.WriteLine("Difference with Clock 1: " + clock2.GetDifference(clock1) + " seconds");
        Console.Write("\nClock 3 -> ");
        clock3.DisplayTime();
        Console.WriteLine("Remaining Seconds: " + clock3.CalculateRemainingSeconds());
        Console.WriteLine("\n--- ANALYSIS COMPLETE ---");
    }
}