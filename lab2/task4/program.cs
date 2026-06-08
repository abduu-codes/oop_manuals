 using System;
using System.Collections.Generic;
class Student
{
    public string Name;
    public double Marks;
    public Student(string name, double marks)
    {
        Name = name;
        Marks = marks;
    }
}

class Program
{
    static void Main()
    {

        List<Student> students = new List<Student>();

        while (true)
        {

            Console.WriteLine("\n--- STUDENT SYSTEM ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Show All Students");
            Console.WriteLine("3. Find Top Student");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Marks: ");
                double marks = double.Parse(Console.ReadLine());

                Student newStudent = new Student(name, marks);
                students.Add(newStudent);
                Console.WriteLine("Student added successfully!");
                Console.Clear();
            }
            else if (choice == "2")
            {

                Console.WriteLine("\nList of Students:");
                foreach (Student s in students)
                {
                    Console.WriteLine("Name: " + s.Name + ", Marks: " + s.Marks);
                }
                Console.Clear();
            }
            else if (choice == "3")
            {
                if (students.Count == 0)
                {
                    Console.WriteLine("No students in the list.");
                }
                else
                {

                    Student topStudent = students[0];

                    foreach (Student s in students)
                    {

                        if (s.Marks > topStudent.Marks)
                        {
                            topStudent = s;
                        }
                    }
                    Console.WriteLine("The Top Student is: " + topStudent.Name + " with " + topStudent.Marks + " marks.");

                }

                Console.Clear();
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("wrong coice");
            }
        }
    }
}