using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Recipe
    {
        public int lemons;
        public int sugar;
        public int ice;
        public int cups;
        public double PriceOfLemonade;

        public int PickLemons()
        {
            Console.WriteLine("How many lemons?");
            lemons = int.Parse(Console.ReadLine());
            return lemons;
        }

        public int PickIce()
        {
            Console.WriteLine("How much ice?");
            ice = int.Parse(Console.ReadLine());
            return ice;
        }

        public int PickSugar()
        {
            Console.WriteLine("How much sugar?");
            sugar = int.Parse(Console.ReadLine());
            return sugar;
        }

    }
}