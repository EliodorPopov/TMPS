using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns
{
    class EconomVehicle : Vehicle
    {
        public EconomVehicle(string manufacturer, string model, int year, string vINCode, string fuelType, ChasisTypes chasis, string countryOfManufacture)
            : base(manufacturer, model, year, vINCode, fuelType, chasis, countryOfManufacture, 150, 4, 5, 20, 9)
        {
        }

        public override void Clean()
        {
            base.Clean();
            Console.WriteLine("Put seat covers to not mess the seats");
        }

        public override void Fuel()
        {
            base.Fuel();
            Console.WriteLine("Check fuel tank for leaks");
        }

        public override void MechanicCheck()
        {
            base.MechanicCheck();
            Console.WriteLine("Adjust fuel lines");
        }
    }
}
