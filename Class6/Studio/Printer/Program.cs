using Restaurant;
using System;

namespace Printer
{
    class Program
    {
        // Print the menu.
        static void Main(string[] args)
        {
            var menu = new Menu();

            menu.AddMenuItem("Pizza Rolls", "Hot terrible goodness.", Category.Appetizer, 3.00);
            menu.AddMenuItem("Hamburger", "Grown in a lab!", Category.MainCourse, 9.50);
            menu.AddMenuItem("Pie", "Apple, yes Apple.", Category.Dessert, 3.14);

            Console.WriteLine(menu);
        }
    }
}
