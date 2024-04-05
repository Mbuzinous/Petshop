using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Petshop.Catalogs;
using Petshop.Models;
using System.Collections.Generic;

namespace Petshop.Pages.Animals
{
    public class AllAnimalsModel : PageModel
    {

        public IActionResult OnGet()
        {

            return Page();
        }
    }
}
