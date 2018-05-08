using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class InputExpressions
    {
        public string Expression { get; set; }
        public List<string> Includes { get; set; }
        public List<string> OrderBy { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }
    }
}
