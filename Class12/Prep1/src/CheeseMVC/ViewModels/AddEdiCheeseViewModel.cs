using CheeseMVC.Models;

namespace CheeseMVC.ViewModels
{
    public class AddEditCheeseViewModel : AddCheeseViewModel
    {
        public int CheeseId { get; set; }

        public new Cheese CreateCheese()
        {
            var cheese = base.CreateCheese();
            cheese.CheeseId = CheeseId;
            return cheese;
        }
    }
}
