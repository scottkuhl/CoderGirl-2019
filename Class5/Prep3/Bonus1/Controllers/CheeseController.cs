using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        private static List<Cheese> Cheeses = new List<Cheese>();

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

            // Validate the data.
            if (string.IsNullOrEmpty(name))
            {
                ViewBag.ErrorMessage = "Name is required.";
            }
            else if (!name.All(x => char.IsLetter(x) || x == ' '))
            {
                ViewBag.ErrorMessage = "Name can only contain letters and spaces.";
            }

            if (!string.IsNullOrEmpty(ViewBag.ErrorMessage))
            {
                // Show the form again.
                return View("Add");
            }

            // Add the new cheese to the collection.
            Cheeses.Add(new Cheese { Name = name, Description = description });

            // Redirect back to the default cheese URL.
            return Redirect("/cheese");
        }

        [HttpPost, Route("/cheese/remove")]
        public IActionResult RemoveCheese(string cheese)
        {
            // A form submit from the remove view.

            // Remove the cheese chosen from the list.
            var item = Cheeses.FirstOrDefault(x => x.Name == cheese);
            if (item != null) Cheeses.Remove(item);

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
                var item = Cheeses.FirstOrDefault(x => x.Name == cheese);
                if (item != null) Cheeses.Remove(item);
            }

            // Redirect back to the default cheese URL.
            return Redirect("/cheese");
        }
    }
}