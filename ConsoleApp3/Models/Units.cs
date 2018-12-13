using BLL.Models;
using System;

namespace ConsoleApp3
{
    public class Units : TableInfoShort
    {
        //The small unit must be the main unit
       public Guid? MainUnitsID { get; set; }
        public  Units MainUnits { get; set; }
       public string Code { get; set; } // barcode digits
       public Guid? UnitTypesID { get; set; }
        public  UnitTypes UnitTypes { get; set; }
       public Guid? WeightMeasurementsID { get; set; }
        public  WeightMeasurements WeightMeasurements { get; set; }
       public decimal Weight { get; set; }
       public int Quantity { get; set; }
       public decimal? Length { get; set; }
       public decimal? Width { get; set; }
       public decimal? Depth { get; set; }
       public Guid? DimensionsDefinitionsID { get; set; }
        public  DimensionsDefinitions DimensionsDefinitions { get; set; }
       public Guid? DimensionMeasurementsID { get; set; }
        public  DimensionMeasurements DimensionMeasurements { get; set; }
    }//U
}