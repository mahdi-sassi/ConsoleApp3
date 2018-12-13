using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class VarianceTypesProductTypes : Table, IVarianceTypesProductTypes
    {
        public Guid? VarianceTypesID { get; set; }
        public VarianceTypes VarianceTypes { get; set; }
        public Guid? ProductTypesID { get; set; }
        public ProductTypes ProductTypes { get; set; }
    }//VTPT
    public class VarianceTypes : TableName, IVarianceTypes
    {
        //public List<VarianceValues> VarianceValues { get; set; }
        public List<VarianceTypesProductTypes> VarianceTypesProductTypes { get; set; }
        //public List<VarianceTypesProducts> VarianceTypesProducts { get; set; }
    }
    
}
