using BLL.Models;
using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    public class Vendors : TableInfo
    {
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string AlternativeCode { get; set; }
        public Guid? VendorsCategoriesID { get; set; }
        public VendorsCategories VendorsCategories { get; set; }
        public List<VendorsContacts> VendorsContactsList { get; set; }
        public List<Banks> VendorsBanksList { get; set; }
    }
}
