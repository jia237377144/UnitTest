using System;
using System.Collections;
using System.Collections.Generic;
using Practice.Models;

namespace Practice.Services
{
    public interface IRestaurantService
    {
        Restaurant AddRestaurant(Restaurant restaurant);
        IEnumerable<Restaurant> ListRestaurant(Location location);
    }
}
