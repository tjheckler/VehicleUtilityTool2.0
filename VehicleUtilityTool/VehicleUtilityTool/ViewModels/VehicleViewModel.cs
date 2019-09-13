using System;
using System.Collections.Generic;
using System.Text;
using VehicleUtilityTool.Models;

namespace VehicleUtilityTool.ViewModels
{
    public class VehicleViewModel : BaseViewModel
    {
        private Vehicle vehicle;

        public VehicleViewModel(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }
    }
}
