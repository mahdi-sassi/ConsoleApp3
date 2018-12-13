using BLL.Models;
using System;


namespace ConsoleApp3
{
    public class ProductDetailsTypesDetails : Table
    {
        public Guid? ProductDetailsTypesID { get; set; }
        public  ProductDetailsTypes ProductDetailsTypes { get; set; }
        public string ValueEn { get; set; }
        public string ValueAr { get; set; }
    }//PDTD
}
