using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Customer
    {
        private double SpareMoney;
        private int LikelyhoodToBuyLemonade;
        public double PocketChange()
        {
            Random MoneyRange = new Random();
            SpareMoney = MoneyRange.NextDouble() * (1.5 - .2) + .2;
            return SpareMoney;
        }
        public int WantToPay(int weatherscore,int Temp, int recipe)
        {
            Random rnd = new Random();
            int StartingOdds = rnd.Next(3,6);
            LikelyhoodToBuyLemonade = StartingOdds + weatherscore + Temp + recipe;
            return LikelyhoodToBuyLemonade;
        }

    }
}