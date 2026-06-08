using System;
using System.IO;
class Program {
    static void Main() {
        string path = "E:\\oop\\Assignments\\lab1 tasks\\manual_4\\Task2program.txt";
        if (File.Exists(path)) {
            StreamReader sr = new StreamReader(path);
            string record;
            while ((record = sr.ReadLine()) != null) Console.WriteLine(record);
            sr.Close();
        } else Console.WriteLine("File not found");
    }
}