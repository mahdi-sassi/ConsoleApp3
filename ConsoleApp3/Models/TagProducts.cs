using BLL.Models;
using System;

namespace ConsoleApp3
{
    public class TagProducts : Table
    {
        public Guid? TagModelsID { get; set; }
        public  TagModels TagModels { get; set; }
        public Guid? ProductsID { get; set; }
        public  Products Products { get; set; }
    }//PTag
}