using System;
using Moq;
using NUnit.Framework;

using Practice.Models.MockTest;

namespace Practice.Features
{
    public class OrderServiceMock
    {
        private IPaymentService paymentService;
        private Mock<IOrderService> orderService;
        [SetUp]
        public void Setup()
        {
            orderService = new Mock<IOrderService>();
            paymentService = new PaymentService(orderService.Object);
        }

        [Test]
        public void should_cost_is_800_when_total_price_is_1000_()
        {
            orderService.Setup(s => s.GetTotalPrice()).Returns(1000);

            decimal cost = paymentService.Payment();

            Assert.IsTrue(cost == 800);

        }
    }
}
