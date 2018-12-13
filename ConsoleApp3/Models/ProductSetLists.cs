using BLL.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp3
{
    public class ProductSetLists : Table
    {
        public Guid? ProductSetID { get; set; }
        public Products ProductSet { get; set; }
        public Guid ProductBatchDefinitionsID { get; set; }
        public ProductBatchDefinitions ProductBatchDefinitions { get; set; }
        public int Quantity { get; set; }
    }//PSL
}
