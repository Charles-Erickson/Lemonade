using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public abstract class UserInterface
    {
        public int BoughtItem()
        {
            int number=int.Parse(Console.ReadLine());
            return number;
        }
        public decimal PricePerCup()
        {
            decimal price=Decimal.Parse(Console.ReadLine());
            return price;
        }
        public int ItemsPerPitcher()
        {
            int items= int.Parse(Console.ReadLine());
            return items;
        }
    }
}