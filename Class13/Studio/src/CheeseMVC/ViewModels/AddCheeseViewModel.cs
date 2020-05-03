using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CheeseMVC.ViewModels
{
    public class AddCheeseViewModel
    {
        public AddCheeseViewModel()
        {
        }

        public AddCheeseViewModel(IEnumerable<CheeseCategory> categories)
        {
            Categories = new List<SelectListItem>();
            foreach (var category in categories)
                Categories.Add(new SelectListItem { Value = category.ID.ToString(), Text = category.Name });
        }

        public List<SelectListItem> Categories { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "You must give your cheese a description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Cheese Name")]
        public string Name { get; set; }
    }
}