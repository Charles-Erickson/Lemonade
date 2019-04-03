using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public abstract class UserInterface
    {
        int BoughtItem= int.Parse(Console.ReadLine());     
        decimal PricePerCup = Decimal.Parse(Console.ReadLine());
        int ItemsPerPitcher= int.Parse(Console.ReadLine());
    }
}