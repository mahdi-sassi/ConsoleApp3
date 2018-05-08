using ConsoleApp3.Models.BaseTables;
using System;
namespace ConsoleApp3.Models
{
    public class VendorsCategories : TableInfo
    {
        public Guid? MainVendorsCategoriesID { get; set; }
        public VendorsCategories MainVendorsCategories { get; set; }
    }
}