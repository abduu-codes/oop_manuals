using System.Collections.Generic;

namespace challenge3
{
    public class WorkoutRoutine
    {
        public string routineName;
        public List<Exercise> exercises = new List<Exercise>();

        public WorkoutRoutine(string name) 
        { this.routineName = name; 
        }
    }
}