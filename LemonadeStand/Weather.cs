using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Weather
    {
        string Sunny;
        string Cloudy;
        string Foggy;
        string Rainy;
        string GameWeather;
        int Tempeture;
        public string WeatherForTheDay()
        {
            Random DailyWeatherNumber = new Random();
            int DailyWeather = DailyWeatherNumber.Next(1, 4);
            switch (DailyWeather)
            {
                case 1:
                    GameWeather = Sunny;
                    return GameWeather;
                case 2:
                    GameWeather = Cloudy;
                    return GameWeather;
                case 3:
                    GameWeather = Foggy;
                    return GameWeather;
                case 4:
                    GameWeather = Rainy;
                    return GameWeather;

            }
        }

        public int CalculateTemp()
        {
            Random TempetureRange = new Random();
            Tempeture = TempetureRange.Next(50, 99);
            return Tempeture;
        }

        public Forecast Forecast;
    
    }
}