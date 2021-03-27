using Observer.Domain;
using Observer.Interfaces;
using System.Collections.Generic;

namespace Observer.Services
{
    public class WheatherDataService : ISubject
    {
        private readonly List<IObserver> _observers;
        private MeteorologicData _currentMeteorologicData;

        public WheatherDataService()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            var observerExists = _observers
                .Exists(x => x.Identifier == observer.Identifier);

            if (observerExists)
                _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            var data = GetUpdatedMeteorologicData();

            if (_currentMeteorologicData.IsSameAs(data))
                return;

            _currentMeteorologicData = data;
            
            _observers.ForEach(observer => 
                observer.Update(_currentMeteorologicData));
        }

        private MeteorologicData GetUpdatedMeteorologicData() 
        {
            return null;
        }
    }
}
