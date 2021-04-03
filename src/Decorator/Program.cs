using Decorator.Domain;
using Decorator.Domain.Condiments;
using Decorator.Domain.Drinks;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("=======WELCOME TO COFFEE WORLD=======");
            Console.WriteLine("=====================================");
            Console.WriteLine("===========TABLE OF PRICES===========");
            
            var expresso = new Expresso();
            var darkRoast = new Expresso();
            var houseBlend = new Expresso();

            Console.WriteLine($"1. {expresso.GetDescription()}");
            PrintAllPricesForBeverage(expresso);

            Console.WriteLine($"2. {darkRoast.GetDescription()}");
            PrintAllPricesForBeverage(darkRoast);

            Console.WriteLine($"3. {houseBlend.GetDescription()}");
            PrintAllPricesForBeverage(houseBlend);
        }

        static void PrintAllPricesForBeverage(Beverage beverage) 
        {
            var withMocha = new Mocha(beverage);
            
            var withWhip = new Whip(beverage);
            var withMochaAndWhip = new Whip(withMocha);

            var withSoy = new Soy(beverage);
            var withSoyAndWhip = new Soy(withWhip);
            var withSoyAndMocha = new Soy(withMocha);
            var withMochaAndWhipAndSoy = new Soy(withMochaAndWhip);

            Console.WriteLine($"-> {withMocha.GetDescription()}: {withMocha.Cost()}");
            Console.WriteLine($"-> {withWhip.GetDescription()}: {withWhip.Cost()}");
            Console.WriteLine($"-> {withMochaAndWhip.GetDescription()}: {withMochaAndWhip.Cost()}");
            Console.WriteLine($"-> {withSoy.GetDescription()}: {withSoy.Cost()}");
            Console.WriteLine($"-> {withSoyAndWhip.GetDescription()}: {withSoyAndWhip.Cost()}");
            Console.WriteLine($"-> {withSoyAndMocha.GetDescription()}: {withSoyAndMocha.Cost()}");
            Console.WriteLine($"-> {withMochaAndWhipAndSoy.GetDescription()}: {withMochaAndWhipAndSoy.Cost()}");
        }
    }
}
