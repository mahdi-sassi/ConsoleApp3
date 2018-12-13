using BLL.Models;
using System;

namespace ConsoleApp3
{
    public class ProductStoresShelves : TableInfoShort
    {
        public string Code { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Depth { get; set; }
        public int Temperature { get; set; }
        public Guid? TemperatureTypeID { get; set; }
        public  TemperatureType TemperatureType { get; set; }
        public Guid? ProductStoresRowsID { get; set; }
        public  ProductStoresRows ProductStoresRows { get; set; }
    }//PSS
}
