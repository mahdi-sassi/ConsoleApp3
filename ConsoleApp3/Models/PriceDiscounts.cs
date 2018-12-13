using BLL.Models;
using System;


namespace ConsoleApp3
{
    public class PriceDiscounts : Table
    {
       public Guid? PriceDiscountTypesID { get; set; }
       public  PriceDiscountTypes PriceDiscountTypes { get; set; }
       public decimal Discount { get; set; }
       public Guid? DiscountQualificationsID { get; set; }
       public  DiscountQualifications DiscountQualifications { get; set; }
       public decimal? Qualification { get; set; }
       //public Guid? ProductPricesID { get; set; }
       //public  ProductPrices ProductPrices { get; set; }
       public DateTime StartDate { get; set; }
       public DateTime EndDate { get; set; }
    }//PrD
}