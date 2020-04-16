using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TechJobs.Controllers
{
    public class TechJobsController : Controller
    {
        private static Dictionary<string, string> actionChoices = new Dictionary<string, string>();
        protected static Dictionary<string, string> columnChoices = new Dictionary<string, string>();

        static TechJobsController()
        {
            actionChoices.Add("search", "Search");
            actionChoices.Add("list", "List");

            columnChoices.Add("core competency", "Skill");
            columnChoices.Add("employer", "Employer");
            columnChoices.Add("location", "Location");
            columnChoices.Add("position type", "Position Type");
            columnChoices.Add("all", "All");
        }

        public override ViewResult View()
        {
            ViewBag.actions = actionChoices;
            ViewBag.columns = columnChoices;

            return base.View();
        }

        public override ViewResult View(string viewName)
        {
            ViewBag.actions = actionChoices;
            ViewBag.columns = columnChoices;

            return base.View(viewName);
        }
    }
}
