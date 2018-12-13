using BLL.Models;
using System;
using System.Collections.Generic;


namespace ConsoleApp3
{
    public class ProductPrices : Table
    {
        public Guid? PriceTypesID { get; set; }
        public  PriceTypes PriceTypes { get; set; }
        public decimal Price { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        //public  List<PriceDiscounts> PriceDiscountsList { get; set; }
    }//PPr
}
