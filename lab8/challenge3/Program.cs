using System;

namespace challenge3

{
    public class Person
    {
        protected string name;
        protected string address;

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public string getName()
        {
            return name;
        }
        public string getAddress()
        {
            return address;
        }
        public void setAddress(string address)

        {
            this.address = address;
        }

        public string toString()
        {
            return "Person[name=" + name + ",address=" + address + "]";
        }
    }

    public class Student : Person
    {
        protected string program;
        protected int year;
        protected double fee;

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }

        public string getProgram()
        {
            return program;
        }

        public void setProgram(string program)
        {
            this.program = program;
        }
        public int getYear()
        {
            return year;
        }
        public void setYear(int year)
        {
            this.year = year;
        }
        public double getFee()
        {
            return fee;
        }
        public void setFee(double fee)
        {
            this.fee = fee;
        }
    }

    public class Staff : Person
    {
        protected string school;
        protected double pay;

        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            this.school = school;
            this.pay = pay;
        }

        public string getSchool()
        {
            return school;
        }
        public void setSchool(string school)
        {
            this.school = school;
        }
        public double getPay() { return pay; }
        public void setPay(double pay) { this.pay = pay; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student("Ali", "Lahore", "Computer Science", 2023, 45000);
            Staff stf = new Staff("Mr. Khan", "Islamabad", "UET", 75000);

            Console.WriteLine(std.toString());
            Console.WriteLine("Student Program: " + std.getProgram());

            Console.WriteLine(stf.toString());
            Console.WriteLine("Staff Pay: " + stf.getPay());

            Console.ReadKey();
        }
    }
}