using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns
{
    class SUVVehicleDecorator : VehicleDecorator
    {
        public SUVVehicleDecorator(Vehicle vehicle) : base(vehicle)
        {
        }

        public new void Fuel()
        {
            base.Fuel();
            Console.WriteLine("Added fuel aditives for better fuel economy");
        }

        public new void Clean()
        {
            base.Clean();
            Console.WriteLine("Added fresh car perfume. Polished the windows");
        }

        public new void MechanicCheck()
        {
            base.MechanicCheck();
            Console.WriteLine("Adjusted ground clearance");
        }

        public new void PrepareForRent()
        {
            base.PrepareForRent();
            this.AddOffroadTires();
        }

        public void AddOffroadTires()
        {
            Console.WriteLine("Added mud and offroad tires");
        }
    }
}
