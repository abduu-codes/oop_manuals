using System;

namespace challenge2
{ 
    class Program
    {
        static void Main(string[] args)
        {
            MUserDL.AddUser(new MUser("admin", "123", "Admin"));

            string mainChoice = "";
            while ((mainChoice = MenuUI.MainMenu()) != "3")
            {
                if (mainChoice == "1")
                {
                    MUser inputUser = SystemUI.TakeLoginInput();
                    MUser activeUser = MUserDL.VerifyUser(inputUser.username, inputUser.password);
                    if (activeUser != null)
                    {
                        if (activeUser.role.ToLower() == "admin")
                        {
                            RunAdminMenu();
                        }
                        else if (activeUser.role.ToLower() == "customer")
                        {
                            RunCustomerMenu();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Credentials!");
                    }
                }
                else if (mainChoice == "2")
                {
                    MUser newUser = SystemUI.TakeUserInput();
                    MUserDL.AddUser(newUser);
                    Console.WriteLine("User Registered Successfully.");
                }
            }
        }
        static void RunAdminMenu()
        {
            string adminChoice = "";
            while ((adminChoice = MenuUI.AdminMenu()) != "6")
            {
                if (adminChoice == "1") 
                    ProductDL.AddProduct(SystemUI.TakeProductInput());
                else if (adminChoice == "2") 
                    SystemUI.ViewAllProducts();
                else if (adminChoice == "3")
                {
                    Product expensive = ProductDL.GetHighestPriceProduct();
                    if (expensive != null) 
                        Console.WriteLine($"Highest Price: {expensive.name} (${expensive.price})");
                }
                else if (adminChoice == "4") 
                    SystemUI.ViewTaxes();
                else if (adminChoice == "5") 
                    SystemUI.ViewProductsToOrder();
            }
        }
        static void RunCustomerMenu()
        {
            Customer sessionCustomer = new Customer();
            string custChoice = "";

            while ((custChoice = MenuUI.CustomerMenu()) != "4")
            {
                if (custChoice == "1") 
                    SystemUI.ViewAllProducts();
                else if (custChoice == "2") 
                    SystemUI.BuyProduct(sessionCustomer);
                else if (custChoice == "3") 
                    SystemUI.GenerateInvoice(sessionCustomer);
            }
        }
    }
}