using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies.Restaurants
{
    class Restaurant
    {
        public string Name { get; private set; }
       
        public static string RandomRestaurant()
        {
            var rnd = new Random(); // get Random Value
            var enumValues = Enum.GetValues(typeof(RestaurantEnum)); // get an array of the enums values in order to get the length of the enum
            var rndIndex = rnd.Next(enumValues.Length);  // get random index based on length of the enum array
            var restaurantName = (RestaurantEnum)enumValues.GetValue(rndIndex);
            return restaurantName.ToString();
        }
        public Restaurant()
        {
            Name = RandomRestaurant();
        }
    }
}
