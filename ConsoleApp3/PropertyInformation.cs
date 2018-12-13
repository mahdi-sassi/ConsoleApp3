using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class PropertyInformation
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
    public class TestClass
    {
        public int ID { get; set; }
        public string str { get; set; }
        public double dbl { get; set; }
        public decimal dcl { get; set; }
        public bool bl { get; set; }
        public object obj { get; set; }
        public Products products { get; set; }
        public char ch { get; set; }
        public Single sng { get; set; }
        public String Str { get; set; }
        public List<Brands> list { get; set; }
        public ICollection<Brands> icoll { get; set; }
        public IEnumerable<Brands> ienu { get; set; }
        public IQueryable<Brands> ique { get; set; }
        public Byte[] byt { get; set; }
        public int[] ints { get; set; }
    }
}
