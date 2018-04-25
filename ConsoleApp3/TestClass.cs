using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class TestClass1
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public int age { get; set; }
        public ICollection<TestClass2> testClass2 { get; set; }
    }
    public class TestClass2
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public int age { get; set; }
    }
}
