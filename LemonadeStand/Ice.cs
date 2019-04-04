using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Ice : Supply
    {
        public Ice()
        {
            price = .05;
            name = "ice";
        }
    }
}