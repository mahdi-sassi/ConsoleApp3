using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConsoleApp3
{
    public class ProductStoresJoinUser:Table
    {
        public Guid? ProductStoresID { get; set; }
        public ProductStores ProductStores { get; set; }
        public string UsersID { get; set; }
        //public ApplicationUser JoinUser { get; set; }
    }
    public class ProductStoresJoinUserViewModel : Table
    { 
        public Guid? ProductStoresID { get; set; }
        public ProductStores ProductStores { get; set; }

    }

}