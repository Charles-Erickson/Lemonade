using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Cups : Supply
    {
        public Cups()
        {
            price = .10;
            name = "cups";
            ItemCount = 0;
        }
    }
}