using System;
using System.Collections.Generic;
    public class DegreeProgram
    {
        public string title;
        public string duration;
        public List<Subject> subjects;
        public int seats;

        public DegreeProgram(string title, string duration, int seats)
        {
            this.title = title;
            this.duration = duration;
            this.seats = seats;
            subjects = new List<Subject>();
        }

        public bool addSubject(Subject s)
        {
            int totalHours = calculateCreditHours();
            if (totalHours + s.creditHours <= 20)
            {
                subjects.Add(s);
                return true;
            }
            return false;
        }

        public int calculateCreditHours()
        {
            int count = 0;
            foreach (Subject s in subjects)
            {
                count += s.creditHours;
            }
            return count;
        }
    }
