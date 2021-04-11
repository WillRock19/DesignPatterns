namespace Factory_Simple.Domain.NewYorkPizzas
{
    class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            Name = "NY Style Sauce and Veggie Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Veggie Cheese");
        }
    }
}
