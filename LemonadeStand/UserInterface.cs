using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public abstract class UserInterface
    {
        int BoughtLemons= int.Parse(Console.ReadLine());
        int BoughtSugar=int.Parse(Console.ReadLine());
        int BoughtCups = int.Parse(Console.ReadLine());
        int BoughtIce = int.Parse(Console.ReadLine());
       decimal PricePerCup = Decimal.Parse(Console.ReadLine());
    }
}