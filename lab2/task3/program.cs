using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool workingState = true;

            ATM Account = new ATM();

            do
            {
                Console.Clear();

                Console.WriteLine("========== ATM Class ==========\n");

                Console.WriteLine("Your Option");
                Console.WriteLine("1. See Balance");
                Console.WriteLine("2. Add Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show History"); 
                Console.WriteLine("5. Exit"); 

                Console.Write("Enter Your Choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("Your Balance: " + Account.Balance + "Rs");
                }
                else if (choice == "2")
                {
                    Console.Write("Enter The Ammount You want to Deposit: ");
                    double amount = Convert.ToDouble(Console.ReadLine());

                    Account.Deposit(Account, amount);
                }
                else if (choice == "3")
                {
                    Console.Write("Enter The Ammount You want to WithDraw: ");
                    double amount = Convert.ToDouble(Console.ReadLine());

                    Account.Withdraw(Account, amount);
                }
                else if (choice == "4")
                {
                    Account.Hostory(Account);
                }
                else if (choice == "5")
                {
                    workingState = false;
                    break;
                }
                else
                {
                    Console.WriteLine("You Must need to enter valid choice betweek 1 - 5.");
                }

                Console.ReadKey();
            }
            while (workingState);
        }
    }
    public class ATM
    {
        public double Balance;
        public List<string> History = new List<string>();
        public ATM()
        {
            Balance = 0.00;
        }

        public void Deposit(ATM a, double Amount)
        {
            Console.WriteLine("Successfully Deposit");

            a.Balance += Amount;
            Console.WriteLine("Your Balance: " + a.Balance);

            a.History.Add($" {Amount}Rs Deposited => Balance {a.Balance}");
        }

        public void Withdraw(ATM a, double Amount)
        {
            Console.WriteLine("Successfully Withdraw");
            a.Balance -= Amount;
            Console.WriteLine("Your Balance: " + a.Balance + "Rs");

            a.History.Add($" {Amount}Rs WithDrawed => Balance {a.Balance}");
        }

        public double CheckBalance(ATM a)
        {
            return a.Balance;
        }

        public void Hostory(ATM a)
        {
            Console.WriteLine("Your History");

            foreach (string history in History)
            {
                Console.WriteLine("\n==========");
                Console.WriteLine(history);
                Console.WriteLine("==========\n");
            }
        }
    }
