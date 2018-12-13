using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsoleApp3
{
    public class ValidationParentClass:TableInfoShort
    {
        public string Key { get; set; }
        
        public List<FieldValidationFactory> ValidationParentClassList { get; set; }
    }
}