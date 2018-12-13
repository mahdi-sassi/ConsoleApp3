using BLL.Models;
using System;


namespace ConsoleApp3
{
    public class DesignedProductBatchDefinitionImages : Table
    {
        public string DesignedImage { get; set; }
        public Guid? DesignedProductsID { get; set; }
        public DesignedProducts DesignedProducts { get; set; }
        public Guid? ProductBatchItemsImagesID { get; set; }
        public ProductBatchItemsImages ProductBatchItemsImages { get; set; }
    }//DPBDI
}
