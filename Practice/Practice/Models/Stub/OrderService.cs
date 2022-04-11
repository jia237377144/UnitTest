using System;
namespace Practice.Models.Stub
{
    public class OrderService:IOrderService
    {
        private IEMailServer eMailServer;
        public OrderService(IEMailServer eMailServer)
        {
            this.eMailServer = eMailServer;
        }

        public bool Create(Order order)
        {
            // save the order to the db;
            this.eMailServer.SendMail(new EMail());
            return true;
        }
    }
}
