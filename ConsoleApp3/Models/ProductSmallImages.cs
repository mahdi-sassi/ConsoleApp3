using BLL.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp3
{
    public class ProductSmallImages : Table
    {
        public byte[] SmallImage { get; set; }
        public Guid? ProductImagesID { get; set; }
        public ProductImages ProductImages { get; set; }
        //need to be indexed
        public Guid ProductsID { get; set; }
        public Products Products { get; set; }
        public string ImageName { get; set; }

        public Guid? ImageGroupID { get; set; }
        public ImageGroup ImageGroup { get; set; }
    }//PSI
}