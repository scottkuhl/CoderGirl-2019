namespace CheeseMVC.Models
{
    public class Cheese
    {
        public CheeseCategory Category { get; set; }
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Taste { get; set; }
    }
}