using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Weather Weather = new Weather();
            Inventory Inventory = new Inventory();
            Recipe Recipe = new Recipe();
            Customer Customer = new Customer();
            Player Player = new Player();
            Store Store = new Store();
            Day Day = new Day();
            Game game = new Game();
            Store.CalculateNewCashTotal();

        }
    }
}
