using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConsoleApp3
{
    public class TransferRequests : Table 
    {
        public Guid? ProductStore_FromID { get; set; }
        public ProductStores ProductStore_From { get; set; }
        public Guid? ProductStore_ToID { get; set; }
        public ProductStores ProductStore_To { get; set; }
        public List<TransferRequestDetails> TransferRequestDetailsList { get; set; }
        public List<TransferRequestBatchs> TransferRequestBatchsList { get; set; }
        public bool Accepted { get; set; }
    }
}