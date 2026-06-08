using System;

namespace Task_3
{
    class animal
    {
        private string name;
        public animal(string name)
        {
            this.name = name;
        }
        public virtual string tostring()
        {
            return $"animal : Name =  {name}";
        }

    }
    class mammal : animal
    {
        public mammal(string name) : base(name)
        {

        }
        public override string tostring()
        {
            return base.tostring();
        }
    }
    class cat : mammal
    {
        public cat(string name) : base(name)
        {

        }
        public void greets()
        {
            Console.WriteLine("Meow");
        }
        public override string tostring()
        {
            return "Cat=" + base.tostring();
        }
    }
    class dog : mammal
    {
        public dog(string name) : base(name)
        {

        }
        public void greets()
        {
            Console.WriteLine("Woof");
        }
        public void greets(dog d)
        {
            Console.WriteLine("Wooooof");
        }
        public override string tostring()
        {
            return "Dog= " + base.tostring();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            animal a1 = new animal("Jack");
            Console.WriteLine(a1.tostring());
            mammal m1 = new mammal("Joe");
            Console.WriteLine(m1.tostring());
            cat c1 = new cat("Ezza");
            Console.WriteLine(c1.tostring());
            c1.greets();
            dog d1 = new dog("Butt");
            dog d2 = new dog("Butt 2");
            Console.WriteLine(d1.tostring());
            d1.greets();
            Console.WriteLine(d2.tostring());
            d2.greets(d2);


        }
    }
}
