using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        public Customer customer;
        public int CustomerNumber;
        public int Odds;
        public Weather weather;
        public Inventory inventory;
        public Recipe recipe;
        public Player player;


        

        public Day()
        {
            weather = new Weather();
            customer = new Customer();
            inventory = new Inventory();
            recipe = new Recipe();
            player = new Player();
  
        }


        public int CustomersPerDay()
        {
            Random CustomerRange = new Random();
            CustomerNumber = CustomerRange.Next(70, 110);
            return CustomerNumber;
        }

        public int OddsToBuy()
        {
            Random OddsRange = new Random();
            Odds = OddsRange.Next(1, 10);
            return Odds;
        }

        public bool BoughtOrNot()
        {
            if (Odds <= customer.LikelyhoodToBuyLemonade && customer.SpareMoney >= player.PricePerCup)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DailyCustomer(int range)
        {
            int i;
            for (i = 0; i < range; i++)
            {
                customer.CustomerForTheDay();
                customer.CustomerOdds();
                BoughtOrNot();

            }

        }




        public void RunDayFunction()
            {

                weather.DayGameWeather();
            Console.WriteLine("Welcome to a new day. The weather is " + weather.GameWeather + " The Temperature is " + weather.Tempeture);
            DailyCustomer(CustomersPerDay());

            }

                       



        
    }
}