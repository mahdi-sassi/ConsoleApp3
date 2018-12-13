using BLL.Models;
using System;



namespace ConsoleApp3
{
    public class Banks : TableName
    {
        


        public string Email { get; set; }
        public string Fax { get; set; }
        public string Phone { get; set; }
        public string CustomerCode { get; set; }
        public string CompanyName { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string IBAN { get; set; }
        public string IFSC { get; set; }
        public string Swift { get; set; }
        public string BeneficiaryName { get; set; }
        public string Notes { get; set; }
        public string AccountNumber { get; set; }

        public Guid? CountryID { get; set; }
        public Country Country { get; set; }

        public Guid? CurrencyID { get; set; }
        public  Currency Currency { get; set; }

        public Guid VendorsID { get; set; }
        public  Vendors Vendors { get; set; }


        // public virtual List<Invoices> Invoices { get; set; }
    }
}
