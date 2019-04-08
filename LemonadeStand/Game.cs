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
        public Weather weather;

        public Inventory inventory;

        public Game()
        {
            customer = new Customer();
            store = new Store();
            inventory = new Inventory();
            day = new Day();
            player = new Player();
            weather = new Weather();

        }
        public void RunGame()
        {
            Console.WriteLine("Welcome to the Lemonade game! the goal is to make the most profit possible in a week.\n" +
                "You get to choose the recipe for your lemonade and how much you plan to sell it for.\n" +
                "Be careful, price, recipe, and even the weather will effect how much lemonade you'll sell.\n" +
                "Ready? Then let's get to work!!!");
            int i;
            for (i = 0; i < 7; i++)
            {
                day.RunDayFunction();
                Console.WriteLine(weather.GameWeather + " " + weather.Tempeture);
            }
        }
    }

        



}