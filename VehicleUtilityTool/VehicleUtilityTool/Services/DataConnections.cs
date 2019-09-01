using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using VehicleUtilityTool.Models;
using Xamarin.Forms;

namespace VehicleUtilityTool.Services
{
    public class DataConnections
    {
        public Person Person { get; set; }
        public Vehicle Vehicle { get; set; }
        public AppDefaults AppDefaults { get; set; }
        public FuelMileage FuelMileage { get; set; }
        public Problem Problem { get; set; }
        public Places Places { get; set; }
        public Maintenance Maintenance { get; set; }
        public Travel Travel { get; set; }
        

        SQLiteConnection DefaultsData;
        SQLiteConnection VehicleData;
        SQLiteConnection PersonData;
        SQLiteConnection TravelData;
        SQLiteConnection ProblemData;
        SQLiteConnection MaintenanceData;
        SQLiteConnection PlacesData;
        SQLiteConnection FuelData;

        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AppDefaults.db3");
        string path2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Vehicles.db3");
        string path3 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Person.db3");
        string path4 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Travel.db3");
        string path5 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Places.db3");
        string path6 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Problem.db3");
        string path7 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Maintenance.db3");
        string path8 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FuelMileage.db3");
      
        public DataConnections(Person person, Vehicle vehicle, AppDefaults appDefaults, Travel travel, Places places, Problem problem, 
            Maintenance maintenance,FuelMileage fuelMileage,Page page)
        {
            this.Vehicle = vehicle;
            this.Person = person;
            this.AppDefaults = appDefaults;
            this.Travel = travel;
            this.Problem = problem;
            this.Places = places;
            this.Maintenance = maintenance;
            this.FuelMileage = fuelMileage;
            


            DefaultsData = new SQLiteConnection(path);
            DefaultsData.CreateTable<AppDefaults>(CreateFlags.ImplicitPK);
            VehicleData = new SQLiteConnection(path2);
            VehicleData.CreateTable<Vehicle>(CreateFlags.ImplicitPK);
            PersonData = new SQLiteConnection(path3);
            PersonData.CreateTable<Person>(CreateFlags.ImplicitPK);
            TravelData = new SQLiteConnection(path4);
            TravelData.CreateTable<Travel>(CreateFlags.ImplicitPK);
            PlacesData = new SQLiteConnection(path6);
            PlacesData.CreateTable<Places>(CreateFlags.ImplicitPK);
            ProblemData = new SQLiteConnection(path6);
            ProblemData.CreateTable<Problem>(CreateFlags.ImplicitPK);
            MaintenanceData = new SQLiteConnection(path7);
            MaintenanceData.CreateTable<Maintenance>(CreateFlags.ImplicitPK);
            FuelData = new SQLiteConnection(path8);
            FuelData.CreateTable<FuelMileage>(CreateFlags.ImplicitPK);


            var maxPk = DefaultsData.Table<AppDefaults>().OrderByDescending(d => d.Id).FirstOrDefault();
            appDefaults = new AppDefaults()
            {
                Id = (maxPk == null ? 1 : maxPk.Id + 1),
                DriversLicenseNumber = "1",
                FirstName = "Christopher",
                LastName = "Columbus",
                LicensePlate = "N3w4pp",
                Year = "1492",
                Make = "Santa",
                Model = "Maria",
                Mileage = "12,200 ",

            };
        }
    }
}
