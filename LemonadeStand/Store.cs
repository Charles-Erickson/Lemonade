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
        public Player player;
        public string Name;
        public double TotalCost;
        //methods

        public Store()
        {
            lemons = new Lemons();
            sugar = new Sugar();
            ice = new Ice();
            cups = new Cups();
            player = new Player();
            Name = WhatToBuy();
            TotalCost = TotalCashSpent(Name);
        }



                public string WhatToBuy()
                {            
                Console.WriteLine("Would you like to buy Lemons .15 each, Ice .05 each, Sugar .05 each, or Cups .10 each?");
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

            public int AddToStock(string name)
            {
                int item;
                switch (name)
                {
                    case "Lemons":
                        item = lemons.ItemCount;
                        return item;
                    case "Sugar":
                        item = sugar.ItemCount;
                        return item;
                    case "Ice":
                        item = ice.ItemCount;
                        return item;
                    case "Cups":
                        item = cups.ItemCount;
                        return item;
                    default:
                        return 0;
                }
              
            }

            public double TotalCashSpent(string name)
            {
                TotalCost=0;
                double Cost = 0;
                int Numb = AddToStock(name);
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
                Cost = Cost+ price * number;
                Console.WriteLine(Cost);
                Console.ReadKey();
                Console.WriteLine("Would you like to buy more?");
                string item = Console.ReadLine();
                switch (item)
                {
                    case "yes":
                        TotalCost = TotalCost + Cost;
                        WhatToBuy();
                        return TotalCashSpent(name);
                    case "no":
                        Numb = Numb + number;
                        TotalCost = TotalCost+ Cost;
                        return TotalCost;
                    default:
                        Console.WriteLine("Please enter 'yes'or 'no'");
                        Console.ReadKey();
                        WhatToBuy();                    
                        return TotalCashSpent(name);
                }                
            }

            public double CalculateNewCashTotal()
            {
                 string name= WhatToBuy();

                TotalCashSpent(name);
                double cash=player.StartingMoney;
                if (TotalCost > cash)
                {
                    Console.WriteLine("Not enough Funds for Purchase");
                    Console.ReadKey();
                    return CalculateNewCashTotal();
                }
                else if (TotalCost<= cash)
                {
                    cash = cash - TotalCost;
                    Console.WriteLine("Your new cash total is " + cash);
                    return cash;
                }
                return cash;
            }

        

        public double PurchaseItemPrice(string name)
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
      

        

    }
    
}