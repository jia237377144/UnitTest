using System;
using System.Collections.Generic;
using Practice.Models;

namespace Practice.Services
{
    public class FakeRestaurantService : IRestaurantService
    {
        private Dictionary<Location, IList<Restaurant>> restaurantDict = new Dictionary<Location, IList<Restaurant>>();

        public Restaurant AddRestaurant(Restaurant restaurant)
        {
            if (this.restaurantDict.ContainsKey(restaurant.Location))
            {
                this.restaurantDict[restaurant.Location].Add(restaurant);
            }
            else
            {
                this.restaurantDict[restaurant.Location] = new List<Restaurant> { restaurant };
            }

            return restaurant;
        }

        public IEnumerable<Restaurant> ListRestaurant(Location location)
        {
            return this.restaurantDict.ContainsKey(location) ? this.restaurantDict[location] : new List<Restaurant>(0);
        }


    }
}
