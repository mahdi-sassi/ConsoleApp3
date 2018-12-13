using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsoleApp3
{
    public class ShippmentUnitsImages : Table
    {
        public byte[] Image { get; set; }

        public Guid? ShippmentUnitsID { get; set; }
        public ShippmentUnits ShippmentUnits { get; set; }

    }

}