using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CheeseMVC.ViewModels
{
    public class AddCheeseViewModel
    {
        [Required, Display(Name = "Cheese Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must give your cheese a description.")]
        public string Description { get; set; }

        public CheeseType Type { get; set; }

        public List<SelectListItem> CheeseTypes { get; set; }

        public AddCheeseViewModel()
        {
            CheeseTypes = new List<SelectListItem>
            {
                new SelectListItem { Text = CheeseType.Hard.ToString(), Value = ((int)CheeseType.Hard).ToString() },
                new SelectListItem { Text = CheeseType.Soft.ToString(), Value = ((int)CheeseType.Soft).ToString() },
                new SelectListItem { Text = CheeseType.Fake.ToString(), Value = ((int)CheeseType.Fake).ToString() }
            };
        }
    }
}
