using BLL.Models;
using System;
using System.Collections.Generic;


namespace ConsoleApp3
{
    public class ProductBatchItems : Table
    {
        public int Quantity { get; set; }
        public int Remainder { get; set; }
        public decimal Cost { get; set; }
        public Guid? ProductPricesID { get; set; }
        public  ProductPrices ProductPrices { get; set; }
        public Guid? ProductBatchDefinitionsID { get; set; }
        public  ProductBatchDefinitions ProductBatchDefinitions { get; set; }
        public Guid? ProductBatchesID { get; set; }
        public  ProductBatches ProductBatches { get; set; }
        public Guid ProductsID { get; set; }
        public  Products Products { get; set; }
        public  List<ProductBatchItemShelves> ProductBatchItemShelvesList { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }//PBI
}