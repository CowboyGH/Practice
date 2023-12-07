using System.Net;
using Newtonsoft.Json.Linq;

namespace ConsoleWeather;

class Program
{
    const string DefaultCity = "Томск";
    const string ApiKey = "0098a46bf2b364406e28baf6d52dd45f";

    static void Main(string[] args)
    {
        string city;

        if (args.Length > 0)
        {
            city = args[0];
        }
        else
        {
            Console.WriteLine("Enter the default city:");
            city = Console.ReadLine();
        }
    }
}