
using System;

namespace challenge3

{
    class Program
    {
        static void Main(string[] args)
        {
            
            WorkoutRoutine strengthRoutine = new WorkoutRoutine("Strength Training");
            Exercise benchPress = new Exercise("Bench Press");

            benchPress.AddSet(12, 40.5f);
            benchPress.AddSet(10, 50.0f);
            benchPress.AddSet(8, 60.0f);

            strengthRoutine.exercises.Add(benchPress);

            FitnessUI.PrintRoutine(strengthRoutine);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}