using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleUtilityTool.Models;
using VehicleUtilityTool.Services;
using VehicleUtilityTool.ViewModels;
using VehicleUtilityTool.Views.New;
using VehicleUtilityTool.Views.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VehicleUtilityTool.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Vehicles : ContentPage
	{
        DataConnections DC;
		public Vehicles ()
		{
			InitializeComponent ();
            Title = "Vehicles";
            BindingContext = this;
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var vehicle = args.SelectedItem as Vehicle;
            if (vehicle == null)
            {
                return;
            }else
            {
                await Navigation.PushModalAsync(new VehicleView(new VehicleViewModel(vehicle)));
            }


        }

        private async void Add_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new NewVehicle()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            // access table
            DC.VehicleData = new SQLiteConnection(DC.path2);
            DC.VehicleData.CreateTable<Vehicle>(CreateFlags.ImplicitPK);
            var vehicles = DC.VehicleData.Table<Vehicle>().OrderBy(x => x.Id).ToList();

            VehicleListView.ItemsSource = vehicles;
        }
    }
}