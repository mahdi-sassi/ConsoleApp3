using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ConsoleApp3
{
    public class Customers : TableName
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CustomerCode { get; set; }
        public string CompanyName { get; set; }
        public List<Invoices> Invoices { get; set; }
        public List<ShippingAddresses> ShippingAddressesList { get; set; }
    }
}