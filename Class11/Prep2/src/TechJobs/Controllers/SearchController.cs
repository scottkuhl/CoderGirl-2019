using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : TechJobsController
    {
        public IActionResult Index()
        {
            ViewBag.title = "Search";
            ViewBag.selected = "all";
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

            ViewBag.title = "Search Results";
            ViewBag.selected = searchType;

            return View("Index");
        }

    }
}
