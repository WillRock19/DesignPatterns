using Observer.Domain;
using Observer.Interfaces;
using System;

namespace Observer.Services
{
    public class WheaterGetterService : IWheaterGetterService
    {
        public MeteorologicData GetCurrentWheaterInformation()
        {
            return new MeteorologicData 
            {
                Humidity = 19,
                Pressure = 88,
                Temperature = 34
            };
        }
    }
}
