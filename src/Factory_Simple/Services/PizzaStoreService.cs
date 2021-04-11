using Factory_Simple.Domain;

namespace Factory_Simple.Services
{
    abstract class PizzaStoreService
    {
        public Pizza OrderPizza(string type) 
        {
            var pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}
