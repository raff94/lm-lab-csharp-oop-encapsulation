using System;
namespace Encapsulation.Models
{
    public enum LocationCity { London, California, CapeTown, Unknown }

    public class WeatherReporter
    {
        private readonly LocationCity Location;
        private readonly double TemperatureInCelsius;
        private const double MinTemperature = 10;
        private const double MaxTemperature = 30;

        private double TemperatureInFahrenheit() => CelsiusToFahrenheit(TemperatureInCelsius);
        private double CelsiusToFahrenheit(double celsius) => (9.0 / 5.0) * celsius + 32;

        public WeatherReporter(LocationCity location, double temperatureInCelsius)
        {
            Location = location;
            TemperatureInCelsius = temperatureInCelsius;
        }

        public string GetWeatherReport()
        {
            return $"I am in {Location} and it is {GetLocationIcon()}. {GetTemperatureDescription()}. The temperature in Fahrenheit is {TemperatureInFahrenheit()}.";
        }

        public string GetLocationIcon()
        {
            string result = "";

            switch (Location)
            {
                case LocationCity.London:
                    {
                        result = "🌦";
                        break;
                    }
                case LocationCity.California:
                    {
                        result = "🌅";
                        break;
                    }
                case LocationCity.CapeTown:
                    {
                        result = "🌤";
                        break;
                    }
                default:
                case LocationCity.Unknown:
                    {
                        result = "🔆";
                        break;
                    }
            }

            return result;
        }

        public string GetTemperatureDescription()
        {
            string result = "";

            if (TemperatureInCelsius > MaxTemperature)
            {
                result = "It's too hot 🥵!";
            }
            else if (TemperatureInCelsius < MinTemperature)
            {
                result = "It's too cold 🥶!";
            }
            else
                result = "Ahhh...it's just right 😊!";

            return result;
        }

    }
}

