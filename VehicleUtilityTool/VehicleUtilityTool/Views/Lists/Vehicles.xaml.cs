using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VehicleUtilityTool.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Vehicles : ContentPage
	{
		public Vehicles ()
		{
			InitializeComponent ();
            Title = "Vehicles";
		}
	}
}