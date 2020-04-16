using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        // TODO #1 - Create a Results action method to process 
        // search request and display results

        public IActionResult Results(string searchType, string searchTerm)
        {
            // Null values crash the search, convert it to an empty string.
            if (searchTerm == null) searchTerm = string.Empty;

            if (searchType == "all")
            {
                // Get all matching jobs across all types.
                ViewBag.jobs = JobData.FindByValue(searchTerm);
            }
            else
            {
                // Get matching jobs for a specific type.
                ViewBag.jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
            }

            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search Results";

            return View("Index");
        }

    }
}
