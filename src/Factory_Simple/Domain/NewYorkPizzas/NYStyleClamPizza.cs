namespace Factory_Simple.Domain.NewYorkPizzas
{
    class NYStyleClamPizza : Pizza
    {
        public NYStyleClamPizza()
        {
            Name = "NY Style Sauce and Clam Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Clams");
        }
    }
}
