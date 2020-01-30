using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorldMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            // Create the HTML form as a string.
            var output = "<form method=\"post\">" +
                "<input name=\"name\" type=\"text\" />" +
                "<select name=\"language\">" +
                "<option value=\"english\">English</option>" +
                "<option value=\"french\">French</option>" +
                "<option value=\"spanish\">Spanish</option>" +
                "<option value=\"klingon\">Klingon</option>" +
                "<option value=\"southern\">Southern</option>" +
                "</select>" +
                "<button type=\"submit\">Greet me!</button>" +
              "</form>";

            // Send the HTML directly back to the browser, skip the view.
            return Content(output, "text/html");
        }

        [HttpPost]
        public IActionResult Index(string name, string language)
        {
            // The route finds this method because the form is doing a POST.
            // Submitting the form populates two variables of the same name as in the form.

            // Return a string with the language translation.
            return Content(CreateMessage(name, language));
        }

        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }

        public static string CreateMessage(string name, string language)
        {
            // Create a hello message based on the language given.
            switch (language)
            {
                case "french":
                    return $"Bonjour {name}!";
                case "spanish":
                    return $"Hola {name}!";
                case "klingon":
                    return $"nuqneH {name}!";
                case "southern":
                    return $"Howdy {name}!";
                default:
                    return $"Hello {name}!";
            }
        }
    }
}
