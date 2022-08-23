using PizzaApp.Operations;

namespace PizzaApp.Models
{
    public class Hawaiian : Pizza
    {
        public Hawaiian()

        {
            ID = 1;
            PizzaName = "Hawaiian";
            Ingredients.Add(Ingredient.Tomatoes.ToString());
            Ingredients.Add(Ingredient.Cheese.ToString());
            Ingredients.Add(Ingredient.Pineapple.ToString());
            Description = "Homemade pizza dough, homemade pizza sauce, ham, pineapple, mozzarella cheese";
            PizzaCost.Add(pizzaCost.Small.ToString() + " $27");
            PizzaCost.Add(pizzaCost.Medium.ToString() + " $32");
            PizzaCost.Add(pizzaCost.Large.ToString() + " $34");
            Image = "Hawaiian.jpg";
            IsGlutenfree = true;
            IsVegetarian = true;

            AddChefName("Created by Chef Smith");


        }

        public override void AddChefName(string chef)
        {
            base.AddChefName($"{chef}");
        }
    }

}