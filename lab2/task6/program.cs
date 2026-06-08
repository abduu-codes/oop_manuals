using System;
using System.IO;



public class MUser
{
    public string Username;
    public string Password;
    public string Role;

    // constructor
    public MUser(string role)
    {

        Role = role;
    }
    public void Signupadmin(string username, string password)
    {
        string path = "E:\oop\ooplab2\lab2\task6\\admin.txt";
        StreamWriter fl = new StreamWriter(path, true);
        fl.WriteLine(username + " " + password);
        fl.Flush();
        fl.Close();
    }
    public void Signinadmin(string uname, string pword)
    {
        string path = "E:\oop\ooplab2\lab2\task6\\admin.txt";
        StreamReader fr = new StreamReader(path);

        string line;
        bool found = false;
        while ((line = fr.ReadLine()) != null)
        {
            string[] parts = new string[2];
            parts = line.Split(' ');

            string fileUser = parts[0];
            string filePass = parts[1];
            if (uname == fileUser && pword == filePass)
            {
                found = true;
            }
                if (found)
                    Console.WriteLine("Login Successful");
                else
                    Console.WriteLine("Invalid credentials");
        }

        fr.Close();
    }
    public void Signupcustomer(string username, string password)
    {
        string path = "E:\oop\ooplab2\lab2\task6\\customer.txt";
        StreamWriter ufl = new StreamWriter(path, true);
        ufl.WriteLine(username + " " + password);
        ufl.Flush();
        ufl.Close();
    }

    public void Signincustomer(string uname, string pword)
    {
        string path = "E:\oop\ooplab2\lab2\task6\\customer.txt";
        StreamReader ufr = new StreamReader(path);

        string line;
        bool found = false;
        while ((line = ufr.ReadLine()) != null)
        {
            string[] parts = new string[2];
            parts = line.Split(' ');

            string fileUser = parts[0];
            string filePass = parts[1];
            if (uname == fileUser && pword == filePass)

                found = true;


        }
        if (found)
            Console.WriteLine("Login Successful");
        else
            Console.WriteLine("Invalid credentials");
        ufr.Close();



    }

    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n*******************************");
                Console.WriteLine("       MAIN LOGIN SYSTEM       ");
                Console.WriteLine("*******************************");
                Console.WriteLine("Enter role (admin / customer) or 'exit':");
                string role = Console.ReadLine();

                if (role == "exit") break;

                MUser u = new MUser(role);

                // --- ADMIN SECTION ---
                if (role == "admin" || role == "Admin")
                {
                    Console.WriteLine("\n--- ADMIN MENU ---");
                    Console.WriteLine("1. Signup");
                    Console.WriteLine("2. Signin");
                    Console.WriteLine("3. Back");
                    Console.Write("Choice: ");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        Console.Write("New Admin Username: ");
                        string un = Console.ReadLine();
                        Console.Write("New Admin Password: ");
                        string up = Console.ReadLine();
                        u.Signupadmin(un, up);
                        Console.WriteLine(">> Admin Registered!");
                    }
                    else if (choice == "2")
                    {
                        Console.Write("Username: ");
                        string name = Console.ReadLine();
                        Console.Write("Password: ");
                        string pass = Console.ReadLine();
                        u.Signinadmin(name, pass);
                    }
                    else
                    {
                        Console.Clear();
                        continue;
                    }
                }

                else if (role == "customer" || role == "Customer")
                {
                    Console.WriteLine("\n--- CUSTOMER MENU ---");
                    Console.WriteLine("1. Signup");
                    Console.WriteLine("2. Signin");
                    Console.WriteLine("3. Back");
                    Console.Write("Choice: ");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        Console.Write("New Customer Username: ");
                        string cu = Console.ReadLine();
                        Console.Write("New Customer Password: ");
                        string cp = Console.ReadLine();
                        u.Signupcustomer(cu, cp);
                        Console.WriteLine(">> Customer Registered!");
                    }
                    else if (choice == "2")
                    {
                        Console.Write("Username: ");
                        string cname = Console.ReadLine();
                        Console.Write("Password: ");
                        string cpass = Console.ReadLine();
                        u.Signincustomer(cname, cpass);
                    }
                    else
                    {
                        Console.Clear();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid role! Please enter 'admin' or 'customer'.");
                }
            }
        }
    }
}