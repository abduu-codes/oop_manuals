using System;
using System.IO;

class Program {
    static void Main() {
        string path = "E:\\oop\\Assignments\\lab1 tasks\\manual_4\\task5\\users.txt";
        string[] names = new string[10];
        string[] passwords = new string[10];
        int count = 0;

        int option;
        do {
            Console.WriteLine("1. SignIn\n2. SignUp\n3. Exit");
            option = int.Parse(Console.ReadLine());

            if (option == 1) { 
               
                count = 0;
                if (File.Exists(path)) {
                    StreamReader reader = new StreamReader(path);
                    string record;
                    while ((record = reader.ReadLine()) != null) 
                    {
                        names[count] = parse(record, 1);
                        passwords[count] = parse(record, 2);
                        count++;
                    }
                    reader.Close();
                }
                Console.Write("Enter Name: ");
                string n = Console.ReadLine();
                Console.Write("Enter Password: ");
                string p = Console.ReadLine();
                bool found = false;
                for (int i = 0; i < count; i++) {
                    if (n == names[i] && p == passwords[i]) {
                        Console.WriteLine("Login Successful!");
                        found = true;
                        break;
                    }
                }
                if (!found) Console.WriteLine("Invalid Credentials!");
            } else if (option == 2) { 
                Console.Write("Enter Name: ");
                string n = Console.ReadLine();
                Console.Write("Enter Password: ");
                string p = Console.ReadLine();
                StreamWriter writer = new StreamWriter(path, true);
                writer.WriteLine(n + " " + p); 
                writer.Flush();
                writer.Close();
                Console.WriteLine("Signed Up Successfully!");
            }
        } while (option != 3);
    }
}