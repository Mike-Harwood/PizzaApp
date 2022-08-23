

namespace PizzaApp.Models
{
    public class Pizza
    {

        public int ID { get; set; }
        public string PizzaName { get; set; }

        public string Description { get; set; }

        public List<string> Ingredients { get; set; }

        public List<string> PizzaCost { get; set; }

        public string ChefName { get; set; }


        // Holds the selected image
        public string Image { get; set; }


        //The list of Pizzas images



        //public List<string> = new List<string>(); 
        public bool IsGlutenfree { get; set; }

        public bool IsVegetarian { get; set; }
        public bool IsFirstload { get; set; }

        // Pull down Menu 
        //public int? PizzaSelected { get; set; }

        public Pizza()
        {

            Ingredients = new List<string>();
            PizzaCost = new List<string>();


            IsFirstload = true;
        }

        //[Display(Name = "Pizza Choice")]
        //public PizzaEnum PizzaChoice { get; set; }

        public int? PizzaSelected { get; internal set; }

        public virtual void AddChefName(string chef)
        {
            ChefName = chef;
        }
    }
}
