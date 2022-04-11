using System;
using NUnit.Framework;
using Practice.Models.Spy;

namespace Practice.Features
{
    public class OrderServiceSpy
    {
        private SpyShopDataAccess shopDataAccess;

        [SetUp]
        public void Setup()
        {
            shopDataAccess = new SpyShopDataAccess();
        }

        [Test]
        public void should_invoked_when_save_order()
        {
            Order order = new Order(4, shopDataAccess);
            order.Save();

            Assert.IsTrue(shopDataAccess.SaveInvocationCount == 1);
        }
    }
}
