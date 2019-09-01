using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleUtilityTool.Models
{
   public class FuelMileage
    {
        public int Id { get; set; }
        public int BeginningMiles { get; set; }
        public int EndingMiles { get; set; }
        public double FuelCost { get; set; }
        public double FuelGallons { get; set; }
        public double MilesPerGallon { get; set; }
        public string Person { get; set; }
        public string Vehicle { get; set; }
    }
}
