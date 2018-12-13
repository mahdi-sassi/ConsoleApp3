using BLL.Models;
using System;

namespace ConsoleApp3
{
    public class VarianceValuesProductBatchDefinitions : Table
    {
        public Guid? VarianceValuesID { get; set; }
        public  VarianceValues VarianceValues { get; set; }
        public Guid? ProductBatchDefinitionsID { get; set; }
        public  ProductBatchDefinitions ProductBatchDefinitions { get; set; }
    }
}