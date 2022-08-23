using PizzaApp.Models;

namespace PizzaApp.Operations
{
    public static class Factory
    {
        public static Pizza GetAPizza(int? id)
        {
            switch (id)

            {
                case 0:

                    return new Pizza();

                case 1:

                    return new Hawaiian();

                case 2:

                    return new Magarita();

                case 3:
                    return new Roma();

                default:

                    return new Pizza();
            }

        }
    }
}
