using Observer.Domain;
using System;

namespace Observer.Interfaces
{
    public interface IObserver
    {
        Guid Identifier { get; }
        void Update(CurrentWeatherData meteorologicData);
    }
}
