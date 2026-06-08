using System;
using System.IO;
class Program {
    static void Main() {
        string path = "E:\\oop\\Assignments\\lab1 tasks\\manual_4\\Task4\\program.txt";
        StreamWriter file = new StreamWriter(path, true);
        file.WriteLine("hello");
        file.Flush();
        file.Close();
        Console.ReadKey();
    }
}