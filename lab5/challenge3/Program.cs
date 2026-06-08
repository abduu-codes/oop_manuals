using System;

namespace challenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            while ((option = UI.Menu()) != 8)
            {
                if (option == 1)
                {
                    Student s = StudentUI.takeStudentInput();
                    StudentDL.addStudent(s);
                }
                else if (option == 2) 
                {
                    DegreeProgram dp = DegreeProgramUI.takeDegreeInput();
                    DegreeProgramDL.addDegreeProgram(dp);
                }
                else if (option == 3) 
                { 
                    foreach (Student s in StudentDL.studentList)
                    {
                        s.calculateMerit();
                    }
                    System.Console.WriteLine("Merit calculated for all students.");
                }
                else if (option == 4) 
                {
                    StudentUI.viewAllStudents();
                }
                else if (option == 5)
                {
                    StudentUI.viewStudentsOfProgram();
                }
                else if (option == 6) 
                {
                    StudentUI.registerSubjects();
                }
                else if (option == 7)
                {
                    StudentUI.calculateFees();
                }
            }
        }
    }
}