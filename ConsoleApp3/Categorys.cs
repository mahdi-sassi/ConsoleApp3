﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Categorys 
    {
        //public Guid ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Vendors> vendors { get; set; }
                                           // public ICollection<Products> Listproducts { get; set; }
    }
}
