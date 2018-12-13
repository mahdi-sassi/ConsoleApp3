using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ConsoleApp3
{
    public class Country : TableNameShort
    {
        public string Code { get; set; }
        public bool Default { get; set; }
    }
}