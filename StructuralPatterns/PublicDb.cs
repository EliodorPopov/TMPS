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
            database.cars.ForEach(c =>
            {
                c.PrintVehicle();
            });
        }
    }
}