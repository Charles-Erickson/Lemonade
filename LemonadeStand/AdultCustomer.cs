using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class AdultCustomer
    {
        public new double SpareMoney;
        public new int LikelyhoodToBuyLemonade;
        public new int StartingOdds;
        public Weather weather;
        public Recipe recipe;

        public AdultCustomer()
        {
            weather = new Weather();
            recipe = new Recipe();
        }


        public new double PocketChange()
        {
            Random MoneyRange = new Random();
            SpareMoney = MoneyRange.NextDouble() * (1 - .2) + .2;
            return SpareMoney;
        }

        public new int CustomerOdds()
        {
            Random rnd = new Random();
            StartingOdds = rnd.Next(3, 6);
            return StartingOdds;
        }

        public new int WantToPay(int odds, int weatherscore, int Temp, int recipe)
        {
            LikelyhoodToBuyLemonade = odds + weatherscore + Temp + recipe;
            return LikelyhoodToBuyLemonade;
        }

        public new void CustomerForTheDay()
        {
            LikelyhoodToBuyLemonade = WantToPay(StartingOdds, weather.WeatherScore, weather.TempScore, recipe.RecipeScore);
            PocketChange();
        }
    }
}
