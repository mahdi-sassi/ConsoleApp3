using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Parametres
    {
        public Expression<Func<Employees,bool>> expression { get; set; }
        public string ClassName { get; set; }
    }
}
