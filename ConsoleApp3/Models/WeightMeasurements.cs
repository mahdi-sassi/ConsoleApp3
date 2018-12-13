using BLL.Models;
using System;

namespace ConsoleApp3
{
    public class WeightMeasurements : TableNameShort
    {
        public decimal Quantity { get; set; }
        public Guid? MainWeightMeasurementsID { get; set; }
        public  WeightMeasurements MainWeightMeasurements { get; set; }
    }//WM
}
