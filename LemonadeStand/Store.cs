using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Store
    {
        public Lemons lemons;
        public Sugar sugar;
        public Ice ice;
        public Cups cups;
        public Inventory inventory;
        public double TotalCost;
        //methods

        public Store()
        {
            lemons = new Lemons();
            sugar = new Sugar();
            ice = new Ice();
            cups = new Cups();
            inventory = new Inventory();

            double PurchaseItemPrice()
            {
                double price;
                Console.WriteLine("Would you like to buy Lemons, Ice, Sugar, or Cups?");
                string Name= Console.ReadLine();
                string name=System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(Name.ToLower());
                switch (name)
                {
                    case "Lemons":
                        price = lemons.price;
                        return price;
                    case "Ice":
                        price = ice.price;
                        return price;
                    case "Sugar":
                        price = sugar.price;
                        return price;
                    case "Cups":
                        price = cups.price;
                        return price;
                    default:
                        Console.WriteLine("Please enter a real item name.");
                        Console.ReadKey();            
                        return PurchaseItemPrice();
                }
            }
        }

    }
}