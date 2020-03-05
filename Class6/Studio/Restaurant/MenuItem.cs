using System;

namespace Restaurant
{
    /// <summary>
    ///     Food items available for order.
    /// </summary>
    public class MenuItem
    {
        private static int nextId = 1;

        private string _name;
        private string _description;
        private Category _category;
        private double _price;

        public MenuItem()
        {
            Id = nextId++;
            AddedOn = DateTime.Now;
        }

        /// <summary>
        ///     Unique number for the record.
        /// </summary>
        /// <remarks>
        ///     The ID is read only. IDs of classes should not change because they are a unique identifier.
        /// </remarks>
        public int Id { get; private set; }

        /// <summary>
        ///     Short name of the item.
        /// </summary>
        /// <example>
        ///     Green Mussels
        /// </example>
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                LastUpdated = DateTime.Now;
            }
        }

        /// <summary>
        ///     A longer description of the item.
        /// </summary>
        /// <example>
        ///     Broiled mussels mixed with spicy crab
        /// </example>
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                LastUpdated = DateTime.Now;
            }
        }

        /// <summary>
        ///     Category of the menu item, can be used from grouping.
        /// </summary>
        public Category Category
        {
            get { return _category; }
            set
            {
                _category = value;
                LastUpdated = DateTime.Now;
            }
        }

        /// <summary>
        ///     Cost of the menu item.
        /// </summary>
        public double Price
        {
            get { return _price; }
            set
            {
                _price = value;
                LastUpdated = DateTime.Now;
            }
        }

        /// <summary>
        ///     Date the menu item was first made available.
        /// </summary>
        public DateTime AddedOn { get; private set; }

        /// <summary>
        ///     The last time this menu item was updated.
        /// </summary>
        public DateTime LastUpdated { get; private set; }

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

        /// <summary>
        ///     Printable menu item.
        /// </summary>
        public override string ToString()
        {
            var newString = IsNew ? " NEW! " : string.Empty;

            return
                $"{Name}{newString} {Price.ToString("C0")}{Environment.NewLine}" +
                $"{Description}{Environment.NewLine}{Environment.NewLine}";
        }

        public override bool Equals(object obj)
        {
            if (obj == this) return true;
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;

            var menuItemObj = obj as MenuItem;
            return Id == menuItemObj.Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}
