﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Player
    {


        public double StartingMoney = 20.00;
        public int soldInventory;
        public double PricePerCup;

        public Player()
        {

        }

        public double SetPrice()
        {
            Console.WriteLine("How much would you like to sell your Lemonade for today?");
            PricePerCup = 0;
            try
            {
                PricePerCup = Double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Value needs to be a number");
            }
            return PricePerCup;
        }
    }


       
}