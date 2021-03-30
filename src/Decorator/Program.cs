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

            Console.WriteLine($"1. {expresso.Description}");
            PrintAllPricesForBeverage(expresso);

            Console.WriteLine($"2. {darkRoast.Description}");
            PrintAllPricesForBeverage(darkRoast);

            Console.WriteLine($"3. {houseBlend.Description}");
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

            Console.WriteLine($"-> {withMocha.Description}: {withMocha.Cost()}");
            Console.WriteLine($"-> {withWhip.Description}: {withWhip.Cost()}");
            Console.WriteLine($"-> {withMochaAndWhip.Description}: {withMochaAndWhip.Cost()}");
            Console.WriteLine($"-> {withSoy.Description}: {withSoy.Cost()}");
            Console.WriteLine($"-> {withSoyAndWhip.Description}: {withSoyAndWhip.Cost()}");
            Console.WriteLine($"-> {withSoyAndMocha.Description}: {withSoyAndMocha.Cost()}");
            Console.WriteLine($"-> {withMochaAndWhipAndSoy.Description}: {withMochaAndWhipAndSoy.Cost()}");
        }
    }
}
