using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ooplab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2;
            num1 = 10;
            num2 = 20;
            calculator calc = new calculator(num1, num2);
            Console.WriteLine(calc.add());
            Console.WriteLine(calc.subtract());
            Console.WriteLine(calc.multilpy());
            Console.WriteLine(calc.divide());
        }
    }
    class calculator
    {
        public double number1;
        public double number2;
        public calculator(double n1, double n2)
        {
            this.number1 = n1;
            this.number2 = n2;
        }
        public float add()
        {
            return (float)(number1 + number2);
        }
        
        public float multilpy()
        {
            return (float)(number1 * number2); 
        }

        public double divide()
        {
            return number2 != 0 ? number1 / number2 : 0;
        }
        public float subtract()
        {
                       return (float)(number1 - number2);

        }

    }
}
