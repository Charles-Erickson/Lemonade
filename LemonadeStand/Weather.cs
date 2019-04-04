using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Weather
    {
        string Sunny="Sunny";
        int SunnyScore = 1;
        string Cloudy = "Cloudy";
        int CloudyScore = 0;
        string Foggy = "Foggy";
        int FoggyScore = -1;
        string Rainy = "Rainy";
        int RainyScore = -2;
        string GameWeather;
        int WeatherScore;
        int Tempeture;
        int TempScore;
        int WeatherNumber;
        public int FindWeathernumber()
        {
            Random DailyWeatherNumber = new Random();
            int DailyWeather = DailyWeatherNumber.Next(1, 4);
            return WeatherNumber;
        }

        public int WeatherForTheDay(int number)
        {
            switch (number)
            {
                case 1:
                    WeatherScore = SunnyScore;
                    return WeatherScore;
                case 2:
                    WeatherScore = CloudyScore;
                    return WeatherScore;
                case 3:
                    WeatherScore = FoggyScore;
                    return WeatherScore;
                case 4:
                    WeatherScore = RainyScore;
                    return WeatherScore;
            }
            return WeatherScore;
        }


        public string FindGameWeather (int number)
        {
            switch (number)
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
            return GameWeather;
        }

        public int CalculateTemp()
        {
            Random TempetureRange = new Random();
            Tempeture = TempetureRange.Next(50, 99);
            return Tempeture;
        }

        public int FindTempScore(int Temp)
        {
            if (Temp < 55)
            {
                TempScore = -2;
                return TempScore;
            }
            else if (Temp >= 55 && Temp < 65)
            {
                TempScore = -1;
                return TempScore;
            }
            else if (Temp >= 65 && Temp < 75)
            {
                TempScore = 0;
                return TempScore;
            }
            else if (Temp >= 75)
            {
                TempScore = 1;
                return TempScore;
            }
            return TempScore;
        }
        public void DayGameWeather()
        {
            WeatherNumber=FindWeathernumber();
            Tempeture= CalculateTemp();
            FindTempScore(Tempeture);
            WeatherForTheDay(WeatherNumber);
            FindGameWeather(WeatherNumber);
        }
        public Forecast Forecast;
    
    }
}