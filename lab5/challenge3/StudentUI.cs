using System;
using System.Collections.Generic;
namespace challenge3
{
    public class StudentUI
    {
        public static Student takeStudentInput()
        {
            Console.Write("Enter Student Name: "); 
            string name = Console.ReadLine();
            Console.Write("Enter Student Age: "); 
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter FSc Marks: "); 
            double fsc = double.Parse(Console.ReadLine());
            Console.Write("Enter Ecat Marks: "); 
            double ecat = double.Parse(Console.ReadLine());

            Console.WriteLine("Available Degree Programs:");
            for (int i = 0; i < DegreeProgramDL.programList.Count; i++)
            {
                Console.WriteLine($"{i}. {DegreeProgramDL.programList[i].title}");
            }

            Console.Write("How many preferences? ");
            int count = int.Parse(Console.ReadLine());
            List<DegreeProgram> prefs = new List<DegreeProgram>();
            for (int x = 0; x < count; x++)
            {
                Console.Write("Enter program index: ");
                int idx = int.Parse(Console.ReadLine());
                prefs.Add(DegreeProgramDL.programList[idx]);
            }

            return new Student(name, age, fsc, ecat, prefs);
        }

        public static void viewAllStudents()
        {
            foreach (Student s in StudentDL.studentList)
            {
                Console.WriteLine($"Name: {s.name}, Age: {s.age}, Merit: {s.merit}");
            }
        }

        public static void viewStudentsOfProgram()
        {
            Console.Write("Enter Program Name: ");
            string pName = Console.ReadLine();
            bool found = false;

            foreach (Student s in StudentDL.studentList)
            {
                if (s.regDegree != null && s.regDegree.title == pName)
                {
                    Console.WriteLine($"Name: {s.name}, Age: {s.age}, Merit: {s.merit}");
                    found = true;
                }
            }
            if (!found) Console.WriteLine("No students registered in this program.");
        }

        public static void registerSubjects()
        {
            Console.Write("Enter exact Student Name: ");
            string searchName = Console.ReadLine();
            Student targetStudent = StudentDL.StudentExists(searchName);

            if (targetStudent != null)
            {
                Console.Write("Enter Subject Code to register: ");
                string searchCode = Console.ReadLine();
                Subject targetSubject = null;
                
                foreach (DegreeProgram dp in DegreeProgramDL.programList)
                {
                    foreach (Subject sub in dp.subjects)
                    {
                        if (sub.code == searchCode)
                        {
                            targetSubject = sub;
                            break;
                        }
                    }
                    if (targetSubject != null) 
                        break;
                }

                if (targetSubject != null)
                {
                    int currentCredits = targetStudent.getCreditHours();

                    if (currentCredits + targetSubject.creditHours <= 9)
                    {
                        targetStudent.regSubjects.Add(targetSubject);
                        Console.WriteLine($"Success! '{targetSubject.code}' has been registered for {targetStudent.name}.");
                    }
                    else
                    {
                        Console.WriteLine($"Error: Adding this subject exceeds the 9 credit hour limit. (Currently at {currentCredits} hours).");
                    }
                }
                else Console.WriteLine("Error: Subject Code not found in the system.");
            }
            else Console.WriteLine("Error: Student not found.");
        }

        public static void calculateFees()
        {
            foreach (Student s in StudentDL.studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine($"Student: {s.name}, Total Fees: {s.calculateFee()}");
                }
                else
                {
                    Console.WriteLine($"Student {s.name} is not registered in any degree program.");
                }
            }
        }
    }
}