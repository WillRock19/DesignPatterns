using Factory_Simple.Domain;
using Factory_Simple.Domain.NewYorkPizzas;

namespace Factory_Simple.Services.PizzaStore
{
    class NewYorkPizzaStoreService : PizzaStoreService
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type == "cheese")
            {
                return new NYStyleCheesePizza();
            }
            else if (type == "veggie")
            {
                return new NYStyleVeggiePizza();
            }
            else if(type == "clam") 
            {
                return new NYStyleClamPizza();
            }
            else return null;
        }
    }
}
