using System;
namespace Practice.Models.Spy
{


    public interface IShopDataAccess
    {
        //decimal GetProductPrice(int productId);
        void Save(int orderId, Order o);
    }

   
}
