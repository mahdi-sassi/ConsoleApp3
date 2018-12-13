using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Coupons
    {
        public Guid ID { get; set; }
        public string Code { get; set; }
        public decimal Discountamount { get; set; }
        public decimal Totalamount { get; set; }
    }
}
