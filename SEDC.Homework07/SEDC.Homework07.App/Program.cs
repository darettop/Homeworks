using System;
using SEDC.Homework07.Business.Models;
using SEDC.Homework07.Enumeration;

namespace SEDC.Homework07.App
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectricCar elCar = new ElectricCar("Tesla", "Model S",5, 240, Consumption.Economic, 100, 40);
            FuelCar fuelCar = new FuelCar("Renault", "Megane", 5, 200, Consumption.Medium, EngineType.Diesel, 50, 5);
           

            elCar.Recharge(5000);
            fuelCar.Drive(50);

            fuelCar.Refuel(200);
            Console.ReadLine();
        }
    }
}
