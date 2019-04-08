using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        public Customer customer;

        public Store store;

        public Player player;

        public UserInterface userinterface;

        public Day day;

        public Inventory inventory;

        public Game()
        {
            customer = new Customer();
            store = new Store();
            inventory = new Inventory();
            day = new Day();
            player = new Player();

        }
        public void RunGame()
        {
            int i;
            for (i = 0; i < 7; i++)
            {
                day.RunDayFunction();
            }
        }
    }

        



}