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
        public int RemainingCups=10;
        public double PriceOfLemonade;
        public int RecipeScore;
        public List<int> PitcherRecipe;

        public Recipe()
        {
            PitcherRecipe = new List<int>();
            lem = PickLemons();
            sug = PickSugar();
            ice = PickIce();           
        }

        public void AddToPitcher()
        {
            PitcherRecipe.Add(lem);
            PitcherRecipe.Add(sug);
            PitcherRecipe.Add(ice);
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

        public int FindRecipeScore(int lem, int sugar, int ice)
        {
            if (lem > 3 && sugar > 6 && ice > 3)
            {
                RecipeScore = 1;
                return RecipeScore;
            }
            else if (lem > 2 && sugar > 4 && ice > 2)
            {
                RecipeScore = 0;
                return RecipeScore;
            }
            else if (lem > 1 && sugar > 3 && ice > 1)
            {
                RecipeScore = -1;
                return RecipeScore;
            }
            return RecipeScore;
        }
        public void MakeLemondae()
        {
            PickLemons();
            PickSugar();
            PickIce();

        }
    


    }
}