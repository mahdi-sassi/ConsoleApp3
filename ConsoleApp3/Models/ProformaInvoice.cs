using BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class ProformaInvoice : TableInfo
    {
        public List<ProformaInvoiceDetails> ProformaInvoiceDetailsList { get; set; }
        public bool Accepted { get; set; }
    }
}
