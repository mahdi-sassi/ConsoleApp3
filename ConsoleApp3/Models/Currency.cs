using BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp3
{
    public class Currency : TableNameShort
    {
        public string Code { get; set; }
        public bool Default { get; set; }
    }
}
