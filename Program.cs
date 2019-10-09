using System;
using System.Collections.Generic;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton - we have only one connection to the database
            var database = Database.db;

            // Factory - based on which type of vehicle we create, we need certain parameters
            // For example for an SUV type we don't specify the Chasis type 
            // Or for an econom type we don't need to know or to show the maximum speed

            // Other vehicle types that may be: Minivan, Intermediary, VAN, Premium, Motorcycle

            Vehicle cle = VehicleFactory.CreatePremiumVehicle("Mercedes", "CLE", 2016, "DFGP56495FTkf54", "Gas", 250);
            Vehicle logan = VehicleFactory.CreateEconomVehicle("Dacia", "Logan", 2010, "sjkdfh3475sjdfh", "Gas", ChasisTypes.Sedan);
            Vehicle audi = VehicleFactory.CreateSUV("Audi", "Q7", 2014, "sdjfhsdf4387sud38", "Gas", 200);

            cle.PricePerHour = 50;
            logan.PricePerHour = 5;
            audi.PricePerHour = 25;

            database.cars.Add(cle);
            database.cars.Add(logan);
            database.cars.Add(audi);

            cle.PrintVehicle();
            logan.PrintVehicle();
            audi.PrintVehicle();
            
            // this is a Proxy
            PublicDb publicDb = new PublicDb(database);
            var cars = publicDb.cars;
            cars[0].PricePerHour = 500;
            publicDb.PrintVehicles();

            // using the strategy pattern to sort vehicles
            var sorted = publicDb.GetSortedVehicles(new SortByMaxSpeed(), true);
            sorted.ForEach(c => {
                c.PrintVehicle();
            });

            //Privately with the real database we acces it and change the data
            database.IncreasePrice((float)0.15);

            //With the public proxy we can see the changes made in the database
            publicDb.PrintVehicles();

            Console.Read();
        }
    }
}
