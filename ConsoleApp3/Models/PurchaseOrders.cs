using BLL.Models;
using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    public class PurchaseOrders : TableInfo
    {
        public List<PurchaseOrderDetails> PurchaseOrderDetailsList { get ; set ; }

        public List<PurchaseOrderPayement> PurchaseOrderPayementsList { get; set; }

        public bool Sent { get; set; }
        public DateTime? SendDate { get; set; }
        public bool AcceptedByVendor { get; set; }
        public DateTime? AcceptedByVendorDate { get; set; }
    }
}
