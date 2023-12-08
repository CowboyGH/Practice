public class WeatherSettings
{
    public WeatherTypeInfo[] weather { get; set; }
    public TemperatureInfo main { get; set; }
    public WindSpeedInfo wind { get; set; }
}

public class WeatherTypeInfo
{
    public string main { get; set; }
    public string description { get; set; }
}

public class TemperatureInfo
{
    public float temp { get; set; }
    public float feels_like { get; set; }
}

public class WindSpeedInfo
{
    public float speed { get; set; }
}
