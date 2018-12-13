using BLL.Models;
using System;
using System.Collections.Generic;

using ConsoleApp3;

namespace ConsoleApp3
{
    public class ProductBatchDefinitions : Table
    {
       public Guid? MainProductBatchDefinitionsID { get; set; }
       public  ProductBatchDefinitions MainProductBatchDefinitions { get; set; }
       public Guid? ColorsID { get; set; }
       public  Colors Colors { get; set; }
       public Guid? SizesID { get; set; }
       public  Sizes Sizes { get; set; }
       public Guid? UnitsID { get; set; }
       public  Units Units { get; set; }
       public Guid ProductsID { get; set; }
       public  Products Products { get; set; }
       public Guid? ProductPricesID { get; set; }
       public  ProductPrices ProductPrices { get; set; }
       public Guid? ProductBatchSmallImagesID { get; set; }
       public  List<ProductBatchItemsSmallImages> ProductBatchSmallImagesList { get; set; }
       public  List<ProductBatchItems> ProductBatchItemsList { get; set; }
       public  List<InventoryTransactionsDetails> InventoryTransactionsDetailsList { get; set; }
        //public Guid InventoryTransactionsDetailsID { get; set; }
    }//PBD
}