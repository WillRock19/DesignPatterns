using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Observer.Interfaces;
using Observer.Services;
using System;
using System.IO;

namespace Observer.Configurations
{
    class DepedencyInjectionConfig
    {
        public IServiceProvider ConfigureInjections()
        {
            var configurations = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false)
                .Build();

            var serviceProvider = new ServiceCollection()
                .AddTransient<ISubject, WheatherDataService>()
                .AddTransient<IWheaterGetterService, WheaterGetterService>()
                .AddTransient<CurrentConditionsDisplayService>()
                .AddSingleton<TimerService>()
                .AddSingleton(x => configurations)
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}
