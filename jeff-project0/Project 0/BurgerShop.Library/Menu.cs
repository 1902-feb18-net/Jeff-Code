using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerShop.Library
{
    public class Menu
    {
        readonly string item1 = "1. Cheeseburger";
        readonly string item2 = "2. Hamburger";
        readonly string item3 = "3. Fries";
        readonly string item4 = "4. Soda";

        public void GetMenu()
        {
            Console.WriteLine(item1);
            Console.WriteLine(item2);
            Console.WriteLine(item3);
            Console.WriteLine(item4);
        }
    }
}
