using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        public Customer customer;
        int CustomerNumber;
        public Weather weather;
        public Inventory inventory;
        public int CustomersPerDay()
        {
            Random CustomerRange = new Random();
            CustomerNumber = CustomerRange.Next(70, 110);
            return CustomerNumber;
        }

        public Day()
        {
            weather = new Weather();
            customer = new Customer();
        
            weather.DayGameWeather();
            
            void DailyCustomer(int range)
            {
                int i;
                for (i = 0; i < range; i++);
            }

                       



        }
    }
}