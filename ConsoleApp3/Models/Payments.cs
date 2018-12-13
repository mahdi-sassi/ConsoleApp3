using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ConsoleApp3
{
    public class Payments : Table
    {
        public double Amount { get; set; }
        public string ReferenceCode { get; set; }
        public bool Status { get; set; }
        public string PaymentUserID { get; set; }
        public Guid InvoicesID { get; set; }
        public Invoices Invoices { get; set; }
        public DateTime? PaidDate { get; set; }
        public Guid? PaymentMethodsID { get; set; }
        public PaymentMethods PaymentMethods { get; set; }
    }
}