using Factory_Simple.Domain;
using Factory_Simple.Domain.CaliforniaPizzas;

namespace Factory_Simple.Services.PizzaStore
{
    class CaliforniaPizzaStoreService : PizzaStoreService
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type == "cheese")
            {
                return new CaliforniaStyleCheesePizza();
            }
            else if (type == "pepperoni")
            {
                return new CaliforniaStylePeperoniPizza();
            }
            else return null;
        }
    }
}
