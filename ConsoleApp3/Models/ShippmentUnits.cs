using BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp3
{
    public class ShippmentUnits:Table
    {
        public List<PurchaseOrderShippmentDetails> PurchaseOrderShippmentDetailsList { get; set; }
        public List<ShippmentUnitsImages> ShippmentUnitsImagesList { get; set; }

        public decimal ShipmentUnitHeight { get; set; }
        public decimal ShipmentUnitDepth { get; set; }
        public decimal ShipmentUnitWidth { get; set; }
        public decimal ShipmentUnitNetWeight { get; set; }
        public decimal ShipmentUnitCrossWeight { get; set; }


    }
 
}
