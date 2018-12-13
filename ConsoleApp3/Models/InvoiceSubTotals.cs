using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ConsoleApp3
{
    public class InvoiceSubTotals : Table 
    {
        public Guid? InvoiceSubTotalTypesID { get; set; }
        public virtual InvoiceSubTotalTypes InvoiceSubTotalTypes { get; set; }
        public double Price { get; set; }
        public Guid? InvoicesID { get; set; }
        public virtual Invoices Invoices { get; set; }
        public Guid? ProductSetId { get; set; }
    }
}