using BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp3
{
    public class InvoiceDetails : Table

    {
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public Guid InvoicesID { get; set; }
        public Invoices Invoices { get; set; }
        public Guid? InvoiceDetailsStatusID { get; set; }
        public InvoiceDetailsStatus InvoiceDetailsStatus { get; set; }
        public Guid ProductBatchDefinitionsID { get; set; }
        public ProductBatchDefinitions ProductBatchDefinitions { get; set; }
        public Guid? ProductSetID { get; set; }
    }
}
