using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
       float Time;
        int CustomerNumber;
        public int CustomersPerDay()
        {
            Random CustomerRange = new Random();
            CustomerNumber = CustomerRange.Next(70, 110);
            return CustomerNumber;
        }
        public Weather Weather;
        
           
        
    }
}