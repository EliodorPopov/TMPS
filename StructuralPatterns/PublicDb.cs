using System;
using System.Collections.Generic;
using System.Linq;

namespace Patterns
{
    public sealed class PublicDb
    {
        private Database database { get; set; }
        public List<Vehicle> cars { 
            get { return database.cars.Select(x => (Vehicle)x.Clone()).ToList(); } 
            }
        public PublicDb(Database mainDb)
        {
            database = mainDb;
        }

        public List<Vehicle> GetSortedVehicles(ISort algorithm, bool descending = false)
        {
            var cars = database.cars;
            algorithm.Sort(ref cars, descending);
            return cars;
        }

        public void PrintVehicles()
        {
            Console.WriteLine("****** List of vehicles ******");
            Console.WriteLine("{0,-12}{1,10}{2,18}{3,10}{4,10}{5,13}{6,18}{7,12}{8,15}",
                "Manufacturer", "Model", "VIN", "Fuel type", "Chasis", "Country", "Max speed(km/h)", "Nr of seats", "Price/h(eur)");
            database.cars.ForEach(c =>
            {
                c.PrintVehicle();
            });
        }
    }
}