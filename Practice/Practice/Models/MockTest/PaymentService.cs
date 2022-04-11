using System;
namespace Practice.Models.MockTest
{
    public class PaymentService : IPaymentService
    {
        private IOrderService orderService;
        public PaymentService(IOrderService orderService)
        {
            this.orderService = orderService;

        }

        public decimal Payment()
        {
            decimal totalPrice = this.orderService.GetTotalPrice();
            return totalPrice > 500 ? (totalPrice * 0.8m) : totalPrice;
        }
    }
}
