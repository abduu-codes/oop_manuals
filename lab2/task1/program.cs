using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            transaction t1 = new transaction();
            t1.transactionID = 1;
            t1.productname = "laptop";
            t1.price = 500;
            t1.date = DateTime.Now;

            transaction t2 = new transaction(t1);
            t2.transactionID = 2;
            Console.WriteLine("Transaction 1: " + t1.transactionID);
            Console.WriteLine("transaction 2: "+  t2.transactionID);
        }
    }
    class transaction
    {
        public int transactionID;
        public string productname;
        public double price;
        public DateTime date;

        public transaction()
        {
            transactionID = 0;
            productname = " ";
            price = 0; 
            date = DateTime.Now;
        }
        public transaction ( transaction t)
        {
            transactionID = t.transactionID;
            productname = t.productname;
            price = t.price;
            date = t.date;
        }
        
        
    }
}
