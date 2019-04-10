﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Customer
    {
        public double SpareMoney;
        public int LikelyhoodToBuyLemonade;
        public int StartingOdds;
        public Weather weather;
        public Recipe recipe;

        public Customer()
        {
            weather = new Weather();
            recipe = new Recipe();
        }

        public double PocketChange()
        {
            Random MoneyRange = new Random();
            SpareMoney = MoneyRange.NextDouble() * (1.5 - .2) + .2;
            return SpareMoney;
        }

        public int CustomerOdds()
        {
            Random rnd = new Random();
            StartingOdds = rnd.Next(3, 6);
            return StartingOdds;
        }

        public int WantToPay(int odds, int weatherscore,int Temp, int recipe)
        {
            LikelyhoodToBuyLemonade = odds + weatherscore + Temp + recipe;
            return LikelyhoodToBuyLemonade;
        }

        public void CustomerForTheDay()
        {
            LikelyhoodToBuyLemonade=WantToPay(StartingOdds, weather.WeatherScore, weather.TempScore, recipe.RecipeScore);
            PocketChange();
        }
       

    }
}