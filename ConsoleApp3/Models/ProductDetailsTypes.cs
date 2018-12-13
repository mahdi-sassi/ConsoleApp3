using BLL.Models;
using System;

using ConsoleApp3;

namespace ConsoleApp3
{
    public class ProductDetailsTypes : TableName
    {
        //public DetailType DetailType { get; set; }
        public bool Mandatory { get; set; }
        public int Length { get; set; }
        public Guid? ProductTypesID { get; set; }
        public  ProductTypes ProductTypes { get; set; }
    }//PDT
}
