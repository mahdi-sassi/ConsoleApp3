using BLL.Models;
using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    public class PurchaseOrderShippmentItems : Table 
    {
        public Guid? PurchaseOrderDetailsID { get; set; }
        public  PurchaseOrderDetails PurchaseOrderDetails { get; set; }

        public Guid? PurchaseOrderShippmentDetailsID { get; set; }
        public  PurchaseOrderShippmentDetails PurchaseOrderShippmentDetails { get; set; }

        public int Quantity { get; set; }

    }

}
