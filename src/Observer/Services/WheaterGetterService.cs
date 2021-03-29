using Microsoft.Extensions.Configuration;
using Observer.Domain;
using Observer.Interfaces;
using System;
using System.IO;
using System.Text.Json;

namespace Observer.Services
{
    public class WheaterGetterService : IWheaterGetterService
    {
        private readonly string _dataPath;

        public WheaterGetterService(IConfigurationRoot configurations)
        {
            _dataPath = configurations
                .GetSection("weatherData")
                .GetSection("path").Value;
        }

        public CurrentWeatherData GetCurrentWheaterInformation()
        {
            var weatherData = LoadWeatherData();
            return weatherData.CurrentWeather;
        }

        private MeteorologicData LoadWeatherData() 
        {
            try 
            {
                using var stream = new StreamReader(Path.Combine(Directory.GetCurrentDirectory(), _dataPath));
                var json = stream.ReadToEnd();
                return JsonSerializer.Deserialize<MeteorologicData>(json);
            }
            catch(Exception e)
            {
                throw new FileLoadException("The program could not load the weatherdata informations!", e);
            }
        }
    }
}
