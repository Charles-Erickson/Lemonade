using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        public int Odds;
        public int OddsToBuy()
        {
            Random OddsRange = new Random();
             Odds= OddsRange.Next(1, 10);
            return Odds;
        }
        public bool BoughtOrNot()
        {
            if(Odds<=LikelyhoodToBuyLemonade && SpareMoney >= PricePerCup)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Customer Customer;

        public Store Store;

        public Player Player;

        public UserInterface UserInterface;

        public Day Day;

        public Inventory Inventory
        {
            get => default(Inventory);
            set
            {
            }
        }
    }
}