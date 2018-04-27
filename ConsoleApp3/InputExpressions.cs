using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class InputExpressions
    {
        public string expression { get; set; }
        public List<string> inclules { get; set; }
        public List<string> orderBy { get; set; }
        public int Skip { get; set; }
        public int take { get; set; }
    }
}
