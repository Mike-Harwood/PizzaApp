using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaApp.Models;
using PizzaApp.Operations;

namespace PizzaApp.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        private bool isVegetarian;

        public bool IsFirstLoad { get; private set; } = false;
        public bool IsGlutenfree { get; private set; }
        public bool IsVegetarian { get; private set; }
        public int? PizzaSelected { get; set; }

        private bool isGlutenfree;

        // This is the Pizza Base Class
        public Pizza pizza { get; set; }

        public IndexModel()
        {
            pizza = new Pizza();
        }
        public void OnGet()
        {

        }

        // sending back the data for each type of pizza thats picked up
        public async Task<IActionResult> OnPost()
        {

            IsFirstLoad = true;
            IsGlutenfree = true;
            IsVegetarian = true;
            pizza = Factory.GetAPizza(PizzaSelected);


            return Page();
        }
    }
}
