using System;

namespace challenge3
{
    public class FitnessUI
    {
        public static void PrintRoutine(WorkoutRoutine wr)
        {
            Console.WriteLine($"\nRoutine: {wr.routineName}");
            foreach (var ex in wr.exercises)
            {
                Console.WriteLine($" Exercise: {ex.name}");
                for (int i = 0; i < ex.sets.Count; i++)
                    Console.WriteLine($"  Set {i + 1}: {ex.sets[i].reps} reps @ {ex.sets[i].weight}kg");
            }
        }
    }
}