using Observer.Domain;
using Observer.Interfaces;
using System;

namespace Observer.Services
{
    class CurrentConditionsDisplayService : IObserver
    {
        public Guid Identifier => _identifier;
        
        private readonly Guid _identifier;
        private readonly ISubject _wheatherData;

        public CurrentConditionsDisplayService(ISubject wheatherData)
        {
            _identifier = Guid.NewGuid();
            _wheatherData = wheatherData;

            _wheatherData.RegisterObserver(this);
        }

        public void Update(MeteorologicData meteorologicData)
        {
            Display(meteorologicData);
        }

        public void Display(MeteorologicData meteorologicData) 
        {
            Console.WriteLine("Current conditions are: ");
            Console.WriteLine($"-> Atmosferic Pressure: {meteorologicData.Pressure}");
            Console.WriteLine($"-> Temperature: {meteorologicData.Temperature}");
            Console.WriteLine($"-> Humidity: {meteorologicData.Humidity}");
        }
    }
}
