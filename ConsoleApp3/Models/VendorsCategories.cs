using BLL.Models;
using System;
namespace ConsoleApp3
{
    public class VendorsCategories : TableInfo
    {
        public Guid? MainVendorsCategoriesID { get; set; }
        public  VendorsCategories MainVendorsCategories { get; set; }
    }
}