using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaApp.Models;

namespace PizzaApp.Pages
{
    public class IndexModel : PageModel
    {

        public Pizza pizza { get; set; }


        public void OnGet()
        {


        }
    }
}

