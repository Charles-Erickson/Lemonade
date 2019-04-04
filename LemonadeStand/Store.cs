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

            double PurchaseItemPrice(string name)
            {

                double price;
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
                        return 0.00;
                }
            }

                string WhatToBuy()
                {            
                Console.WriteLine("Would you like to buy Lemons, Ice, Sugar, or Cups?");
                string Name = Console.ReadLine();
                string item = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(Name.ToLower());
                switch (item)
                    {
                    case "Lemons":
                        return item;
                    case "Ice":
                        return item;
                    case "Sugar":
                        return item;
                    case "Cups":
                        return item;
                    default:
                        Console.WriteLine("Please enter a real item name.");
                        Console.ReadKey();
                        return WhatToBuy();
                    }
                }

            double TotalCashSpent()
            {
                string name=WhatToBuy();
                TotalCost=0;
                double price = PurchaseItemPrice(name);
                Console.WriteLine("How many would you like to purchase?");
                int number = 0;
                try
                {
                    number = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Value needs to be a number");
                }
                double Cost = price * number;
                Console.WriteLine("Would you like to buy more?");
                string item = Console.ReadLine();
                switch (item)
                {
                    case "yes":
                        TotalCost = TotalCost + Cost;
                        return TotalCashSpent();
                    case "no":
                        TotalCost = TotalCost+ Cost;
                        return TotalCost;
                    default:
                        Console.WriteLine("Please enter 'yes'or 'no'");
                        Console.ReadKey();
                        return TotalCashSpent();
                }                
            }

            double CalculateNewCashTotal()
            {
                TotalCashSpent();
                double cash=inventory.StartingMoney;
                if (TotalCost > cash)
                {
                    Console.WriteLine("Not enough Funds for Purchase");
                    Console.ReadKey();
                    return CalculateNewCashTotal();
                }
                else if (TotalCost <= cash)
                {
                    cash = cash - TotalCost;
                    Console.WriteLine("Your new cash total is " + cash);
                    return cash;
                }
                return cash;
            }
            
        }

    }
}