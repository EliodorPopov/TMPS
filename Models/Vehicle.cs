﻿using System;

namespace Patterns
{
    public enum ChasisTypes
    {
        Hatchback, Coupe, Sedan, MPV, SUV, Crossover, Convertible, Motorcycle, Unregistered
    }
    public enum GearboxType
    {
        Automatic, Manual
    }
    public class Vehicle : ICloneable, IVehicle
    {

        public Vehicle(string manufacturer, string model, int year, string vINCode, string fuelType, ChasisTypes chasis, string countryOfManufacture, int maxSpeed, int nrOfWheels, int nrOfSeats, float pricePerHour, float urbanConsumption)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
            VINCode = vINCode;
            FuelType = fuelType;
            Chasis = chasis;
            CountryOfManufacture = countryOfManufacture;
            MaxSpeed = maxSpeed;
            NrOfWheels = nrOfWheels;
            NrOfSeats = nrOfSeats;
            PricePerHour = pricePerHour;
            UrbanConsumption = urbanConsumption;
        }



        private string _VINCode;
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public int Year {get; private set;}
        public string VINCode { get { return _VINCode; } set { _VINCode = value.ToUpper(); } }
        public string FuelType { get; private set; }
        public ChasisTypes Chasis { get; private set; }
        public string CountryOfManufacture { get; private set; }
        public int MaxSpeed { get; set; }
        public int NrOfWheels { get; private set; }
        public int NrOfSeats { get; private set; }
        public float PricePerHour {get; set;}
        public float UrbanConsumption {get; set;}

        public void PrintVehicle()
        {
            
            Console.WriteLine($"\n{Manufacturer} {Model}:" +
                $"\nVIN: {VINCode}" +
                $"\nFuel type: {FuelType}" +
                $"\nChasis: {Chasis}" +
                $"\nCountry: {CountryOfManufacture}" +
                $"\nMax speed: {MaxSpeed} km/h" +
                $"\nDetails: {NrOfSeats} seats" +
                $"\nPrice per hour: {PricePerHour} euro");
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        // Template pattern
        public virtual void Clean()
        {
            Console.WriteLine("Car has been cleaned and it shines");
        }

        public virtual void Fuel()
        {
            Console.WriteLine("Car has been fueled with " + FuelType);
        }

        public virtual void MechanicCheck()
        {
            Console.WriteLine("Car has been checked by the mechanic. Everything looks good!");
        }

        public void PrepareForRent()
        {
            this.Clean();
            this.Fuel();
            this.MechanicCheck();
            Console.WriteLine("Car has been prepared for client");
        }

    }
}
