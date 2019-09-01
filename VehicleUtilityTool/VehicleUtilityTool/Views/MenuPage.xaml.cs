using VehicleUtilityTool.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VehicleUtilityTool.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.HomePage, Title="Home Page" },
                new HomeMenuItem {Id = MenuItemType.Vehicle, Title="Vehicles" },
                new HomeMenuItem {Id = MenuItemType.People, Title="People" },
                new HomeMenuItem {Id = MenuItemType.Travel, Title="Travel" },
                new HomeMenuItem {Id = MenuItemType.Problem, Title="Problems" },
                new HomeMenuItem {Id = MenuItemType.FuelMileage, Title="Fuel Mileage" },
                new HomeMenuItem {Id = MenuItemType.Maintenance, Title="Maintenance" },
                new HomeMenuItem {Id = MenuItemType.Places, Title="Places" },
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}