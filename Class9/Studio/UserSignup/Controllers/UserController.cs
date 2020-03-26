using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;
using UserSignup.ViewModels;

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
        public IActionResult Add(AddUserViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    Username = vm.Username,
                    Email = vm.Email,
                    Password = vm.Password
                };

                UserData.Add(user);

                return Redirect("/User");
            }

            return View(vm);
        }

        public IActionResult Detail(int userId)
        {
            var user = UserData.GetById(userId);
            ViewBag.Username = user.Username;
            ViewBag.Email = user.Email;
            ViewBag.JoinedDate = user.JoinedDate;
            return View();
        }
    }
}
