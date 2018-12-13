using BLL.Models;
using System;

namespace ConsoleApp3
{
    public class VendorsContacts: TableInfo
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Phone2 { get; set; }
        public string Notes { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public Guid VendorsID { get; set; }
        public virtual Vendors Vendors { get; set; }
    }    
}
