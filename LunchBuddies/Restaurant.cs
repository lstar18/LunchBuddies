using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Restaurant
    {
        private List<string> RestaurantList {get; set;}
        public string Name { get; set;  } 
        public Restaurant()
        {
            Random random = new Random();
            var restaurantList = new List<string>() { "RAD", "Folk", "City House", "Butcher and Bee", "Lyra" };

            int restaurantIndexNum = random.Next(restaurantList.Count);

            Name = restaurantList[restaurantIndexNum];

        }
    }
}
