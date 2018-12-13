using BLL.Models;
using System;


namespace ConsoleApp3
{
    public class DimensionMeasurements : TableInfoShort
    {
        public int Quantity { get; set; }
        public Guid? MainDimensionMeasurementsID { get; set; }
        public  DimensionMeasurements MainDimensionMeasurements { get; set; }
    }//DM
}
