using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ConsoleApp3
{
    public class FieldValidationFactory : Table 
    {
        public string BackgroundColor { get; set; }
        public bool HasError { get; set; }
        public string Label { get; set; }
        public string Name { get; set; }
        public string ErrorMessage { get; set; }
        public int MinLength { get; set; }
        public int MaxLength { get; set; }
        public bool HasAccess { get; set; }
        public string DefaultValueType { get; set; }
        public bool Required { get; set; }
        public string ParentClass { get; set; }
        public string DefaultValue { get; set; }
        public bool AutoIncrement { get; set; }
        public string Suffix { get; set; }
        public int Number { get; set; }
        public string Prefix { get; set; }
        public bool AutoGenerate { get; set; }
    }
}