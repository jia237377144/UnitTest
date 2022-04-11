using System;
using Practice.Services;

namespace Practice
{
    public class TestUtils
    {
       public static IRestaurantService GetFakeRestaurantService()
        {
            return new FakeRestaurantService();
        }
    }
}
