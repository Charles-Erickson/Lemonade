﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Inventory
    {
        public double StartingMoney = 20.00;
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
            void AddSupplies()
            {
                Supplies.Add(lemons.ItemCount);
                Supplies.Add(sugar.ItemCount);
                Supplies.Add(ice.ItemCount);
                Supplies.Add(cups.ItemCount);
            }
            

        }

    }    
}