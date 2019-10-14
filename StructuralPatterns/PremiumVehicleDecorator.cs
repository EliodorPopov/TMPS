using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns
{
    class PremiumVehicleDecorator : VehicleDecorator
    {
        public PremiumVehicleDecorator(Vehicle vehicle) : base(vehicle)
        {

        }

        public new void Fuel()
        {
            base.Fuel();
            Console.WriteLine("Added additives into the fuel tank for better performance");
        }

        public new void Clean()
        {
            base.Clean();
            Console.WriteLine("Polished the entire car to make it shine");
        }

        public new void MechanicCheck()
        {
            base.MechanicCheck();
            Console.WriteLine("Changed premium brake pads");
        }

        public new void PrepareForRent()
        {
            base.PrepareForRent();
            this.AddWifi();
        }

        public void AddWifi()
        {
            Console.WriteLine("Added WiFi router inside the car");
        }
    }
}
