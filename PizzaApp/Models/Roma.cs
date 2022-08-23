using PizzaApp.Operations;

namespace PizzaApp.Models
{
    public class Roma : Pizza
    {
        public bool IsGlutenfree { get; set; }
        public bool IsVegetarian { get; set; }
        public Roma()
        {
            ID = 3;
            PizzaName = "Roma";
            Ingredients.Add(Ingredient.Argula.ToString());
            Ingredients.Add(Ingredient.Mozzarella.ToString());
            Ingredients.Add(Ingredient.Tomatoes.ToString());
            Description = "Homemade Pizza dough, homemade pizza sauce, fresh argula, mozzarella cheese, cherry tomatoes, parmesan cheese olive oil";
            PizzaCost.Add(pizzaCost.Small.ToString() + "28");
            PizzaCost.Add(pizzaCost.Medium.ToString() + "36");
            PizzaCost.Add(pizzaCost.Large.ToString() + "39");
            Image = "Roma.jpg";
            IsGlutenfree = true;
            IsVegetarian = true;

            AddChefName("Created by Chef Mark");
        }

        public override void AddChefName(string chef)
        {
            base.AddChefName($"{chef}");
        }
    }
}
