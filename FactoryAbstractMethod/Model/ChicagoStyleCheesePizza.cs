using System;

namespace Factory.Model
{
    public class ChicagoStyleCheesePizza: Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            name = "Chicago Style Deep Dish Cheese Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredered Mozzarella Cheese");
        }

        protected void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}