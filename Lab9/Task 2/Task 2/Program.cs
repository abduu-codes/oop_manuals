using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class person
    {
        private string name;
        private string address;
        public person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public string getname()
        {
            return name;
        }
     
        public string getddress()
        {
            return address;
        }
        public void setaddress(string address)
        {
            this.address = address;
        }
        public virtual string tostring()
        {
            return $" person : Name={name},Address={address}";
        }
    }
    class student : person
    {
        private string program;
        private int year;
        private double fee;
        public student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }
        public string getprogram()
        {
            return program;
        }
        public void setprogram(string program)
        {
            this.program = program;
        }
        public int getyear()
        {
            return year;
        }
        public void setyear(int year)
        {
            this.year = year;
        }
        public double getfee()
        {
            return fee;
        }
        public void setfee(double fee)
        {
            this.fee = fee;
        }
        public override string tostring()
        {
            return "Student=" + base.tostring() + ",Program=" + program + ",Fee=" + fee + ",Year=" + year;
        }

    }
    class staff : person
    {
        private string school;
        private double pay;
        public staff(string name, string address, string school, double pay) : base(name, address)
        {
            this.school = school;
            this.pay = pay;
        }
        public string getschool()
        {
            return school;
        }
        public void setschool(string scholl)
        {
            this.school = scholl;
        }
        public double getpay()
        {
            return pay;
        }
        public void setpay(double pay)
        {
            this.pay = pay;
        }
        public override string tostring()
        {
            return "Staff=" + base.tostring() + ",School="+school+",Pay="+pay;
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            person p1 = new person("Abdullah", "Iqbal Town");
            Console.WriteLine(p1.getname());
            p1.setaddress("Ali Towm");
            Console.WriteLine(p1.getddress());
            Console.WriteLine(p1.tostring());
            student s1 = new student("Abdullah", "Iqbal Town","CS", 2025, 3000);
            s1.setyear(2026);
            Console.WriteLine(s1.tostring());
            staff s = new staff("Hassan", "Salhudin", "Sublime", 20000);
            s.setschool("UET");
            Console.WriteLine(s.tostring());

        }
    }
}
