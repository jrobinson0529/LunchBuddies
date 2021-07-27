using LunchBuddies.LunchBuddies;
using LunchBuddies.Restaurants;
using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var jesse = new LunchBuddy("Jesse", "Robinson");
            var eric = new LunchBuddy("Eric", "George");
            var sarah = new LunchBuddy("Sarah", "Berenstein");
            var mac = new LunchBuddy("Mac", "Mayberry");
            var amy = new LunchBuddy("Amy", "Zink");
            var andy = new LunchBuddy("Andy", "Robinson");

            jesse.eat();

            jesse.eat("Burgers");

            jesse.eat(new List<LunchBuddy>() { eric, sarah, mac, amy });

            jesse.eat("Sushi", new List<LunchBuddy>() { eric, sarah, mac, amy, andy });
        }
    }
}
