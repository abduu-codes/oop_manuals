using System;

namespace problemstatement1
{
    class Student
    {
        public string name;
        public int rollNumber;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public string homeTown;
        public bool isHostelite;
        public bool isTakingScholarship;
        public Student(string sName, int sRoll, float sMatric, float sFsc, float sEcat, string sTown, bool sHostel)
        {
            name = sName;
            rollNumber = sRoll;
            matricMarks = sMatric;
            fscMarks = sFsc;
            ecatMarks = sEcat;
            homeTown = sTown;
            isHostelite = sHostel;
            isTakingScholarship = false;
        }

        public double calculateMerit()
        {

            double merit = (((fscMarks/1200) * 0.3) + ((ecatMarks/400) * 0.5) + ((matricMarks/1100) * 0.2)) * 100;

            return merit;
        }
        public bool isEligibleforScholarship(double meritPercentage)
        {
            if (meritPercentage > 80 && isHostelite == true)
            {
                isTakingScholarship = true;
                return true;
            }
            else
            {
                isTakingScholarship = false;
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Ali", 1, 1010, 1070, 370, "Lahore", true);

            double aliMerit = s1.calculateMerit();
            Console.WriteLine("Student Name: " + s1.name);
            Console.WriteLine("Merit Percentage: " + aliMerit + "%");

            bool getsScholarship = s1.isEligibleforScholarship(aliMerit);

            if (getsScholarship == true)
            {
                Console.WriteLine(s1.name + " is eligible for the scholarship!");
            }
            else
            {
                Console.WriteLine(s1.name + " is NOT eligible for the scholarship.");
            }
        }
    }
}