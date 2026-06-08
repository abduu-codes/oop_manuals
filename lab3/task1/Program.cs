using System;


class Character
{
    public string Name;
    public int Health;
    public int Attack;
    public Character(string n, int h, int a)
    {
        Name = n;
        Health = h;
        Attack = a;
    }
    public Character(Character c)
    {
        this.Name = "Clone of " + c.Name;
        this.Health = c.Health;
        this.Attack = c.Attack;
    }
}

class Program
{
    static void Main()
    {
        Character hero = new Character("Warrior", 100, 15);
        Character clone = new Character(hero);
        Console.WriteLine("Battle Starts!");
        Console.WriteLine(hero.Name + " vs " + clone.Name);

        while (hero.Health > 0 && clone.Health > 0)
        {
            clone.Health = clone.Health - hero.Attack;
            
            hero.Health = hero.Health - clone.Attack;

            Console.WriteLine("Hero Health: " + hero.Health + " | Clone Health: " + clone.Health);
        }
        if (hero.Health > 0)
        {
            Console.WriteLine("The original Hero won!");
        }
        else
        {
            Console.WriteLine("The Clone won!");
        }
    }
}