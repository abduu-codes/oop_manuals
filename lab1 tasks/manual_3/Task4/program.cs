using System;
class Program {
    static void Main() {
        int[] array = new int[3];
        for (int i = 0; i < array.Length; i++) {
            Console.WriteLine("Enter a number:");
            array[i] = int.Parse(Console.ReadLine());
        }
        int largest = array[0];
        for (int i = 0; i < array.Length; i++) {
            if (array[i] > largest) largest = array[i];
        }
        Console.WriteLine("The largest number is: " + largest);
        Console.ReadKey();
    }
}