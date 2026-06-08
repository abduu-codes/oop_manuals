using System;
using System.Collections.Generic;

namespace challenge4
{
    class Program
    {
        static List<Student> studentList = new List<Student>();
        static List<DegreeProgram> programList = new List<DegreeProgram>();

        static void Main(string[] args)
        {
            int option = 0;
            while (option != 8)
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Degree Program");
                Console.WriteLine("3. Generate Merit");
                Console.WriteLine("4. View Registered Students");
                Console.WriteLine("5. View Students of a Specific Program");
                Console.WriteLine("6. Register Subjects for a Student");
                Console.WriteLine("7. Calculate Fees for all Registered Students");
                Console.WriteLine("8. Exit");
                Console.Write("Enter Option: ");
                option = int.Parse(Console.ReadLine());

                if (option == 1)
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
                    for (int i = 0; i < programList.Count; i++)
                    {
                        Console.WriteLine($"{i}. {programList[i].title}");
                    }

                    Console.Write("How many preferences? ");
                    int count = int.Parse(Console.ReadLine());
                    List<DegreeProgram> prefs = new List<DegreeProgram>();
                    for (int x = 0; x < count; x++)
                    {
                        Console.Write("Enter program index: ");
                        int idx = int.Parse(Console.ReadLine());
                        prefs.Add(programList[idx]);
                    }

                    studentList.Add(new Student(name, age, fsc, ecat, prefs));
                }
                else if (option == 2)
                {
                    Console.Write("Enter Degree Name: ");
                    string dName = Console.ReadLine();
                    Console.Write("Enter Duration: ");
                    string dur = Console.ReadLine();
                    Console.Write("Enter Seats: ");
                    int seats = int.Parse(Console.ReadLine());

                    DegreeProgram dp = new DegreeProgram(dName, dur, seats);

                    Console.Write("How many subjects to add to this degree? ");
                    int sCount = int.Parse(Console.ReadLine());
                    for (int i = 0; i < sCount; i++)
                    {
                        Console.Write("Enter Subject Code: ");
                        string code = Console.ReadLine();
                        Console.Write("Enter Credit Hours: ");
                        int ch = int.Parse(Console.ReadLine());
                        Console.Write("Enter Type: ");
                        string type = Console.ReadLine();
                        Console.Write("Enter Fees: ");
                        int fee = int.Parse(Console.ReadLine());
                        dp.addSubject(new Subject(code, ch, type, fee));
                    }
                    programList.Add(dp);
                }
                else if (option == 3)
                {
                    foreach (Student s in studentList)
                    {
                        s.calculateMerit();
                    }

                }
                else if (option == 4)
                {
                    foreach (Student s in studentList)
                    {
                        Console.WriteLine($"Name: {s.name}, Age: {s.age}, Merit: {s.merit}");
                    }
                }
                else if (option == 5)
                {
                    Console.Write("Enter Program Name: ");
                    string pName = Console.ReadLine();
                    foreach (Student s in studentList)
                    {
                        if (s.regDegree != null && s.regDegree.title == pName)
                        {
                            Console.WriteLine($"Name: {s.name}, Age: {s.age}, Merit: {s.merit}");
                        }
                        else
                        {
                            Console.WriteLine("No students registered in this program.");
                        }
                    }
                }
                else if (option == 6) 
                {
                    Console.Write("Enter exact Student Name: ");
                    string searchName = Console.ReadLine();


                    Student targetStudent = null;
                    foreach (Student s in studentList)
                    {
                        if (s.name == searchName)
                        {
                            targetStudent = s;
                            break;
                        }
                    }

                    if (targetStudent != null)
                    {
                        Console.Write("Enter Subject Code to register: ");
                        string searchCode = Console.ReadLine();
                        Subject targetSubject = null;
                        foreach (DegreeProgram dp in programList)
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
                            if (currentCredits + targetSubject.creditHours <= 10)
                            { 
                                targetStudent.regSubjects.Add(targetSubject);
                                Console.WriteLine($"Success! '{targetSubject.code}' has been registered for {targetStudent.name}.");
                            }
                            else
                            {
                                Console.WriteLine($"Error: Adding this subject exceeds the 9 credit hour limit. (Currently at {currentCredits} hours).");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error: Subject Code not found in the system.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Student not found.");
                    }
                }

                else if (option == 7)
                {
                    foreach (Student s in studentList)
                    {
                        if (s.regDegree != null)
                        {
                            int fee = s.calculateFee();
                            Console.WriteLine($"Student: {s.name}, Total Fees: {fee}");
                        }
                        else
                        {
                            Console.WriteLine("Student not registered in any degree program.");
                        }
                    }
                }
            }
        }
    }
}