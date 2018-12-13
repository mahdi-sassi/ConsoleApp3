using BLL.Models;
using System;


namespace ConsoleApp3
{
    public class ProductBatchItemShelves : Table
    {
       public Guid? ProductStoresShelvesID { get; set; }
       public  ProductStoresShelves ProductStoresShelves { get; set; }
       public Guid? ProductBatchItemsID { get; set; }
       public  ProductBatchItems ProductBatchItems { get; set; }
       public int Quantity { get; set; }
       public int Remainder { get; set; }
    }//PBIS
}
