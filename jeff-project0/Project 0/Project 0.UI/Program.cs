using System;
using BurgerShop.Library;


namespace Project_0.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you a new customer? y/n: ");
            if (Console.ReadLine() == "y")
            {
                var newcustomer = new Customers();
                Console.WriteLine("Enter your first name: ");
                newcustomer.FirstName = Console.ReadLine();
                
                Console.WriteLine("Enter your last name: ");
                
                newcustomer.LastName = Console.ReadLine();
                newcustomer.CheckName();

                var newmenu = new Menu();
                newmenu.GetMenu();

                Console.WriteLine("What would you like?");
                var neworder = new Orders();
                neworder.InitialOrder = Console.ReadLine();

                neworder.EditOrder();

                
            }

            


        }
    }
}
