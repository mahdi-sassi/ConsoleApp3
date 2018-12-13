using BLL.Models;
using System;
using System.Collections.Generic;

using ConsoleApp3;

namespace ConsoleApp3
{
    public class ProductBatches : TableName
    {
        public string AlternativeCode { get; set; }
        public decimal ProductTotalPrice { get; set; }
        public decimal ShipmentTotalCost { get; set; }
        public Guid? ShipmentCostAmountTypeID { get; set; }
        public  AmountType ShipmentCostAmountType { get; set; }
        public decimal PackagingTotalCost { get; set; }
        public Guid? PackagingCostAmountTypeID { get; set; }
        public  AmountType PackagingCostAmountType { get; set; }
        public int DaysFromBuyToDeliver { get; set; }
        public string BatchCode { get; set; }
        public Guid? ProductsID { get; set; }
        public  Products Products { get; set; }
        public Guid? VendorsID { get; set; }
        public  Vendors Vendors { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public  List<ProductBatchItems> ProductBatchItems { get; set; }
        public string Refrence { get; set; }
    }//PB
}