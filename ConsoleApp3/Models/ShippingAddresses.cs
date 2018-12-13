using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsoleApp3
{
    public class ShippingAddresses : Table
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string StreetName { get; set; }
        public string Area { get; set; }
        public string Wasel { get; set; }
        public string HouseNumber { get; set; }
        public string MobileNumber { get; set; }

        public bool Default { get; set; }
        public Guid? CustomersID { get; set; }
        public Customers Customers { get; set; }
    }
}