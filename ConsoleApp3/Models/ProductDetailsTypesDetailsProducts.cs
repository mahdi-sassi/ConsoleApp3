using BLL.Models;
using System;


namespace ConsoleApp3
{
    public class ProductDetailsTypesDetailsProducts : Table
    {
       public Guid? ProductsID { get; set; }
        public  Products Products { get; set; }
       public Guid? ProductDetailsTypesDetailsID { get; set; }
        public  ProductDetailsTypesDetails ProductDetailsTypesDetails { get; set; }
    }//PDTDP
}
