using CheeseMVC.Models;
using CheeseMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.cheeses = CheeseData.GetAll();

            return View();
        }

        public IActionResult Add()
        {
            return View(new AddCheeseViewModel());
        }

        [HttpPost]
        public IActionResult Add(AddCheeseViewModel vm)
        {
            if (ModelState.IsValid)
            {
                // Add the new cheese to my existing cheeses
                var newCheese = new Cheese
                {
                    Description = vm.Description,
                    Name = vm.Name,
                    Type = vm.Type
                };
                CheeseData.Add(newCheese);

                return Redirect("/Cheese");
            }

            return View(vm);
        }

        public IActionResult Remove()
        {
            ViewBag.title = "Remove Cheeses";
            ViewBag.cheeses = CheeseData.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Remove(int[] cheeseIds)
        {
            foreach (int cheeseId in cheeseIds)
            {
                CheeseData.Remove(cheeseId);
            }

            return Redirect("/");
        }

        public IActionResult Edit(int cheeseId)
        {
            var cheese = CheeseData.GetById(cheeseId);

            var vm = new AddEditCheeseViewModel
            {
                CheeseId = cheese.CheeseId,
                Name = cheese.Name,
                Description = cheese.Description,
                Type = cheese.Type
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(AddEditCheeseViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var cheese = CheeseData.GetById(vm.CheeseId);
                cheese.Description = vm.Description;
                cheese.Name = vm.Name;
                cheese.Type = vm.Type;

                return Redirect("/");
            }

            return View(vm);
        }
    }
}
