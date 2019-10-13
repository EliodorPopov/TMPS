using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns
{
    class SUVVehicle : Vehicle
    {
        public SUVVehicle(string manufacturer, string model, int year, string vINCode, string fuelType, string countryOfManufacture, int maxSpeed) 
            : base(manufacturer, model, year, vINCode, fuelType, ChasisTypes.SUV, countryOfManufacture, maxSpeed, 4, 5, 50, 14)
        {
        }

        public override void Clean()
        {
            base.Clean();
            Console.WriteLine("Added fresh car perfume. Polished the windows");
        }

        public override void Fuel()
        {
            base.Fuel();
            Console.WriteLine("Added fuel aditives for better fuel economy");
        }
    }
}
