using System;

namespace Restaurant
{
    class Program
    {
        public void Main()
        {
            var menu = new Menu();

            var appetizer1 = new MenuItem();
            appetizer1.Name = "Pizza Rolls";

            menu.MenuItems.Add(appetizer1);


            Console.WriteLine(menu.MenuItems[0].Name);
        }
    }
}
