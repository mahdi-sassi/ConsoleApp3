using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace ConsoleApp3
{
    public class ProductCategories : TableInfoShort
    {
        
        public bool ShowOnHeader { get; set; }
        public bool ShowOnMainPage { get; set; }
        public byte[] Icon { get; set; }
        public string Code { get; set; } 
        public string FontAwesome { get; set; }
        public Guid? MainProductCategoriesID { get; set; }
        public  ProductCategories MainProductCategories { get; set; }
        public Guid? ProductCategoriesImagesID { get; set; }
        public  List<ProductCategoriesImages> ProductCategoriesImages { get; set; }
    }

}