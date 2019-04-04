using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Inventory
    {
        public double money = 20.00;
        public List<int> supplies;
        public double profit;
        public Lemons lemons;
        //methods

       

        public Inventory()
        {
            lemons = new Lemons();
            supplies = new List<int>
            {
                lemons.ItemCount


            };
        }

    }    
}