using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UserSignup.Models;

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Users = UserData.GetAll();
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(User user, string verify)
        {
            var errors = new List<string>();

            // Validate the username.
            if (string.IsNullOrEmpty(user.Username))
            {
                errors.Add("Username is required.");
                user.Username = string.Empty;
            }
            else if (user.Username.Trim().Length < 5 || user.Username.Trim().Length > 15)
            {
                errors.Add("Username must be between 5 and 15 characters long.");
                user.Username = string.Empty;
            }
            else if (!Regex.IsMatch(user.Username, @"^[a-zA-Z]+$"))
            {
                errors.Add("Username must only contain letters.");
                user.Username = string.Empty;
            }

            // Validate the email.
            if (string.IsNullOrEmpty(user.Email))
            {
                errors.Add("Email is required.");
                user.Email = string.Empty;
            }

            // Validate the password.
            if (string.IsNullOrWhiteSpace(user.Password))
            {
                errors.Add("Password is required.");
                user.Password = string.Empty;
            }
            else if (user.Password != verify)
            {
                errors.Add("Passwords do not match.");
                user.Password = string.Empty;
            }

            // Any errors, reshow the form.
            if (errors.Any())
            {
                ViewBag.Errors = errors;
                return View(user);
            }

            // Everything worked.

            // Save the user.
            UserData.Add(user);

            // Send to the index view.
            return Redirect("/User");
        }

        public IActionResult Detail(int userId)
        {
            var user = UserData.GetById(userId);
            ViewBag.Username = user.Username;
            ViewBag.Email = user.Email;
            return View();
        }
    }
}
