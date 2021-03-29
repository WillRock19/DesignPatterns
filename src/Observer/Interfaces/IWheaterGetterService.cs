using Observer.Domain;

namespace Observer.Interfaces
{
    public interface IWheaterGetterService
    {
        MeteorologicData GetCurrentWheaterInformation();
    }
}
