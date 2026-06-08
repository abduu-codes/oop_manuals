using System.Collections.Generic;

namespace challenge3
{
    public class StudentDL
    {
        public static List<Student> studentList = new List<Student>();

        public static void addStudent(Student s)
        {
            studentList.Add(s);
        }

        public static Student StudentExists(string searchName)
        {
            foreach (Student s in studentList)
            {
                if (s.name == searchName)
                {
                    return s;
                }
            }
            return null;
        }
    }
}