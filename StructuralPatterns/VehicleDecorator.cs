using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns
{
    abstract class VehicleDecorator : IVehicle
    {
        private Vehicle vehicle;

        public VehicleDecorator(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public void Clean()
        {
            vehicle.Clean();
        }

        public void Fuel()
        {
            vehicle.Fuel();
        }

        public void MechanicCheck()
        {
            vehicle.MechanicCheck();
        }

        public void PrepareForRent()
        {
            vehicle.PrepareForRent();
        }

        public void PrintVehicle()
        {
            vehicle.PrintVehicle();
        }
    }
}
