using BLL.Models;
using System;


namespace ConsoleApp3
{
    public class DesignedProductImages : Table
    {
       public string DesignedImage { get; set; }
       public Guid? DesignedProductsID { get; set; }
       public  DesignedProducts DesignedProducts { get; set; }
       public Guid? ProductImagesID { get; set; }
       public  ProductImages ProductImages { get; set; }
    }//DPrI
}
