using BLL.Models;
using System.Collections.Generic;

namespace ConsoleApp3
{
    public class ProductStores : TableInfoShort
    {
        public  List<InventoryTransactions> InventoryTransactionsList { get; set; }
        public  List<ProductStoresJoinUser> productStoresJoinUsersList { get; set; }
    }//PS
}
