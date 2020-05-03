using System.Collections.Generic;

namespace CheeseMVC.Models
{
    public class CheeseCategory
    {
        public IList<Cheese> Cheeses { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
    }
}