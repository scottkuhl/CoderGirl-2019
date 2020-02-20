using System;

namespace Restaurant
{
    /// <summary>
    ///     Food items available for order.
    /// </summary>
    public class MenuItem
    {
        /// <summary>
        ///     Short name of the item.
        /// </summary>
        /// <example>
        ///     Green Mussels
        /// </example>
        public string Name { get; set; }

        /// <summary>
        ///     A longer description of the item.
        /// </summary>
        /// <example>
        ///     Broiled mussels mixed with spicy crab
        /// </example>
        public string Description { get; set; }

        /// <summary>
        ///     Category of the menu item, can be used from grouping.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        ///     Cost of the menu item.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        ///     Date the menu item was first made available.
        /// </summary>
        public DateTime AddedOn { get; set; }

        /// <summary>
        ///     Was the menu item added in the last 3 months?
        /// </summary>
        public bool IsNew
        {
            get
            {
                return AddedOn.Date >= DateTime.Now.Date.AddMonths(-3);
            }
        }
    }
}
