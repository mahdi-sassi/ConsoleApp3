using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class StringReplace
    {
        public string replace(string input)
        {
            string output="";
            int index = input.LastIndexOf("ConsoleApp3.Models.BaseTable");
            string ch = input.Substring(0, index);
            string ch1 = input.Substring(index, input.Length - index);
            ch1 = ch1.Replace("ConsoleApp3.Models.BaseTable", "BLL.Models");
            int index1 = ch.LastIndexOf("ConsoleApp3");
            ch = ch.Remove(index1, 11);
            ch = ch.Insert(index1, "BLL");
            output = ch + ch1;
            return output;
        }
    }
}
