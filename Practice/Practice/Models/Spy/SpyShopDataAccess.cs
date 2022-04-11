using System;
namespace Practice.Models.Spy
{
    internal class SpyShopDataAccess : IShopDataAccess
    {
       
        private int saveInvocationCount;

        public void Save(int orderId, Order o) { this.saveInvocationCount++; }

        public int SaveInvocationCount { get { return this.saveInvocationCount; } }

   
    }
}
