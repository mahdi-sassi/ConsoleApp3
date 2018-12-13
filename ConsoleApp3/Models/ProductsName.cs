using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsoleApp3
{
    public class ProductsName
    {
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string DescriptionEn { get; set; }
        public string DescriptionAr { get; set; }
        public Guid? ProductCategories_ID { get; set; }
        public Guid? ProductCategories_NameEn { get; set; }
        public Guid? ProductCategories_NameAr { get; set; }
        public Guid? ProductCategories_DescriptionEn { get; set; }
        public Guid? ProductCategories_DescriptionAr { get; set; }
    }
}