using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        private static Dictionary<string, string> Cheeses = new Dictionary<string, string>();

        public IActionResult Index()
        {
            // Populate the list of cheeses from a static variable on the server.
            // This will be the same for all users.
            ViewBag.Cheeses = Cheeses;

            // Display a view that lists all the cheeses.
            return View();
        }

        public IActionResult Add()
        {
            // Display a view that lets a user add a new cheese.
            return View();
        }

        public IActionResult Remove()
        {
            // Populate the list of cheeses from a static variable on the server.
            // This will be the same for all users.
            ViewBag.Cheeses = Cheeses;

            // Display a view that let's a user remove cheeses.
            return View();
        }

        public IActionResult RemoveMultiple()
        {
            // Populate the list of cheeses from a static variable on the server.
            // This will be the same for all users.
            ViewBag.Cheeses = Cheeses;

            // Display a view that let's a user remove cheeses.
            return View();
        }

        [HttpPost, Route("/cheese/add")]
        public IActionResult NewCheese(string name, string description)
        {
            // A form submit from the add view.

            // Add the new cheese to the collection.
            Cheeses.Add(name, description);

            // Redirect back to the default cheese URL.
            return Redirect("/cheese");
        }

        [HttpPost, Route("/cheese/remove")]
        public IActionResult RemoveCheese(string cheese)
        {
            // A form submit from the remove view.

            // Remove the cheese chosen from the list.
            Cheeses.Remove(cheese);

            // Redirect back to the default cheese URL.
            return Redirect("/cheese");
        }

        [HttpPost, Route("/cheese/removemultiple")]
        public IActionResult RemoveCheeses(List<string> cheeses)
        {
            // A form submit from the remove view.

            // Remove every cheese that came back in the list.
            // Only selected cheeses are returned by the form.
            foreach (var cheese in cheeses)
            {
                Cheeses.Remove(cheese);
            }

            // Redirect back to the default cheese URL.
            return Redirect("/cheese");
        }
    }
}