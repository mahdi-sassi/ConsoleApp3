using BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class PurchaseOrderShippment : Table
    {
        public List<PurchaseOrderShippmentDetails> PurchaseOrderShippmenetDetailsList { get; set; }

        public byte[] ShipmentPolicy { get; set; }
        public string DeliveryNote { get; set; }
        public DateTime ExpectedDate { get; set; }
    }
}
