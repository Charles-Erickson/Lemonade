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
            Console.WriteLine("Welcome to the Lemonade game! the goal is to make the most profit possible in a week from your staring $20.\n" +
                "You get to choose the recipe for your lemonade and how much you plan to sell it for.\n" +
                "Be careful, price, recipe, and even the weather will effect how much lemonade you'll sell.\n" +
                "Ready? Then let's get to work!!!");

            int i;
            for (i = 0; i < 7; i++)
            {
                day.RunDayFunction();             
            }
        }
        public void rungame()
        {
            Inventory Inventory = new Inventory();
            Recipe Recipe = new Recipe();
            Customer Customer = new Customer();
            Player Player = new Player();
            Store Store = new Store();
            Day Day = new Day();
            Game game = new Game();

            store.CalculateNewCashTotal(Player);

        }
    }

        



}