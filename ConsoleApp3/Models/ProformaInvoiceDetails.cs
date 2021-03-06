﻿using BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class ProformaInvoiceDetails : Table
    { 
        public Guid? ProformaInvoiceID { get; set; }
        public  ProformaInvoice ProformaInvoice { get; set; }

        public Guid? VendorsID { get; set; }
        public  Vendors Vendors { get; set; }

        public Guid? ProductBatchDefinitionsID { get; set; }
        public  ProductBatchDefinitions ProductBatchDefinitions { get; set; }

        public DateTime? ExpirationDate { get; set; }
        public Guid? CurrencyID { get; set; }
        public  Currency Currency { get; set; }

        public int Quantity { get; set; }

        public decimal VAT { get; set; }
        public decimal Price { get; set; }
    }
}
