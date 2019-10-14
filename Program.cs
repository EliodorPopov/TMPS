using System;
using System.Collections.Generic;

namespace Patterns
{
    class Program
    {
        public static void PrintMainMenu()
        {
            Console.WriteLine("--------------MENU--------------");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Print available cars");
            Console.WriteLine("2 - Increase price by 15% for all cars (Proxy demonstration)");
            Console.WriteLine("3 - Sort all vehicles (Strategy pattern)");
            Console.WriteLine("4 - Decorate an existing vehicle");
            Console.WriteLine("5 - Prepare vehicle for rent");
        }
        static void Main(string[] args)
        {
            int input;

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

            // this is a Proxy
            PublicDb publicDb = new PublicDb(database);

            while (true)
            {
                Console.Clear();
                PrintMainMenu();
                input = Console.Read() - 48;

                switch(input)
                {
                    case 0:
                        {
                            Console.WriteLine("Exiting the application");
                            Environment.Exit(1);
                            break;
                        }
                    case 1:
                        {
                            var cars = publicDb.cars;
                            cars[0].PricePerHour = 500;
                            publicDb.PrintVehicles();
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            //Privately with the real database we acces it and change the data
                            database.IncreasePrice((float)0.15);
                            //With the public proxy we can see the changes made in the database
                            publicDb.PrintVehicles();
                            Console.ReadLine();
                            break;
                        }
                    case 3:
                        {
                            // using the strategy pattern to sort vehicles
                            var sorted = publicDb.GetSortedVehicles(new SortByMaxSpeed(), true);
                            sorted.ForEach(c => {
                                c.PrintVehicle();
                            });
                            Console.ReadLine();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("You have 3 options to decorate:");
                            Console.WriteLine("1 - SUV"
                                + "\n2 - Econom" + "\n3 - Premium");
                            Console.ReadLine();
                            int choice = Console.Read() - 48;
                            
                            if (choice < 1 || choice > 3)
                            {
                                Console.WriteLine("Invalid choice");
                            }
                            else
                            {
                                database.cars.ForEach(c =>
                                {
                                    c.PrintVehicle();
                                });
                                string vin;
                                Console.WriteLine("Enter VIN Number: ");
                                Console.ReadLine();
                                vin = Console.ReadLine();
                                Vehicle vehicle = database.cars.Find(c =>
                                c.VINCode.Equals(vin));
                                if (vehicle != null)
                                {
                                    IVehicle veh;
                                    if (choice == 1)
                                    {
                                       veh = new SUVVehicleDecorator(vehicle);
                                    }
                                    else if (choice == 2)
                                    {
                                        veh = new EconomVehicleDecorator(vehicle);
                                    }
                                    else
                                    {
                                        veh = new PremiumVehicleDecorator(vehicle);
                                    }
                                    veh.PrepareForRent();
                                }
                                else
                                {
                                    Console.WriteLine("Invalid VIN");
                                }
                            }
                            Console.ReadLine();
                            break;
                        }
                    case 5:
                        {
                            database.cars.ForEach(c =>
                            {
                                c.PrintVehicle();
                            });
                            string vin;
                            Console.WriteLine("Enter VIN Number: ");
                            Console.ReadLine();
                            vin = Console.ReadLine();
                            Vehicle vehicle = database.cars.Find(c => 
                            c.VINCode.Equals(vin));
                            if (vehicle != null)
                            {
                                vehicle.PrepareForRent();
                            }
                            else
                            {
                                Console.WriteLine("Invalid VIN");
                            }
                            Console.ReadLine();
                            break;
                        }
                }
                Console.ReadLine();
            }
        }
    }
}
