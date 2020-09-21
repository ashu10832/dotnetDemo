using System;
using code_first.model;

namespace code_first
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectContext context = new ConnectContext();
            StoreDTO store = new StoreDTO();
            store.productName = "Table";
            store.quantity = 2;
            store.lastPurchased = Convert.ToDateTime("10-10-2020");
            context.StoreDTO.Add(store);
            context.SaveChanges();
        }
    }
}
