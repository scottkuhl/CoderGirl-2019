using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            // Get the username from temp data and put it in the view bag.
            ViewBag.Welcome = TempData["Welcome"];
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(User user, string verify)
        {
            // Make sure the password is not blank.
            if (string.IsNullOrWhiteSpace(user.Password))
            {
                user.Password = string.Empty;
                ViewBag.Username = user.Username;
                ViewBag.Email = user.Email;
                ViewBag.Error = "Password is required.";
                return View(user);
            }

            // Make sure the passwords match.
            if (user.Password != verify)
            {
                user.Password = string.Empty;
                ViewBag.Username = user.Username;
                ViewBag.Email = user.Email;
                ViewBag.Error = "Passwords do not match.";
                return View(user);
            }

            UserData.Add(user);

            // Everything worked, store the username in temp data.
            // TempData is a way to store values between a single re-direct.  After that, they are lost.
            TempData["Welcome"] = user.Username;

            // Send to the index view.
            return Redirect("/User");
        }
    }
}
