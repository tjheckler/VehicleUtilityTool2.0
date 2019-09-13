using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleUtilityTool.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VehicleUtilityTool.Views.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VehicleView : ContentPage
	{
        private VehicleViewModel vehicleViewModel;

        public VehicleView ()
		{
			InitializeComponent ();
		}

        public VehicleView(VehicleViewModel vehicleViewModel)
        {
            this.vehicleViewModel = vehicleViewModel;
        }
    }
}