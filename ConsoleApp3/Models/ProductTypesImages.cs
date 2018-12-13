using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsoleApp3
{
    public class ProductTypesImages:Table
    {
        public byte[] Image { get; set; }
        public Guid? ProductTypesID { get; set; }
        public  ProductTypes ProductTypes { get; set; }
    }
}