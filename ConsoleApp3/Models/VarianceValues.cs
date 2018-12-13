using BLL.Models;
using System;

namespace ConsoleApp3
{
    public class VarianceValues : TableName
    {
        public Guid? VarianceTypesID { get; set; }
        public  VarianceTypes VarianceTypes { get; set; }
    }//VV
}
