using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace ConsoleApp3
{
    public class Invoices : Table 
    {
        public string InvoiceNumber { get; set; }
        public double TotalPrice { get; set; }
        public decimal Discount { get; set; }
        [ForeignKey("InvoiceStatus")]
        public Guid InoviceStatusID { get; set; }
        public InvoiceStatus InvoiceStatus { get; set; }
        public List<InvoiceSubTotals> InvoiceSubTotals { get; set; }
        public List<InvoiceDetails> InvoiceDetails { get; set; }
        public Guid? PaymentsID { get; set; }
        public List<Payments> Payments { get; set; }
        public Guid? CustomersID { get; set; }
        public Customers Customers { get; set; }
        public Guid? ShippingAddressesID { get; set; }
        public ShippingAddresses ShippingAddresses { get; set; }
    }
}