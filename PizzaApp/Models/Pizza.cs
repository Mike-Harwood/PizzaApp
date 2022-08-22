using PizzaApp.Operations;
using System.ComponentModel.DataAnnotations;

namespace PizzaApp.Models
{
    public class Pizza
    {


        public int ID { get; set; }
        public string PizzaName { get; set; }

        public string Description { get; set; }

        public List<string> Ingredients { get; set; }

        public List<string> PizzaCost { get; set; }

        public virtual string ChefName { get; set; } = "smith";

        public string Image { get; set; }

        public bool isGlutenfree { get; set; }

        public bool isVegetarian { get; set; }

        public bool IsFirstload { get; set; } = false;


        [Display(Name = "Pizza Choice")]
        public PizzaEnum PizzaChoice { get; set; }




    }
}
