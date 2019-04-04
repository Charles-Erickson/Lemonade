using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Inventory
    {
        public double StartingMoney = 20.00;
        public List<int> supplies;
        public Store store;
        public Lemons lemons;
        public Sugar sugar;
        public Ice ice;
        public Cups cups;
        //methods

       

        public Inventory()
        {
            supplies = new List<int>
            {


            };
        }

    }    
}