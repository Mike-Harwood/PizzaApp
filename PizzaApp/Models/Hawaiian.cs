namespace PizzaApp.Models
{
    public class Hawaiian : Pizza
    {

        public Hawaiian()


        {
            ID = 1;
            PizzaName = "Hawaiian";
            Ingredients.Add("Tomatoes, cheese, pineapple");
            Description = "Homemade pizza dough, homemade pizza sauce, ham, pineapple, mozzarella cheese";
            PizzaCost.Add("small-$23");
            PizzaCost.Add("medium-$26");
            PizzaCost.Add("large-$33");
            ChefName = ChefName;
            Image = "";
            isGlutenfree = true;
            isVegetarian = true;

        }

    }




}