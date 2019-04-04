using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Player
    {

        public Inventory inventory;
        public int soldInventory;

        public Player()
        {
            inventory = new Inventory();
        }
        public int SellLemonade(List<Customer> customer)
        {
            soldInventory = 0;
            for (int i = 0; i < customer.Count; i++)
            {
                if (inventory.supplies[4].Count == 0)
                {
                    Console.WriteLine("You sold out!!!!!");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    if (customer[i].LikelyhoodToBuyLemonade >= Odds&& PockectChange>=PriceOfLemonade)
                    {
                        soldInventory++;
                        inventory.supplies[4].RemoveAt(0);
                    }
                    else
                    {
 
                    }
                }
            }
            return soldInventory;
        }
    }
       
}