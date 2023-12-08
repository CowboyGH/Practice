using System.Net;
using Newtonsoft.Json;

namespace ConsoleWeather;

class Program
{
    static void Main()
    {
        string cityPath = @"C:\Users\denko\RiderProjects\ConsoleWeather\ConsoleWeather\bin\Debug\net7.0\statham.txt";
        string defaultCity = File.ReadAllText(cityPath);

        if (string.IsNullOrWhiteSpace(defaultCity))
        {
            Console.Write("Enter the default city -> ");
            defaultCity = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(cityPath))
            {
                writer.Write(defaultCity);
            }
        }

        try
        {
            WeatherSettings defaultweatherInfo = GetWeather(defaultCity);
            
            Console.WriteLine($"City: {defaultCity}");
            Console.WriteLine($"Weather Type: {defaultweatherInfo.weather[0].main}");
            Console.WriteLine($"Description: {defaultweatherInfo.weather[0].description}");
            Console.WriteLine($"Temperature: {defaultweatherInfo.main.temp}°C");
            Console.WriteLine($"Feels like: {defaultweatherInfo.main.feels_like}°C");
            Console.WriteLine($"Wind speed: {defaultweatherInfo.wind.speed} м/с");
            Console.WriteLine();
        }
        catch
        {
            Console.WriteLine("No data on entered city.");
            Console.Write("Enter the correct default city -> ");
            defaultCity = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(cityPath))
            {
                writer.Write(defaultCity);
            }
        }
       
        Console.Write("Enter city name -> ");
        string city = Console.ReadLine();
        Console.WriteLine();

        try
        {
            WeatherSettings weatherInfo = GetWeather(city);
            
            Console.WriteLine($"City: {city}");
            Console.WriteLine($"Weather Type: {weatherInfo.weather[0].main}");
            Console.WriteLine($"Description: {weatherInfo.weather[0].description}");
            Console.WriteLine($"Temperature: {weatherInfo.main.temp}°C");
            Console.WriteLine($"Feels like: {weatherInfo.main.feels_like}°C");
            Console.WriteLine($"Wind speed: {weatherInfo.wind.speed} м/с");
        }
        catch
        {
            Console.WriteLine("No data on entered city.");
        }

        static WeatherSettings GetWeather(string city)
        {
            string apiKey = "0098a46bf2b364406e28baf6d52dd45f";
            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            using (WebClient client = new WebClient())
            {
                string str = client.DownloadString(apiUrl);
                WeatherSettings weather = JsonConvert.DeserializeObject<WeatherSettings>(str);
                return weather;
            }
        }
    }
}
