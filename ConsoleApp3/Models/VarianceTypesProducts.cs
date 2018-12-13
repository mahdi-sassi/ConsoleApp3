using BLL.Models;
using System;

namespace ConsoleApp3
{
    public class VarianceTypesProducts : Table
    {
        public Guid? VarianceTypesID { get; set; }
        public  VarianceTypes VarianceTypes { get; set; }
        public Guid? ProductsID { get; set; }
        public  Products Products { get; set; }
    }//VTP
}
