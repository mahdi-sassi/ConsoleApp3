using BLL.Models;
using System;

using ConsoleApp3;

namespace ConsoleApp3
{
    public class ProductCategoriesProductTypes : Table
    {

        public Guid? ProductCategoriesID { get; set; }
        public  ProductCategories ProductCategories { get; set; }
        public Guid? ProductTypesID { get; set; }
        public  ProductTypes ProductTypes { get; set; }
    }//PCPT
}