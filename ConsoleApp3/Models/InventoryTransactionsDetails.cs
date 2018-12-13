using BLL.Models;
using System;


namespace ConsoleApp3
{ 
    public class InventoryTransactionsDetails : Table
    {
        public Guid? ProductBatchDefinitionsID { get; set; }
        public  ProductBatchDefinitions ProductBatchDefinitions { get; set; }
        //public int Rank { get; set; }
        public int Quantity { get; set; }
        public Guid? ProductStoresShelvesID { get; set; }
        public  ProductStoresShelves ProductStoresShelves { get; set; }
        public Guid? ProductBatchItemsID { get; set; }
        public  ProductBatchItems ProductBatchItems { get; set; }
        public Guid? ProductBatchItemShelfID { get; set; }
        public  ProductBatchItemShelves ProductBatchItemShelf { get; set; }
        public int Remainder { get; set; }
        public Guid? InventoryTransactionsID { get; set; }
        public InventoryTransactions InventoryTransactions { get; set; }

    }
}



