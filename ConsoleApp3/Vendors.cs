using System;

namespace ConsoleApp3
{
    public class Vendors 
    {
        public Guid ID { get; set; }
        public Guid UserID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? CompanyDomainID { get; set; }
        public Domains CompanyDomain { get; set; }
        public string DescriptionEn { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string DescriptionAr { get; set; }
        public string Fax { get; set; }
        public string AlternativeCode { get; set; }
        public Guid? VendorsCategoriesID { get; set; }
        public VendorsCategories VendorsCategories { get; set; }
    }
}
