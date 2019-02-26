using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerShop.Library
{
   public class Customers
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void CheckName()
        {
            Console.WriteLine($"Your name is {FirstName} {LastName}");
        }

    }
}
