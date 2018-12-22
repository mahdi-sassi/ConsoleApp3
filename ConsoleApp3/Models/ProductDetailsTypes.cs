using BLL.Models;
using System;

using ConsoleApp3;

namespace ConsoleApp3
{
    public class ProductDetailsTypes :Table
    {
        public Guid ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DetailType? DetailType { get; set; }
        public string ProductDetailsTypesName { get; set; }
        public Guid? ProductTypeID { get; set; }
        public string Value { get; set; }
        public Guid ListValID { get; set; }
    }//PDT
    public enum DetailType
    {
        stringVal = 1,
        DateVal = 2,
        DateTimeVal = 3,
        intVal = 4,
        decimalVal = 5,
        ListVal = 6,
        Image = 7,
    }
}
