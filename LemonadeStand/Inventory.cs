using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Inventory
    {

        public int LemonStock;
        public int SugarStock;
        public int IceStock;
        public int CupStock;
        public Store store;
        public Lemons lemons;
        public Sugar sugar;
        public Ice ice;
        public Cups cups;
        public Recipe recipe;
        public List<int> Supplies;
        List<int> ComparingSuppliesAndRecipe;
        //methods

      

        public Inventory()
        {
            lemons = new Lemons();
            sugar = new Sugar();
            ice = new Ice();
            cups = new Cups();
            store = new Store();
            recipe = new Recipe();
            Supplies = new List<int>();
            LemonStock = lemons.ItemCount;
            SugarStock = sugar.ItemCount;
            IceStock = ice.ItemCount;
            CupStock = cups.ItemCount;
        }


        public void UseStock()
        {
            LemonStock = LemonStock - recipe.lem;
            SugarStock = SugarStock - recipe.sug;
            LemonStock = LemonStock - recipe.lem;
        }
        



       




    } 
}