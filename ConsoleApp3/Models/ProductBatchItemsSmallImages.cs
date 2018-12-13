using BLL.Models;
using System;


namespace ConsoleApp3
{
    public class ProductBatchItemsSmallImages : Table
    {
       public byte[] SmallImage { get; set; }
       public Guid? ProductBatchItemsImagesID { get; set; }
        public  ProductBatchItemsImages ProductBatchItemsImages { get; set; }
       public Guid? ProductBatchDefinitionsID { get; set; }
        public  ProductBatchDefinitions ProductBatchDefinitions { get; set; }
    }//PBISI
}
