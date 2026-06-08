using System;
namespace challenge4

{
    public class Account
    {
        protected string accountTitle;
        protected string accountNumber;
        protected double balance;

        public Account(string title, string number, double initialBalance)
        {
            this.accountTitle = title;
            this.accountNumber = number;
            this.balance = initialBalance;
        }

        public void debit(double amount)
        {
            if (balance >= amount)
            {
                balance = balance - amount;
                Console.WriteLine("Debited: " + amount);
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public void displayBalance()
        {
            Console.WriteLine("Account: " + accountTitle + " | Balance: " + balance);
        }
    }

    public class StudentAccount : Account
    {
        protected double maxCreditLimit = 500000;

        public StudentAccount(string title, string number, double initialBalance): base(title, number, initialBalance) { }

        public void creditStudent(double amount)
        {
            if (balance + amount <= maxCreditLimit)
            {
                balance = balance + amount;
                Console.WriteLine("Credited to Student: " + amount);
            }
            else
            {
                Console.WriteLine("Error: Exceeds 500k limit.");
            }
        }
    }

    public class SalaryAccount : Account
    {
        public SalaryAccount(string title, string number, double initialBalance) : base(title, number, initialBalance) { }

        public void creditSalary(double amount)
        {
            double tax = amount * 0.02;
            balance = balance + (amount - tax);
            Console.WriteLine("Credited Salary (after tax): " + (amount - tax));
        }
    }

    public class SavingAccount : Account
    {
        public SavingAccount(string title, string number, double initialBalance): base(title, number, initialBalance) { }

        public void creditSavings(double amount)
        {
            double profit = amount * 0.05;
            balance = balance + amount + profit;
            Console.WriteLine("Credited Savings (with profit): " + (amount + profit));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StudentAccount stdAcc = new StudentAccount("Ahmad Student", "ST-123", 1000);
            SalaryAccount salAcc = new SalaryAccount("Ahmad Employee", "SA-456", 5000);
            SavingAccount savAcc = new SavingAccount("Ahmad Saver", "SV-789", 10000);

            stdAcc.creditStudent(600000); 
            stdAcc.creditStudent(50000);  
            salAcc.creditSalary(10000); 
            savAcc.creditSavings(10000); 
            Console.WriteLine("--- Final Balances ---");
            stdAcc.displayBalance();
            salAcc.displayBalance();
            savAcc.displayBalance();
            Console.ReadKey();
        }
    }
}