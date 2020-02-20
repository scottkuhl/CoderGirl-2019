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
    }
}
