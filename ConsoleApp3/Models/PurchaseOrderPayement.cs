using BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class PurchaseOrderPayement : Table
    {

        public string PaymentType { get; set; }
        public string AccountNumber { get; set; }
        public decimal Amount { get; set; }


        public Guid? PurchaseOrdersID { get; set; }
        public  PurchaseOrders PurchaseOrders { get; set; }


    }
}
