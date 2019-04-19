using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Store
    {
        public string Name;
        public double TotalCost;
        public double PricePerLemon = .15;
        public double PricePerCupOfSugar = .05;
        public double PricePerIce = .05;
        public double PricePerCup = .10;
        public double price;
        public double Cost;
        public int item;
        public int BoughtLemons;
        public int BoughtSugar;
        public int BoughtIce;
        public int BoughtCups;
        //methods

        public Store()
        {

        }

                public string WhatToBuy()
                {            
                Console.WriteLine("Would you like to buy Lemons .15 each, Ice .05 each, Sugar .05 each, or Cups .10 each?");
                string Name = Console.ReadLine();
                string item = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(Name.ToLower());
                switch (item)
                   {
                    case "Lemons":
                        return Name;
                    case "Ice":
                        return Name;
                    case "Sugar":
                        return Name;
                    case "Cups":
                        return Name;
                    default:
                        Console.WriteLine("Please enter a real item name.");
                        Console.ReadKey();
                        return WhatToBuy();
                    }
                }

            public int AddToStock(string name)
            {

                switch (name)
                {
                    case "Lemons":
                    Console.WriteLine("How many Lemons would you like to purchase?");
                    try
                    {
                        item = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Value needs to be a number");
                    }
                    item = BoughtLemons+item;
                        return item;
                    case "Sugar":
                    Console.WriteLine("How much sugar would you like to purchase?");
                    try
                    {
                        item = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Value needs to be a number");
                    }
                    item = BoughtSugar+item;
                        return item;
                    case "Ice":
                    Console.WriteLine("How much Ice would you like to purchase?");
                    try
                    {
                        item = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Value needs to be a number");
                    }
                    item = BoughtIce+item;
                        return item;
                    case "Cups":
                    Console.WriteLine("How many would you like to purchase?");
                    try
                    {
                        item = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Value needs to be a number");
                    }
                    item = BoughtCups+item;
                        return item;
                    default:
                        return 0;
                }
              
            }

            public double TotalCashSpent(string name)
            {
                AddToStock(name);
                double price = PurchaseItemPrice(name);
                Cost = Cost+ price * item;
                Console.WriteLine(Cost);
                Console.ReadKey();
                Console.WriteLine("Would you like to buy more? Yes or no.");
                string test = Console.ReadLine();
                switch (test)
                {
                    case "yes":
                        TotalCost = TotalCost + Cost;
                        WhatToBuy();
                        return TotalCashSpent(name);
                    case "no":
                        TotalCost = TotalCost+ Cost;
                        return TotalCost;
                    default:
                        Console.WriteLine("Please enter 'yes'or 'no'");
                        Console.ReadKey();
                        WhatToBuy();                    
                        return TotalCashSpent(name);
                }                
            }

            public double CalculateNewCashTotal(Player play)
            {
                 string name= WhatToBuy();

                TotalCashSpent(name);
                double cash=play.StartingMoney;
                if (TotalCost > cash)
                {
                    Console.WriteLine("Not enough Funds for Purchase");
                    Console.ReadKey();
                    return CalculateNewCashTotal(play);
                }
                else if (TotalCost<= cash)
                {
                    play.StartingMoney = cash - TotalCost;
                    Console.WriteLine("Your new cash total is " + cash);
                    return cash;
                }
                return cash;
            }        

        public double PurchaseItemPrice(string name)
        {

            switch (name)
            {
                case "Lemons":
                    price = PricePerLemon;
                    return price;
                case "Ice":
                    price = PricePerIce;
                    return price;
                case "Sugar":
                    price = PricePerCupOfSugar;
                    return price;
                case "Cups":
                    price = PricePerCup;
                    return price;
                default:
                    return 0.00;
            }
        }                    
    }    
}