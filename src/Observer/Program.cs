using Microsoft.Extensions.DependencyInjection;
using Observer.Configurations;
using Observer.Services;

namespace Observer
{
    class Program
    {
        static void Main()
        {
            var serviceProvider = new DepedencyInjectionConfig().ConfigureInjections();
            serviceProvider.GetRequiredService<CurrentConditionsDisplayService>();

            while (true) { }
        }
    }
}
