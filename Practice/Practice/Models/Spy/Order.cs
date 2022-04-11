using System;
using System.Collections.Generic;

namespace Practice.Models.Spy
{
    public class Order
    {
        private int OrderId;
     
        private IShopDataAccess DataAccess
        {
            get;
        }

        public Order(int orderId, IShopDataAccess dataAccess)
        {
            this.OrderId = orderId;
            this.DataAccess = dataAccess;
        }
      
        public void Save()
        {
            this.DataAccess.Save(this.OrderId, this);
        }
    }
}
