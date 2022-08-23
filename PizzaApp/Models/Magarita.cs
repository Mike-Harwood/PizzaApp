using PizzaApp.Operations;

namespace PizzaApp.Models
{
    public class Magarita : Pizza
    {
        public bool IsGlutenfree { get; set; }
        public bool IsVegetarian { get; set; }
        public Magarita()
        {
            ID = 2;
            PizzaName = "Magarita";
            Ingredients.Add(Ingredient.Tomatoes.ToString());
            Ingredients.Add(Ingredient.Mozzarella.ToString());
            Ingredients.Add(Ingredient.Basil.ToString());
            Description = "Pizza margherita, as the Italians call it, is a simple pizza hailing from Naples. When done right, margherita pizza features a bubbly crust, crushed San Marzano tomato sauce, fresh mozzarella and basil, a drizzle of olive oil, and a sprinkle of salt";
            PizzaCost.Add(pizzaCost.Small.ToString() + " $20");
            PizzaCost.Add(pizzaCost.Medium.ToString() + " $25");
            PizzaCost.Add(pizzaCost.Large.ToString() + " $30");
            Image = "Margarita.jpg";
            IsGlutenfree = true;
            IsVegetarian = true;

            AddChefName("Created by Chef Steve");
        }

        public override void AddChefName(string chef)
        {
            base.AddChefName($"{chef}");
        }
    }
}
