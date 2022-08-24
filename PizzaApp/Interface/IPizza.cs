namespace PizzaApp.Interface
{
    public interface IPizza
    {
        string ChefName { get; set; }
        string Description { get; set; }
        int ID { get; set; }
        string Image { get; set; }
        List<string> Ingredients { get; set; }
        bool IsFirstload { get; set; }
        bool IsGlutenfree { get; set; }
        bool IsVegetarian { get; set; }
        List<string> PizzaCost { get; set; }
        string PizzaName { get; set; }
        int? PizzaSelected { get; }

        void AddChefName(string chef);
    }
}