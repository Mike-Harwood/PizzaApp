using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaApp.Models;
using PizzaApp.Operations;

namespace PizzaApp.Pages
{

    [BindProperties]
    public class IndexModel : PageModel
    {
        // This is the Pizza Base Class
        public Pizza pizza { get; set; }


        public void OnGet()
        {


        }

        // sending back the data for each type of pizza thats picked up
        public async Task<IActionResult> OnPost()
        {

            pizza = Factory.GetAPizza(pizza.PizzaSelected);

            return Page();
        }
    }
}

