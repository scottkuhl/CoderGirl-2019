using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant
{
    /// <summary>
    ///     Menu of items available to order.
    /// </summary>
    public class Menu
    {
        /// <summary>
        ///     List of all items.
        /// </summary>
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();

        /// <summary>
        ///     Are any new items available?
        /// </summary>
        public bool NewItemsAvailable
        {
            get
            {
                return MenuItems.Any(x => x.IsNew);
            }
        }

        /// <summary>
        ///     Add a new item to the menu.
        /// </summary>
        public void AddMenuItem(string name, string description, Category category, double price)
        {
            MenuItems.Add(new MenuItem { Name = name, Description = description, Category = category, Price = price });
        }

        /// <summary>
        ///     Printable menu.
        /// </summary>
        public override string ToString()
        {
            var result = string.Empty;

            result = "MENU" + Environment.NewLine + Environment.NewLine;

            if (NewItemsAvailable)
                result += "NEW ITEMS NOW AVAILABLE!!!" + Environment.NewLine + Environment.NewLine;

            result += "APPETIZERS" + Environment.NewLine + Environment.NewLine;
            foreach (var menuItem in MenuItems.Where(x => x.Category == Category.Appetizer))
                result += $"{menuItem}{Environment.NewLine}";

            result += "MAIN COURSE" + Environment.NewLine + Environment.NewLine;
            foreach (var menuItem in MenuItems.Where(x => x.Category == Category.MainCourse))
                result += $"{menuItem}{Environment.NewLine}";

            result += "DESERT" + Environment.NewLine + Environment.NewLine;
            foreach (var menuItem in MenuItems.Where(x => x.Category == Category.Dessert))
                result += $"{menuItem}{Environment.NewLine}";

            return result;
        }

    }
}
