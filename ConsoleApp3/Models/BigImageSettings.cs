using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsoleApp3
{
    public class BigImageSettings : TableName
    {
        public double MaxHeight { get; set; }
        public double MaxWidth { get; set; }
        public double MinSize { get; set; }
        public double MaxSize { get; set; }
        public double MinHeight { get; set; }
        public double MinWidth { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public bool KeepRatio { get; set; }
    }
}