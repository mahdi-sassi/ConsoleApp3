using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsoleApp3
{
    public class TransferRequestBatchs :Table
    {
        public Guid TransferRequestsID { get; set; }
        public TransferRequests TransferRequests { get; set; }
        public Guid OutputID { get; set; }
        public InventoryTransactions Output { get; set; }
        public Guid? InputID { get; set; }
        public InventoryTransactions Input { get; set; }
    }
}