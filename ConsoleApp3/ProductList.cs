using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class ProductList
    {
        public Guid ID { get; set; }
        public Guid CategoryID { get; set; }
        public Guid ProductTypeID { get; set; }
        public int TotalProducts { get; set; }
        public int StartPrice { get; set; }
        public int EndPrice { get; set; }
        public List<Sizes> Sizes { get; set; }
        public List<Brands> Brands { get; set; }
        public List<Products> Products { get; set; }
        public List<ProductTypes> ProductTypes { get; set; }
    }
}
