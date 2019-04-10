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
        public Recipe recipe;


      

        public Inventory()
        {
            store = new Store();
            recipe = new Recipe();
            LemonStock = LemonStock+store.BoughtLemons;
            SugarStock = SugarStock + store.BoughtSugar;
            IceStock = IceStock + store.BoughtIce;
            CupStock = CupStock + store.BoughtCups;
        }


        public void UseStock()
        {
            if (LemonStock >= recipe.lem && SugarStock >= recipe.sug && IceStock >= recipe.ice)
            {
                LemonStock = LemonStock - recipe.lem;
                SugarStock = SugarStock - recipe.sug;
                LemonStock = LemonStock - recipe.lem;
            }
            else if (LemonStock < recipe.lem || SugarStock < recipe.sug || IceStock < recipe.ice)
            {
                Console.WriteLine("You've sold out of Lemonade.");
                Console.ReadKey();
            }
        }
    } 
}