using BLL.Models;
using System;
using System.Collections.Generic;


namespace ConsoleApp3
{
    public class DesignedProducts : Table
    {
       public string DesignedImage { get; set; }
       public  List<DesignedProductImages> DesignedProductImages { get; set; }
       public  List<DesignedProductBatchDefinitionImages> DesignedProductBatchDefinitionImages { get; set; }
       public Guid? ProductBatchDefinitionsID { get; set; }
       public  ProductBatchDefinitions ProductBatchDefinitions { get; set; }
    }//DP
}
