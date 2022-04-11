using System;
using System.Collections;
using System.Collections.Generic;
using Practice.Models;
using Practice.Services;

namespace Practice.Adaptors
{
    public class Adaptor
    {
        public IRestaurantService restaurantService { get; set; }
        public Adaptor (IRestaurantService restaurantService)
        {
            this.restaurantService = restaurantService;
        }

        public IEnumerable<Restaurant> List(Location location)
        {
            return this.restaurantService.ListRestaurant(location);
        }

        public Restaurant Add(Restaurant restaurant)
        {
            return this.restaurantService.AddRestaurant(restaurant);
        }

    }
}
