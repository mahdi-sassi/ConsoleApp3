using BLL.Models;
using System;


namespace ConsoleApp3
{
    public class DesginPaddingImages : Table 
    {
        //definition image id
       public  Guid? ProductBatchItemsSmallImages { get; set; }
       public Guid? ProductBatchDefinitions { get; set; }
       public string PaddingLeft { get; set; }
       public string PaddingRight { get; set; }
       public string PaddingTop { get; set; }
       public string PaddingBottom { get; set; }
    }//DPI
}
