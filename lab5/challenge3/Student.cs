using System.Collections.Generic;

namespace challenge3
{
    public class Student
    {
        public string name;
        public int age;
        public double fscMarks;
        public double ecatMarks;
        public double merit;
        public List<DegreeProgram> preferences;
        public List<Subject> regSubjects;
        public DegreeProgram regDegree;

        public Student(string name, int age, double fscMarks, double ecatMarks, List<DegreeProgram> preferences)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.preferences = preferences;
            regSubjects = new List<Subject>();
            calculateMerit();
        }

        public void calculateMerit()
        {
            this.merit = (((fscMarks / 1100) * 0.45) + ((ecatMarks / 400) * 0.55)) * 100;
        }

        public int getCreditHours()
        {
            int count = 0;
            foreach (Subject s in regSubjects)
            {
                count += s.creditHours;
            }
            return count;
        }

        public int calculateFee()
        {
            int fee = 0;
            foreach (Subject s in regSubjects)
            {
                fee += s.subjectFees;
            }
            return fee;
        }
    }
}