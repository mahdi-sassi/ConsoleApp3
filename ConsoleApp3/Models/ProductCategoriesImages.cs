using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace ConsoleApp3
{
    public class ProductCategoriesImages:Table
    {
        public byte[] Image { get; set; }
        public Guid? ProductCategoriesID { get; set; }
        public  ProductCategories ProductCategories { get; set; }
    }
}