using Observer.Domain;

namespace Observer.Interfaces
{
    public interface IWheaterGetterService
    {
        CurrentWeatherData GetCurrentWheaterInformation();
    }
}
