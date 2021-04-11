namespace Factory_Simple.Domain.CaliforniaPizzas
{
    class CaliforniaStylePeperoniPizza : Pizza
    {
        public CaliforniaStylePeperoniPizza()
        {
            Name = "California Pepperoni Pizza";
            Dough = "Big Crust ";
            Sauce = "Pepper Sauce";

            Toppings.Add("Californian cream cheese");
            Toppings.Add("Pepperoni crosted");
        }
    }
}
