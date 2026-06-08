using System.Collections.Generic;

namespace challenge3

{
    public class DegreeProgram
    {
        public string title;
        public string duration;
        public int seats;
        public List<Subject> subjects;

        public DegreeProgram(string title, string duration, int seats)
        {
            this.title = title;
            this.duration = duration;
            this.seats = seats;
            subjects = new List<Subject>();
        }

        public void addSubject(Subject s)
        {
            subjects.Add(s);
        }
    }
}