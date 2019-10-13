using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns
{
    class PremiumVehicle : Vehicle
    {
    public PremiumVehicle(string manufacturer, string model, int year, string vINCode, string fuelType, string countryOfManufacture, int maxSpeed)
        : base(manufacturer, model, year, vINCode, fuelType, ChasisTypes.Coupe, countryOfManufacture, maxSpeed, 4, 4, 70, 15)
    {

    }

        public override void Clean()
        {
            base.Clean();
        }

        public override void Fuel()
        {
            base.Fuel();
        }

        public override void MechanicCheck()
        {
            base.MechanicCheck();
        }
    }
}
