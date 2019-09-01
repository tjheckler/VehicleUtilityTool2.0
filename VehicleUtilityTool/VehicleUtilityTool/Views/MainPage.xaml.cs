using VehicleUtilityTool.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VehicleUtilityTool.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.HomePage, (NavigationPage)Detail);
            
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Vehicle:
                        MenuPages.Add(id, new NavigationPage(new Vehicles()));
                        break;
                    case (int)MenuItemType.People:
                        MenuPages.Add(id, new NavigationPage(new People()));
                        break;
                    case (int)MenuItemType.Problem:
                        MenuPages.Add(id, new NavigationPage(new Problems()));
                        break;
                    case (int)MenuItemType.Places:
                        MenuPages.Add(id, new NavigationPage(new Places()));
                        break;
                    case (int)MenuItemType.Maintenance:
                        MenuPages.Add(id, new NavigationPage(new Maintenance()));
                        break;
                    case (int)MenuItemType.FuelMileage:
                        MenuPages.Add(id, new NavigationPage(new FuelMileage()));
                        break;
                    case (int)MenuItemType.Travel:
                        MenuPages.Add(id, new NavigationPage(new Travel()));
                        break;
                    case (int)MenuItemType.HomePage:
                        MenuPages.Add(id, new NavigationPage(new HomePage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}