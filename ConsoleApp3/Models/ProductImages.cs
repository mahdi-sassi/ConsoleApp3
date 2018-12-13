using BLL.Models;
using System;


namespace ConsoleApp3
{
    public class ProductImages : Table
    {
        public byte[] Image { get; set; }
        public string ImageName { get; set; }
        public Guid? ImageGroupID { get; set; }
        public ImageGroup ImageGroup { get; set; }
    }//PI
}
