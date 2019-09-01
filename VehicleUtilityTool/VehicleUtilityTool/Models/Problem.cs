using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleUtilityTool.Models
{
    public class Problem
    {
        public int Id { get; set; }
        public string Person { get; set; }
        public string Vehicle { get; set; }
        public int Mileage { get; set; }
        public string Issue { get; set; }
        public int QuantityNeeded { get; set; }
    }
}
