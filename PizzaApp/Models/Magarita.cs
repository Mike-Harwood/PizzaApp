namespace PizzaApp.Models
{
    public class Magarita : Pizza
    {
        public Magarita()
        {
            PizzaName = "Magarita";
            Ingredients.Add("tomato");
            Description = "Pizza margherita, as the Italians call it, is a simple pizza hailing from Naples. When done right, margherita pizza features a bubbly crust, crushed San Marzano tomato sauce, fresh mozzarella and basil, a drizzle of olive oil, and a sprinkle of salt";
            PizzaCost.Add("small-$20");
            PizzaCost.Add("medium-$25");
            PizzaCost.Add("large-$30");
            ChefName = "Created by Dan";
            Image = "";
            isGlutenfree = true;
            isVegetarian = true;

        }

    }
}
