﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Sugar : Supply
    {
        public Sugar()
        {
            price = .05;
            name = "sugar";
            ItemCount = 0;
        }
    }
}