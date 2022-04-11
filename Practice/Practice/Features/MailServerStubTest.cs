using System;
using NUnit.Framework;
using Practice.Models.Stub;

namespace Practice.Features
{
    public class MailServerStubTest
    {
        private IOrderService orderService;

        [SetUp]
        public void Setup()
        {
            var eMailServer = new MailServerStub();
            this.orderService = new OrderService(eMailServer);
        }

        [Test]
        public void should_success_when_create_order()
        {
            var result = this.orderService.Create(new Order());

            Assert.IsTrue(result);

        }
    }
}
