using BLL.Models;
using System;

namespace ConsoleApp3
{
    public class ProductStoresRows : TableInfoShort
    {
        public string Code { get; set; }
        public Guid? ProductStoresID { get; set; }
        public  ProductStores ProductStores { get; set; }
    }//PSR
}
