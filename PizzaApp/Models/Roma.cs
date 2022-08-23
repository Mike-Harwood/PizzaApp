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
            Ingredients.Add("tomato");
            Description = "Homemade Pizza dough, homemade pizza sauce, fresh argula, mozzarella cheese, cherry tomatoes, parmesan chees olive oil";
            PizzaCost.Add("small-$24");
            PizzaCost.Add("medium-$27");
            PizzaCost.Add("large-$38");
            Image = "";
            isGlutenfree = true;
            isVegetarian = true;

            AddChefName("Mark");
        }

        public override void AddChefName(string chef)
        {
            base.AddChefName($"{chef}");
        }
    }
}
