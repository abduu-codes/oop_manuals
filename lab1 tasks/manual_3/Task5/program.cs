using System;
class Program {
    static void Main() {
        int money = 0, age, machineprice, toyprice;
        Console.WriteLine("Enter age:");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter toy price:");
        toyprice = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= age; i++) {
            if (i % 2 == 0) { money += 10 * (i / 2); money--; }
            else money += toyprice;
        }
        Console.WriteLine("Enter machine price:");
        machineprice = Convert.ToInt32(Console.ReadLine());
        if (machineprice > money) Console.WriteLine("Not enough money");
        else {
            Console.WriteLine("enough money");
            Console.WriteLine(money - machineprice);
        }
    }
}