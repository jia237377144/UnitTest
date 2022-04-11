using System;
using System.Linq;
using NUnit.Framework;
using Practice.Adaptors;
using Practice.Models;
using Practice.Services;

namespace Practice
{
    public class RestaurantAdaptorTest
    {

        private Adaptor adaptor;
        private Location location;

        private Restaurant restaurant;


        [SetUp]
        public void Setup()
        {
            IRestaurantService fakeRestaurantService = TestUtils.GetFakeRestaurantService();
            this.adaptor = new Adaptor(fakeRestaurantService);
            this.location = Location.Here();
            this.restaurant = new Restaurant("this is a Restaurant", new Location(double.MinValue, double.MaxValue));
            this.adaptor.Add(restaurant);
        }

        [Test]
        public void should_get_restaurantX_in_list_when_restaurantX_is_nearby()
        {
            var restaurants = this.adaptor.List(this.location).ToList();
            Assert.Contains(this.restaurant, restaurants);
        }
    }

}
