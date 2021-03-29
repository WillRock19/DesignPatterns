using Observer.Domain;
using Observer.Interfaces;
using System.Collections.Generic;

namespace Observer.Services
{
    public class WheatherDataService : ISubject
    {
        private readonly List<IObserver> _observers;
        private readonly IWheaterGetterService _wheaterGetterService;
        private readonly TimerService _timerService;

        private CurrentWeatherData _currentMeteorologicData;

        public WheatherDataService(IWheaterGetterService wheaterGetterService, TimerService timerService)
        {
            _timerService = timerService;
            _observers = new List<IObserver>();
            _wheaterGetterService = wheaterGetterService;

            SetTimerToCheckForDataUpdates();
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
            var data = _wheaterGetterService
                .GetCurrentWheaterInformation();

            if (_currentMeteorologicData != null && _currentMeteorologicData.IsSameAs(data))
                return;

            _currentMeteorologicData = data;
            
            _observers.ForEach(observer => 
                observer.Update(_currentMeteorologicData));
        }

        private void SetTimerToCheckForDataUpdates() 
        {
            _timerService
                .ExecuteActionAfterInterval(NotifyObservers)
                .Start();
        }
    }
}
