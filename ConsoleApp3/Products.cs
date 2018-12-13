using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Products:Table
    {
        public string SizeName { get; set; }
        public Guid? CategoryID { get; set; }
        public Guid? ProductTypesID { get; set; }
        public Guid? CartID { get; set; }
        public string ConditionName { get; set; }
        public byte[] SmallImage { get; set; }
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public double SellingPrice { get; set; }
        public string Status { get; set; }
        public byte[] BrandIcon { get; set; }
    }
}
