using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Petshop.Catalogs;
using Petshop.Models;
using System.Collections.Generic;

namespace Petshop.Pages.Animals
{
    public class RabbitsModel : PageModel
    {
        AnimalCatalog animalCatalog;
        public List<Animal> Animals { get; private set; }


        public IActionResult OnGet()
        {
            animalCatalog = new AnimalCatalog();
            Animals = animalCatalog.AllAnimals();
            return Page();
        }
    }
}
