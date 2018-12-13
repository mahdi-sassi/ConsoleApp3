using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConsoleApp3
{
    public class TransferRequestDetails : Table
    {
        [ForeignKey("TransferRequests")]
        public Guid? TransferRequestsID { get; set; }
        public TransferRequests TransferRequests { get; set; }
        public Guid? ProductBatchDefinitionsID { get; set; }
        public ProductBatchDefinitions ProductBatchDefinitions { get; set; }
        public int Quantity { get; set; }
        public int Remainder { get; set; }
        public int TransferedQuantity { get; set; }
    }
}