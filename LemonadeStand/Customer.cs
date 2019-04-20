using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public abstract class Customer
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
            return 0;
        }

        public int CustomerOdds()
        {
            return 0;
        }

        public int WantToPay(int odds, int weatherscore,int Temp, int recipe)
        {
            return 0;
        }

        public void CustomerForTheDay()
        {
           
        }       
    }
}