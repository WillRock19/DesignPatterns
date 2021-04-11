namespace Factory_Simple.Domain.CaliforniaPizzas
{
    class CaliforniaStyleCheesePizza : Pizza
    {
        public CaliforniaStyleCheesePizza()
        {
            Name = "California Style Cheese Pizza";
            Dough = "Big Crust ";
            Sauce = "Pepper Sauce";

            Toppings.Add("Californian cream cheese");
        }
    }
}
