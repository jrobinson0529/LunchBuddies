using LunchBuddies.Restaurants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies.LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public LunchBuddy(string firstName, string lastname)
        {
            FirstName = firstName;
            LastName = lastname;
        }
        public string eat()
        {
            string restaurant = Restaurant.RandomRestaurant();
            Console.WriteLine($"{FirstName} is eating at {restaurant}");
            return restaurant;
        }
        public void eat(string food)
        {
            Console.WriteLine($"{FirstName} ate {food} at the office");
        }
        public void eat(List<LunchBuddy> companions)
        {
            string restaurant = Restaurant.RandomRestaurant();
            Console.WriteLine($"{FirstName} is eating at {restaurant} with:");
            foreach (LunchBuddy companion in companions)
            {
                Console.WriteLine(companion.FirstName);
            }
        }
        public void eat(string food, List<LunchBuddy> companions)
        {
            string restaurant = Restaurant.RandomRestaurant();
            Console.WriteLine($"{FirstName} ordered {food} at {restaurant} with:");
            foreach (LunchBuddy companion in companions)
            {
                Console.WriteLine(companion.FirstName);
            }
        }
    }
}
