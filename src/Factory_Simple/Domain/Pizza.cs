using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Simple.Domain
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings { get; set; }

        public void Prepare() 
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine($"Adding toppings: {string.Join(" ", Toppings)}");
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350º C");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }
}
