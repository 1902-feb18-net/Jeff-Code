using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerShop.Library
{
    public class Orders
    {
        public string InitialOrder { get; set; }

        public void EditOrder()
        {
            string edit;
            if (InitialOrder == "1")
            {
                Console.WriteLine("What would you like to add on your Cheesebrurger");
                Console.WriteLine("1.Lettuce");
                Console.WriteLine("2.Tomatoes");
                Console.WriteLine("3.Onions");
                Console.WriteLine("4.Ketchup");
                Console.WriteLine("5.Mustard");

                Console.WriteLine($"If you would like to add one of the following to your {InitialOrder} then input one or more of the options above: ");
                edit = Console.ReadLine();
            }
            if (InitialOrder == "2")
            {

            }
            if (InitialOrder == "3")
            {

            }
            if (InitialOrder == "4")
            {

            }
        }
       
    }
}
