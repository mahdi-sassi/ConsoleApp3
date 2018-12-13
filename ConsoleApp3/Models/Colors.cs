using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp3
{
    public class Colors :BLL.Models.TableName
    {
        public byte[] Image { get; set; }
        public string Code { get; set; } // barcode digits
        public string HexCode { get; set; } 
    }//C
}
