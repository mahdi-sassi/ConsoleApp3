using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsoleApp3
{
    public class ProductTypes : TableInfoShort
    {
        public Guid? MainProductTypesID { get; set; }
        public  ProductTypes MainProductTypes { get; set; }
        public Guid? ImageSizesID { get; set; }
        public bool ShowInMainPage { get; set; }
        public string Code { get; set; } // barcode digits
        public byte[] Icon { get; set; }
        public string FontAwesome { get; set; }
        public Guid? ProductCategoriesID { get; set; }
        public  ProductCategories ProductCategories { get; set; }
        public  ImageSizes ImageSizes { get; set; }
        public Guid? ProductTypesImagesID { get; set; }
        public  List<ProductTypesImages> ProductTypesImages { get; set; }
    }
}