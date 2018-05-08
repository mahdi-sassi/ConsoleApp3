//using ClassLibrary1.BaseModels;
using System;

namespace ClassLibrary1.BaseInteface
{
    public interface ITable
    {
        Guid ID { get; set; }
        Guid UserID { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime? UpdatedDate { get; set; }
        bool IsDeleted { get; set; }
        Guid? CompanyDomainID { get; set; }
        //Domains CompanyDomain { get; set; }

    }
}
