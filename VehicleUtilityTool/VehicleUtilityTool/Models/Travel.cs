using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleUtilityTool.Models
{
   public class Travel
    {
        public int Id { get; set; }
        public string Person { get; set; }
        public string Vehicle { get; set; }
        public int BeginningMileage { get; set; }
        public int EndingMileage { get; set; }
        public string StartingLocation { get; set; }
        public string Destination { get; set; }
        public double FuelCost { get; set; }
        public int Gallons { get; set; }
        public string PurchasedItems { get; set; }
        public double ItemsCost { get; set; }
    }
}
