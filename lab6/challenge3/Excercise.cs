using System.Collections.Generic;

namespace challenge3

{
    public class Exercise
    {
        public string name;
        public List<Set> sets = new List<Set>();

        public Exercise(string name) 
        { this.name = name; }
        public void AddSet(int r, float w)
        {
            sets.Add(new Set(r, w));
        }
    }
}