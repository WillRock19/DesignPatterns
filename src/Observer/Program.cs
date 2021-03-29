using Microsoft.Extensions.DependencyInjection;
using Observer.Configurations;
using Observer.Services;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var serviceProvider = new DepedencyInjectionConfig().ConfigureInjections();
            serviceProvider.GetRequiredService<CurrentConditionsDisplayService>();

            while (true) { }
        }
    }
}
