using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Recipe
    {
        public int lem;
        public int sug;
        public int ice;
        public int cup;
        public double PriceOfLemonade;
        public List<int> PitcherRecipe;

        public Recipe()
        {
            PitcherRecipe = new List<int>();
            void AddToPitcher()
            {
                PitcherRecipe.Add(PickLemons());
                PitcherRecipe.Add(PickSugar());
                PitcherRecipe.Add(PickIce());
            }
        }

        public int PickLemons()
        {
            Console.WriteLine("How many lemons?");
            lem = int.Parse(Console.ReadLine());
            return lem;
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
            sug = int.Parse(Console.ReadLine());
            return sug;
        }


    }
}