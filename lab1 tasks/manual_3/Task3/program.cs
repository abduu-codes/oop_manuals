using System;
class Program {
    static void Main() {
        int numb, sum = 0;
        Console.WriteLine("enter a number");
        numb = Convert.ToInt32(Console.ReadLine());
        do {
            sum = sum + numb;
            Console.WriteLine("enter a number");
            numb = Convert.ToInt32(Console.ReadLine());
        } while (numb != -1);
        Console.WriteLine(sum);
    }
}