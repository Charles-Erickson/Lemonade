using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Customer
    {
        private double SpareMoney;
        private int LikelyhoodToBuyLemonade=5;
        public double PocketChange()
        {
            Random MoneyRange = new Random();
            SpareMoney = MoneyRange.NextDouble() * (1.5 - .2) + .2;
            return SpareMoney;
        }
        public int WantToPay(string Weather,int Temp, int sugar, int lemons, int ice)
        {

        }

    }
}