using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns
{
    class EconomVehicleDecorator : VehicleDecorator
    {
        public EconomVehicleDecorator(Vehicle vehicle) : base(vehicle)
        {
            vehicle.MaxSpeed = 150;
            vehicle.UrbanConsumption = 6;
        }

        public new void Fuel()
        {
            base.Fuel();
            Console.WriteLine("Check fuel tank for leaks");
        }

        public new void Clean()
        {
            Console.WriteLine("Put seat covers to not mess the seats");
        }

        public void AddEcoLabel()
        {
            Console.WriteLine("Added ECO label on the back window");
        }

        public new void PrepareForRent()
        {
            base.PrepareForRent();
            this.AddEcoLabel();
        }
    }
}
