using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Inventory
    {
        int LemonStock;
        int SugarStock;
        int CupStock;
        int IceStock;
        int PitchersOfLemonade;
        int GlassesOfLemonade;

        public Recipe Recipe
        {
            get => default(Recipe);
            set
            {
            }
        }

        public int FindLemonStock()
        {
            LemonStock = UserInterface.BoughtItem;
            return LemonStock;
        }
        public int FindSugarStock()
        {
            SugarStock = UserInterface.BoughtItem;
            return SugarStock;
        }
        public int FindCupStock()
        {
            CupStock = UserInterface.BoughtItems;
            return CupStock;
        }
        public int FindIceStock()
        {
            IceStock = UserInterface.BoughtItems;
            return IceStock;
        }
        public PitcherRecipe()
        {

        }
        
    }
}