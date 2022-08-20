namespace PizzaApp.Models
{
    public class Roma : Pizza
    {
        public Roma()
        {
            PizzaName = "Roma";
            Ingredients.Add("tomato");
            Description = "Homemade Pizza dough, homemade pizza sauce, fresh argula, mozzarella cheese, cherry tomatoes, parmesan chees olive oil";
            PizzaCost.Add("small-$24");
            PizzaCost.Add("medium-$27");
            PizzaCost.Add("large-$38");
            ChefName = "created by smith";
            Image = "";
            isGlutenfree = true;
            isVegetarian = true;

        }



    }
}
