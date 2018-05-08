using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models.BaseTables
{
    public class Table 
    {
        public Guid ID { get; set; }
        public string UserID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? CompanyDomainID { get; set; }
        public Domains CompanyDomain { get; set; }
    }
}
