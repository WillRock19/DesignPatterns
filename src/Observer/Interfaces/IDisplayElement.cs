using Observer.Domain;

namespace Observer.Interfaces
{
    public interface IDisplayElement
    {
        void Display(CurrentWeatherData meteorologicData);
    }
}
