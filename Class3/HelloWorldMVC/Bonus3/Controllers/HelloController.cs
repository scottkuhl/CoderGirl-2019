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

            // Get the count cookie sent from the browser.
            Request.Cookies.TryGetValue("count", out string cookieCount);

            // Make sure the value is a number.
            int.TryParse(cookieCount, out int count);

            // Increment the count.
            count++;

            // Send back a cookie to the browser with a new count.
            Response.Cookies.Append("count", count.ToString());

            // Translate the message.
            var message = CreateMessage(name, language);

            // Append the user count to the message.
            message += $"<p>You have been greeted {count} times.</p>";

            // Return HTML with the message.
            return Content(message, "text/html");
        }

        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }

        public static string CreateMessage(string name, string language)
        {
            string result;

            // Create a hello message based on the language given.
            switch (language)
            {
                case "french":
                    result = $"Bonjour {name}!";
                    break;
                case "spanish":
                    result = $"Hola {name}!";
                    break;
                case "klingon":
                    result = $"nuqneH {name}!";
                    break;
                case "southern":
                    result = $"Howdy {name}!";
                    break;
                default:
                    result = $"Hello {name}!";
                    break;
            }

            return $"<p>{result}</p>";
        }
    }
}
