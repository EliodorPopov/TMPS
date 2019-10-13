using System;
using System.Collections.Generic;

namespace Patterns
{
    static class VehicleFactory
    {
        private static List<String> japanManufacturers = new List<String>() {"Mazda", "Toyota", "Honda", "Lexus", "Nissan", "Suzuki", "Mitsubishi" };
        private static List<String> germanManufacturers = new List<String>() {"BMW", "Mercedes", "Volkswagen", "Porsche", "Opel", "Audi"};
        private static List<String> americanManufacturers = new List<String>() {"Ford", "Chevrolet", "GMC", "Cadillac",  "Dodge"};


        private static string getCountry(string manufacturer)
        {
            if (japanManufacturers.Contains(manufacturer)) return "Japan";
            if (germanManufacturers.Contains(manufacturer)) return "Germany";
            if (americanManufacturers.Contains(manufacturer)) return "USA";
            return "No Country";
        }

        private static string checkVIN(string code)
        {
            //check VINCode
            return code;
        }

        public static Vehicle CreateSUV(string manufacturer, string model, int year, string vINCode, string fuelType, int maxSpeed)
        {
            return new SUVVehicle(
                manufacturer: manufacturer,
                model: model,
                year: year,
                vINCode: checkVIN(vINCode),
                fuelType: fuelType,
                countryOfManufacture: getCountry(manufacturer),
                maxSpeed: maxSpeed);
        }

        public static Vehicle CreateEconomVehicle(string manufacturer, string model, int year, string vINCode, string fuelType, ChasisTypes chasis)
        {
            return new EconomVehicle(
                manufacturer: manufacturer,
                model: model,
                year: year,
                vINCode: checkVIN(vINCode),
                fuelType: fuelType,
                chasis: chasis,
                countryOfManufacture: getCountry(manufacturer));
        }

        public static Vehicle CreatePremiumVehicle(string manufacturer, string model, int year, string vINCode, string fuelType, int maxSpeed)
        {
            return new PremiumVehicle(
                manufacturer: manufacturer,
                model: model,
                year: year,
                vINCode: checkVIN(vINCode),
                fuelType: fuelType,
                countryOfManufacture: getCountry(manufacturer),
                maxSpeed: maxSpeed);
        }
    }
}
