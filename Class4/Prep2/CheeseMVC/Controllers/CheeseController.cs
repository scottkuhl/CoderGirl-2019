using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        private static Dictionary<string, string> Cheeses = new Dictionary<string, string>();

        public IActionResult Index()
        {
            ViewBag.Cheeses = Cheeses;

            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost, Route("/cheese/add")]
        public IActionResult NewCheese(string name, string description)
        {
            Cheeses.Add(name, description);

            return Redirect("/cheese");
        }
    }
}