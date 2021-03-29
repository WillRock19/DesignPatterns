namespace Observer.Domain
{
    public class CurrentWeatherData
    {
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }

        public bool IsSameAs(CurrentWeatherData otherData) =>
            Temperature == otherData.Temperature 
         && Humidity == otherData.Humidity 
         && Pressure == otherData.Pressure;
    }
}
