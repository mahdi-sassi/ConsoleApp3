using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ConsoleApp3
{
    public class ProductBatchDefinitionImageCategories : Table 
    {
        public Guid? ProductBatchItemsSmallImagesID { get; set; }
        public ProductBatchItemsSmallImages ProductBatchItemsSmallImages  { get; set; }
    }
}