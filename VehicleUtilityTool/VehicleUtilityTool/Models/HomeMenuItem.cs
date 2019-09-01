using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleUtilityTool.Models
{
    public enum MenuItemType
    {
        HomePage,
        Vehicle,
        People,
        FuelMileage,
        Maintenance,
        Problem,
        Travel,
        Places
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
