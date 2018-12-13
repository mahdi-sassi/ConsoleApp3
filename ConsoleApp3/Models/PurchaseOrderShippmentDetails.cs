using BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class PurchaseOrderShippmentDetails : Table
    {
        public Guid? PurchaseOrderShippmentID { get; set; }
        public  PurchaseOrderShippment PurchaseOrderShippment { get; set; }

        public Guid? ShippmentUnitsID { get; set; }
        public  ShippmentUnits ShippmentUnits { get; set; }

        public  List<PurchaseOrderShippmentItems> PurchaseOrderShippmentItems { get; set; }
    }
   


}
